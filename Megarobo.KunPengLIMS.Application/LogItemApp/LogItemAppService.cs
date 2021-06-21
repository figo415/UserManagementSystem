using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.LogItemApp.Dtos;


namespace Megarobo.KunPengLIMS.Application.LogItemApp
{
    public class LogItemAppService:ILogItemAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public LogItemAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async  Task<PagedList<LogItemDto>> GetLogItemsByPage(LogItemQueryParameters parameters)
        {
            var pagedLogItems = await _repoWrapper.LogItemRepo.GetLogItemsByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<LogItemDto>>(pagedLogItems);
            return new PagedList<LogItemDto>(pagedDtos.ToList(), pagedLogItems.TotalCount, pagedLogItems.CurrentPage, pagedLogItems.PageSize);
        }
    }
}
