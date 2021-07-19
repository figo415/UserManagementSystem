using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface INodeAppService
    {
        Task<PagedList<NodeDto>> GetNodesByPage(NodeQueryParameters parameters);

        Task<bool> InsertNode(NodeCreationDto dto);

        Task<bool> UpdateNode(Guid nodeId, NodeUpdateDto dto);

        Task<bool> DeleteNodes(DeleteMultiDto dto);
    }
}
