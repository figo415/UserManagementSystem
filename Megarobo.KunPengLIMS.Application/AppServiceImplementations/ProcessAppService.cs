using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class ProcessAppService : IProcessAppService
    {
        public Task<PagedList<ProcessDto>> GetProcessesByPage(ProcessQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProcess(ProcessCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProcess(Guid processId, ProcessUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProcesses(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
