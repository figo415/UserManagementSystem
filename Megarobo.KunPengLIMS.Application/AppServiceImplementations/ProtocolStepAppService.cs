using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class ProtocolStepAppService : IProtocolStepAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public ProtocolStepAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }
        
        public Task<IEnumerable<ProtocolStepDto>> GetProtocolStepTree(ProtocolStepQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProtocolStep(ProtocolStepCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProtocolStep(Guid protocolStepId, ProtocolStepUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProtocolSteps(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
