using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IProcessAppService
    {
        Task<PagedList<ProcessDto>> GetProcessesByPage(ProcessQueryParameters parameters);

        Task<bool> InsertProcess(ProcessCreationDto dto);

        Task<bool> UpdateProcess(Guid processId, ProcessUpdateDto dto);

        Task<bool> DeleteProcesses(DeleteMultiDto dto);
    }
}
