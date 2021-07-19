using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class ReagentAppService:IReagentAppService
    {
        private readonly IInventoryService _service;
        private readonly IMapper _mapper;

        public ReagentAppService(IInventoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<PagedList<ReagentDto>> GetReagents(ReagentQueryParameters parameters)
        {
            var paras = new InventoryParameters();
            paras.IsReagent = 0;
            paras.itemName = parameters.Name;
            if (!(parameters.StartDate == null && parameters.EndDate == null))
            {
                paras.addDates = new DateTime[2];
                paras.addDates[0] = parameters.StartDate.Value;
                paras.addDates[1] = parameters.EndDate.Value;
            }
            paras.page = parameters.PageNumber;
            paras.pageSize = parameters.PageSize;
            //paras.TypeId = 16;
            var inventoryData = await _service.GetInventory(paras);
            var list = inventoryData.inventoryList;
            var dtos = _mapper.Map<List<ReagentDto>>(list);
            return new PagedList<ReagentDto>(dtos, inventoryData.total, parameters.PageNumber, parameters.PageSize);
        }
    }
}
