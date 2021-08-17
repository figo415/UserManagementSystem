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
    public class StockInAppService : IStockInAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public StockInAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<StockInDto>> GetStockInsByPage(StockInQueryParameters parameters)
        {
            var pagedStockIns = await _repoWrapper.StockInRepo.GetStockInsByPage(parameters);
            var pagedDtos = _mapper.Map<List<StockInDto>>(pagedStockIns);
            return new PagedList<StockInDto>(pagedDtos, pagedStockIns.TotalCount, pagedStockIns.PageNumber, pagedStockIns.PageSize);
        }

        public async Task<bool> UpdateStockIn(Guid stockInId, StockInUpdateDto dto)
        {
            var stockin = await _repoWrapper.StockInRepo.GetByIdAsync(stockInId);
            if (stockin == null)
            {
                throw new NotExistedException("StockIn with Guid=" + stockInId + " is not existed");
            }
            if (stockin.Status == StockStatusEnum.StockedIn)
            {
                throw new InvalidOperationException("This order is already stocked in");
            }
            //var qpcr = await _repoWrapper.QpcrDetectionRepo.GetQpcrDetectionByOrder(stockin.OrderId);
            //if(qpcr.Status!=DetectionStatusEnum.Finished)
            //{
            //    throw new InvalidOperationException("qPCR detection must be finished");
            //}
            //if(stockin.ContractType==ContractTypeEnum.AAV)
            //{
            //    var sdspage = await _repoWrapper.SdsPageDetectionRepo.GetSdsPageDetectionByOrder(stockin.OrderId);
            //    if (sdspage.Status != DetectionStatusEnum.Finished)
            //    {
            //        throw new InvalidOperationException("SDS-PAGE detection must be finished");
            //    }
            //}
            //var sterility = await _repoWrapper.SterilityDetectionRepo.GetSterilityDetectionByOrder(stockin.OrderId);
            //if(sterility.Status!=DetectionStatusEnum.Finished)
            //{
            //    throw new InvalidOperationException("Sterility detection must be finished");
            //}
            _mapper.Map(dto, stockin, typeof(StockInUpdateDto), typeof(StockIn));
            stockin.Status = StockStatusEnum.StockedIn;
            stockin.LastModifiedAt = DateTime.Now;
            _repoWrapper.StockInRepo.Update(stockin);
            var result = await _repoWrapper.StockInRepo.SaveAsync();
            return result;
        }
    }
}

