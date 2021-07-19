using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IProtocolStepAppService
    {
        Task<IEnumerable<ProtocolStepDto>> GetProtocolStepTree(ProtocolStepQueryParameters parameters);

        Task<bool> InsertProtocolStep(ProtocolStepCreationDto dto);

        Task<bool> UpdateProtocolStep(Guid protocolStepId,  ProtocolStepUpdateDto dto);

        Task<bool> DeleteProtocolSteps(DeleteMultiDto dto);
    }
}
