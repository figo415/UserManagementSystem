using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public OrderAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<OrderDto>> GetOrdersByPage(OrderQueryParameters parameters)
        {
            var pagedOrders = await _repoWrapper.OrderRepo.GetOrdersByPage(parameters);
            var pagedDtos = _mapper.Map<List<OrderDto>>(pagedOrders);
            return new PagedList<OrderDto>(pagedDtos, pagedOrders.TotalCount, pagedOrders.PageNumber, pagedOrders.PageSize);
        }

        public async Task<bool> InsertOrder(OrderCreationDto dto)
        {
            var existed = await _repoWrapper.OrderRepo.GetOrdersByCode(dto.ContractCode);
            if (existed.Any())
            {
                throw new AlreadyExistedException("Order with Contract Code=" + dto.ContractCode + " is already existed");
            }
            var order = _mapper.Map<Order>(dto);
            if (!(order.Status == OrderStatusEnum.OrderReceived || order.Status==OrderStatusEnum.WaitForProducing))
            {
                throw new ArgumentException("New order only can be OrderReceived or WaitForProducing status");
            }
            order.Id = Guid.NewGuid();
            order.CreatedAt = DateTime.Now;
            order.IsDeleted = false;
            _repoWrapper.OrderRepo.Create(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateOrder(Guid orderId, OrderUpdateDto dto)
        {
            var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            _mapper.Map(dto, order, typeof(OrderUpdateDto), typeof(Order));
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> CancelOrder(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if(!(order.Status==OrderStatusEnum.OrderReceived || order.Status==OrderStatusEnum.WaitForProducing))
            {
                throw new InvalidOperationException("Order only with status OrderReceived or WaitForProducing can be cancelled");
            }
            order.Status = OrderStatusEnum.Cancelled;
            //order.IsDeleted = true;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> CloneMolecule(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetOrderWithMolecule(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if(order.Status!=OrderStatusEnum.OrderReceived)
            {
                throw new InvalidOperationException("Order only with OrderReceived status can do Molecular Cloning");
            }
            if(order.MolecularCloning!=null)
            {
                throw new InvalidOperationException("Molecular Cloning was already done for this order");
            }
            var plasmidOrder = await _repoWrapper.OrderRepo.GetOrderWithPlasmid(orderId);
            if(plasmidOrder!=null && plasmidOrder.PlasmidPurification!=null)
            {
                throw new InvalidOperationException("Plasmid Purification was already done, no need to do Molecular Cloning");
            }
            order.Status = OrderStatusEnum.WaitForProducing;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var molecule = new MolecularCloning();
            molecule.Id = Guid.NewGuid();
            molecule.CreatedAt = DateTime.Now;
            molecule.IsDeleted = false;
            molecule.Status = MolecularCloningStatusEnum.WaitForCloning;
            molecule.OrderId = order.Id;
            molecule.ContractCode = order.ContractCode;
            molecule.ContractType = order.ContractType;
            molecule.CarrierCode = order.CarrierCode;
            molecule.CarrierStructure = order.CarrierStructure;
            molecule.OrderCreateTime = order.CreatedAt;
            _repoWrapper.MolecularCloningRepo.Create(molecule);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> PurifyPlasmid(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetOrderWithPlasmid(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if (!(order.Status == OrderStatusEnum.OrderReceived))
            {
                throw new InvalidOperationException("Order only with OrderReceived status can do Plasmid Purification");
            }
            if (order.PlasmidPurification != null)
            {
                throw new InvalidOperationException("Plasmid Purification was already done for this order");
            }
            var molecularOrder = await _repoWrapper.OrderRepo.GetOrderWithMolecule(orderId);
            if (molecularOrder != null && molecularOrder.MolecularCloning != null && molecularOrder.MolecularCloning.Status!=MolecularCloningStatusEnum.Finished)
            {
                throw new InvalidOperationException("Molecular Cloning must be finished before doing Plasmid Purification");
            }
            order.Status = OrderStatusEnum.WaitForProducing;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var plasmid = new PlasmidPurification();
            plasmid.Id = Guid.NewGuid();
            plasmid.CreatedAt = DateTime.Now;
            plasmid.IsDeleted = false;
            plasmid.Status = PlasmidPurificationStatusEnum.WaitForPurifying;
            plasmid.OrderId = order.Id;
            plasmid.ContractCode = order.ContractCode;
            plasmid.ContractType = order.ContractType;
            plasmid.CarrierCode = order.CarrierCode;
            plasmid.CarrierStructure = order.CarrierStructure;
            plasmid.PlasmidType = order.PlasmidType;
            plasmid.PlasmidSize = order.PlasmidSize;
            plasmid.OrderCreateTime = order.CreatedAt;
            _repoWrapper.PlasmidPurificationRepo.Create(plasmid);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> StartProduce(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if (!(order.Status == OrderStatusEnum.OrderReceived || order.Status == OrderStatusEnum.WaitForProducing))
            {
                throw new InvalidOperationException("Order only with OrderReceived or WaitForProducing status can start producing");
            }
            var molecular = await _repoWrapper.MolecularCloningRepo.GetMolecularCloningByOrder(order.Id);
            if(molecular!=null && molecular.Status!=MolecularCloningStatusEnum.Finished)
            {
                throw new InvalidOperationException("Molecular cloning must be finished for this order");
            }
            var plasmid = await _repoWrapper.PlasmidPurificationRepo.GetPlasmidPurificationByOrder(order.Id);
            if(plasmid!=null && plasmid.Status!=PlasmidPurificationStatusEnum.Finished)
            {
                throw new InvalidOperationException("Plasmid purification must be finished for this order");
            }
            order.Status = OrderStatusEnum.InProducing;
            order.StartDate = DateTime.Now;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> QcAndStockIn(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if(order.Status!=OrderStatusEnum.InProducing)
            {
                throw new InvalidOperationException("Order must be InProducing status");
            }
            var qpcrOrder = await _repoWrapper.OrderRepo.GetOrderWithQpcr(orderId);
            if(qpcrOrder!=null && qpcrOrder.QpcrDetection!=null)
            {
                throw new InvalidOperationException("QpcrDetection etc. were already existed for this order");
            }
            //order.Status = OrderStatusEnum.InProducing;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var qpcr = new QpcrDetection();
            qpcr.Id = Guid.NewGuid();
            qpcr.CreatedAt = DateTime.Now;
            qpcr.IsDeleted = false;
            qpcr.Status = DetectionStatusEnum.WaitForDetecting;
            qpcr.OrderId = order.Id;
            qpcr.ContractCode = order.ContractCode;
            qpcr.ContractType = order.ContractType;
            qpcr.CarrierCode = order.CarrierCode;
            qpcr.OrderCreateTime = order.CreatedAt;
            _repoWrapper.QpcrDetectionRepo.Create(qpcr);
            if(order.ContractType==ContractTypeEnum.AAV)
            {
                var sdspage = new SdsPageDetection();
                sdspage.Id = Guid.NewGuid();
                sdspage.CreatedAt = DateTime.Now;
                sdspage.IsDeleted = false;
                sdspage.Status = DetectionStatusEnum.WaitForDetecting;
                sdspage.OrderId = order.Id;
                sdspage.ContractCode = order.ContractCode;
                sdspage.ContractType = ContractTypeEnum.AAV;
                sdspage.CarrierCode = order.CarrierCode;
                sdspage.OrderCreateTime = order.CreatedAt;
                _repoWrapper.SdsPageDetectionRepo.Create(sdspage);
            }
            var sterility = new SterilityDetection();
            sterility.Id = Guid.NewGuid();
            sterility.CreatedAt = DateTime.Now;
            sterility.IsDeleted = false;
            sterility.Status = DetectionStatusEnum.WaitForDetecting;
            sterility.OrderId = order.Id;
            sterility.ContractCode = order.ContractCode;
            sterility.ContractType = order.ContractType;
            sterility.CarrierCode = order.CarrierCode;
            sterility.OrderCreateTime = order.CreatedAt;
            _repoWrapper.SterilityDetectionRepo.Create(sterility);
            var stockin = new StockIn();
            stockin.Id = Guid.NewGuid();
            stockin.CreatedAt = DateTime.Now;
            stockin.IsDeleted = false;
            stockin.Status = StockStatusEnum.WaitForStocking;
            stockin.OrderId = order.Id;
            stockin.ContractCode = order.ContractCode;
            stockin.ContractType = order.ContractType;
            stockin.CarrierCode = order.CarrierCode;
            stockin.OrderCreateTime = order.CreatedAt;
            _repoWrapper.StockInRepo.Create(stockin);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> FinishOrder(Guid orderId)
        {
            var order = await _repoWrapper.OrderRepo.GetOrderWithShipment(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            if (order.Status != OrderStatusEnum.InProducing)
            {
                throw new InvalidOperationException("Order must be InProducing status");
            }
            if(order.Shipment!=null)
            {
                throw new InvalidOperationException("Shipment was already existed for this order");
            }
            order.Status = OrderStatusEnum.Finished;
            order.FinisheDate = DateTime.Now;
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var shipment = new Shipment();
            shipment.Id = Guid.NewGuid();
            shipment.CreatedAt = DateTime.Now;
            shipment.IsDeleted = false;
            shipment.Status = ShipmentStatusEnum.WaitForShipping;
            shipment.OrderId = order.Id;
            shipment.ContractCode = order.ContractCode;
            shipment.ContractType = order.ContractType;
            shipment.CarrierCode = order.CarrierCode;
            shipment.OrderCreateTime = order.CreatedAt;
            _repoWrapper.ShipmentRepo.Create(shipment);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteOrders(DeleteMultiDto dto)
        {
            foreach (var orderId in dto.Guids)
            {
                var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
                if (order == null)
                {
                    continue;
                }
                order.IsDeleted = true;
                order.LastModifiedAt = DateTime.Now;
                _repoWrapper.OrderRepo.Update(order);
            }
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }
    }
}
