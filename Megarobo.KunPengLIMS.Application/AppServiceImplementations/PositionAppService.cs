using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class PositionAppService:IPositionAppService
    {
        private readonly IInventoryService _service;
        private readonly IMapper _mapper;

        public PositionAppService(IInventoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocationDto>> GetPositions()
        {
            var locationlist= await _service.GetLocations();
            var dtos = _mapper.Map<List<LocationDto>>(locationlist);
            foreach(var dto in dtos)
            {
                TraverseTree(dto);
            }
            return dtos;
        }

        private void TraverseTree(LocationDto root)
        {
            if(root.children.Any())
            {
                foreach(var node in root.children)
                {
                    TraverseTree(node);
                }
            }
            else
            {
                root.children = null;
            }
        }
    }
}
