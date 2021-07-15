using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IPositionAppService
    {
        Task<IEnumerable<LocationDto>> GetPositions();
    }
}
