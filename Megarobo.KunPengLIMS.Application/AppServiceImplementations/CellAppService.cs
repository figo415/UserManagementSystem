using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
    public class CellAppService:ICellAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly ISpeciesAppService _speciesAppService;

        public CellAppService(IRepositoryWrapper wrapper, IMapper mapper, ISpeciesAppService speciesAppService)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
            _speciesAppService = speciesAppService;
        }

        public async Task<PagedList<CellDto>> GetCellsByPage(CellQueryParameters parameters)
        {
            var pagedCells = await _repoWrapper.CellRepo.GetCellsByPage(parameters);
            var pagedDtos = _mapper.Map<List<CellDto>>(pagedCells);
            return new PagedList<CellDto>(pagedDtos, pagedCells.TotalCount, pagedCells.CurrentPage, pagedCells.PageSize);
        }
        
        public async Task<bool> InsertCell(CellCreationDto dto)
        {
            var existed = await _repoWrapper.CellRepo.GetCellsByName(dto.Name);
            if(existed.Any())
            {
                throw new AlreadyExistedException("Cell with Name=" + dto.Name + " is already existed");
            }
            var cell = _mapper.Map<Cell>(dto);
            cell.Id = Guid.NewGuid();
            cell.CreatedAt = DateTime.Now;
            cell.IsDeleted = false;
            if(dto.SpeciesList.Any())
            {
                cell.SpeciesId = dto.SpeciesList[0].Id;
            }
            var cnt = await _repoWrapper.CellRepo.GetCellCount();
            cell.CellCode = "KPCL" + (cnt + 1).ToString().PadLeft(5, '0');
            _repoWrapper.CellRepo.Create(cell);
            var result = await _repoWrapper.CellRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateCell(Guid cellId, CellUpdateDto dto)
        {
            var cell = await _repoWrapper.CellRepo.GetByIdAsync(cellId);
            if (cell == null)
            {
                throw new NotExistedException("Cell with Guid=" + cellId + " is not existed");
            }
            if(dto.Name!=cell.Name)
            {
                var existed = await _repoWrapper.CellRepo.GetCellsByName(dto.Name);
                if (existed.Any())
                {
                    throw new AlreadyExistedException("Cell with Name=" + dto.Name + " is already existed");
                }
            }
            _mapper.Map(dto, cell, typeof(CellUpdateDto), typeof(Cell));
            cell.LastModifiedAt = DateTime.Now;
            if(dto.SpeciesList.Any())
            {
                cell.SpeciesId = dto.SpeciesList[0].Id;
            }
            else
            {
                cell.SpeciesId = null;
            }
            _repoWrapper.CellRepo.Update(cell);
            var result = await _repoWrapper.CellRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteCells(DeleteMultiDto dto)
        {
            foreach (var cellId in dto.Guids)
            {
                var cell = await _repoWrapper.CellRepo.GetByIdAsync(cellId);
                if (cell == null)
                {
                    continue;
                }
                cell.IsDeleted = true;
                cell.LastModifiedAt = DateTime.Now;
                _repoWrapper.CellRepo.Update(cell);
            }
            var result = await _repoWrapper.CellRepo.SaveAsync();
            return result;
        }
    }
}
