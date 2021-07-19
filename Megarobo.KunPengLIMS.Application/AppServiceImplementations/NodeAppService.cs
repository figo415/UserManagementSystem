using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class NodeAppService : INodeAppService
    {
        public Task<PagedList<NodeDto>> GetNodesByPage(NodeQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertNode(NodeCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNode(Guid nodeId, NodeUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNodes(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
