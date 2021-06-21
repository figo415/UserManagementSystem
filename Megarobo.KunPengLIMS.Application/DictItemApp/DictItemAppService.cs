using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.DictItemApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.DictItemApp
{
    public class DictItemAppService: IDictItemAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public DictItemAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<DictItemDto>> GetDictItemsByPage(DictItemQueryParameters parameters)
        {
            var pagedDictItems = await _repoWrapper.DictItemRepo.GetDictItemsByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<DictItemDto>>(pagedDictItems);
            return new PagedList<DictItemDto>(pagedDtos.ToList(), pagedDictItems.TotalCount, pagedDictItems.CurrentPage, pagedDictItems.PageSize);
        }

        public async Task<bool> InsertDictItem(DictItemCreationDto dto)
        {
            var dictitem = _mapper.Map<DictItem>(dto);
            dictitem.Id = Guid.NewGuid();
            dictitem.CreatedAt = DateTime.Now;
            dictitem.IsDeleted = false;
            _repoWrapper.DictItemRepo.Create(dictitem);
            var result = await _repoWrapper.DictItemRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateDictItem(Guid dictItemId, DictItemUpdateDto dto)
        {
            var dictitem = await _repoWrapper.DictItemRepo.GetByIdAsync(dictItemId);
            if (dictitem == null)
            {
                return false;
            }
            _mapper.Map(dto, dictitem, typeof(DictItemUpdateDto), typeof(DictItem));
            _repoWrapper.DictItemRepo.Update(dictitem);
            var result = await _repoWrapper.DictItemRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteDictItems(DeleteMultiDto dto)
        {
            foreach (var dictitemId in dto.Guids)
            {
                var dictitem = await _repoWrapper.DictItemRepo.GetByIdAsync(dictitemId);
                if (dictitem == null)
                {
                    continue;
                }
                dictitem.IsDeleted = true;
                _repoWrapper.DictItemRepo.Update(dictitem);
            }
            var result = await _repoWrapper.DictItemRepo.SaveAsync();
            return result;
        }
    }
}
