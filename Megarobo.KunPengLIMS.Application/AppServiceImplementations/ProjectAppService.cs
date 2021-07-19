using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class ProjectAppService : IProjectAppService
    {
        public Task<PagedList<ProjectDto>> GetProjectsByPage(ProjectQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProject(ProjectCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProject(Guid projectId, ProjectUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjects(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
