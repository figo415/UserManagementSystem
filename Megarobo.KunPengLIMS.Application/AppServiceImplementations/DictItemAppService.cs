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
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
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
            var pagedDtos = _mapper.Map<List<DictItemDto>>(pagedDictItems);
            return new PagedList<DictItemDto>(pagedDtos, pagedDictItems.TotalCount, pagedDictItems.CurrentPage, pagedDictItems.PageSize);
        }

        public async Task<bool> InsertDictItem(DictItemCreationDto dto)
        {
            var existed = await _repoWrapper.DictItemRepo.GetDictItemsByName(dto.KeyName, null);
            if (existed.Any())
            {
                throw new AlreadyExistedException("DictItem with Name=" + dto.KeyName + " is already existed");
            }
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
                throw new NotExistedException("Dictionary item with Guid=" + dictItemId + " is not existed");
            }
            _mapper.Map(dto, dictitem, typeof(DictItemUpdateDto), typeof(DictItem));
            dictitem.LastModifiedAt = DateTime.Now;
            _repoWrapper.DictItemRepo.Update(dictitem);
            var result = await _repoWrapper.DictItemRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateDictItemValues(Guid dictItemId, DictItemUpdateValueDto dto)
        {
            var dictitem = await _repoWrapper.DictItemRepo.GetByIdAsync(dictItemId);
            if (dictitem == null)
            {
                throw new NotExistedException("Dictionary item with Guid=" + dictItemId + " is not existed");
            }
            _mapper.Map(dto, dictitem, typeof(DictItemUpdateValueDto), typeof(DictItem));
            dictitem.LastModifiedAt = DateTime.Now;
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
                dictitem.LastModifiedAt = DateTime.Now;
                _repoWrapper.DictItemRepo.Update(dictitem);
            }
            var result = await _repoWrapper.DictItemRepo.SaveAsync();
            return result;
        }

        public async Task<List<string>> GetDictItemValues(string keyName)
        {
            var existed = await _repoWrapper.DictItemRepo.GetDictItemsByName(keyName, false);
            if(existed.Any())
            {
                var dictitem = existed.First();
                var dictitemDto = _mapper.Map<DictItemDto>(dictitem);
                return dictitemDto.Values;
            }
            return new List<string>();
        }
    }
}
