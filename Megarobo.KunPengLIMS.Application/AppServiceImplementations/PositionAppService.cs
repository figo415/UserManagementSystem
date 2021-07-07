using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class PositionAppService:IPositionAppService
    {
        private readonly ILocationService _service;
        private readonly IMapper _mapper;

        public PositionAppService(ILocationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocationDto>> GetPositions()
        {
            var locationData = await _service.GetLocations();
            var list = locationData.locationList;
            var dtos = _mapper.Map<List<LocationDto>>(list);
            return dtos;
        }
        
    }
}
