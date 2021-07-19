using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IProjectAppService
    {
        Task<PagedList<ProjectDto>> GetProjectsByPage(ProjectQueryParameters parameters);

        Task<bool> InsertProject(ProjectCreationDto dto);

        Task<bool> UpdateProject(Guid projectId, ProjectUpdateDto dto);

        Task<bool> DeleteProjects(DeleteMultiDto dto);
    }
}
