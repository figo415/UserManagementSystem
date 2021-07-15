using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;


namespace Megarobo.KunPengLIMS.Application.Services
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
            var pagedDtos = _mapper.Map<List<LogItemDto>>(pagedLogItems);
            return new PagedList<LogItemDto>(pagedDtos, pagedLogItems.TotalCount, pagedLogItems.CurrentPage, pagedLogItems.PageSize);
        }

        public bool InsertLogItem(LogItemCreationDto dto)
        {
            var logitem = _mapper.Map<LogItem>(dto);
            logitem.OperationTime = DateTime.Now;
            _repoWrapper.LogItemRepo.Create(logitem);
            //var result = await _repoWrapper.LogItemRepo.SaveAsync();
            var result = _repoWrapper.LogItemRepo.Save();
            return result;
        }
    }
}
