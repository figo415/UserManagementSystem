﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Domain.IRepositories;
using Megarobo.KunPengLIMS.Domain.Entities;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Application.DepartmentApp
{
    /// <summary>
    /// 部门管理服务
    /// </summary>
    public class DepartmentAppService : IDepartmentAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public DepartmentAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<DepartmentDto>> GetDepartmentsByPage(DepartmentQueryParameters parameters)
        {
            var pagedDepartments = await _repoWrapper.DepartmentRepo.GetDepartmentsByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<DepartmentDto>>(pagedDepartments);
            return new PagedList<DepartmentDto>(pagedDtos.ToList(), pagedDepartments.TotalCount, pagedDepartments.CurrentPage, pagedDepartments.PageSize);
        }

        public async Task<DepartmentDto> GetDepartment(Guid departmentId)
        {
            var department = await _repoWrapper.UserRepo.GetByIdAsync(departmentId);
            var dto = _mapper.Map<DepartmentDto>(department);
            return dto;
        }

        public async Task<PagedList<UserDto>> GetUsersByDepartment(Guid departmentId, PagedParameters parameters)
        {
            var pagedUsers = await _repoWrapper.DepartmentRepo.GetUsersByDepartment(departmentId, parameters);
            var pagedDtos = _mapper.Map<IEnumerable<UserDto>>(pagedUsers);
            return new PagedList<UserDto>(pagedDtos.ToList(), pagedUsers.TotalCount, pagedUsers.CurrentPage, pagedUsers.PageSize);
        }

        public async Task<bool> InsertDepartment(DepartmentCreationDto dto)
        {
            var department = _mapper.Map<Department>(dto);
            department.Id = Guid.NewGuid();
            department.CreatedAt = DateTime.Now;
            department.IsDeleted = false;
            _repoWrapper.DepartmentRepo.Create(department);
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateDepartment(Guid departmentId, DepartmentUpdateDto dto)
        {
            var department = await _repoWrapper.DepartmentRepo.GetByIdAsync(departmentId);
            if (department == null)
            {
                return false;
            }
            _mapper.Map(dto, department, typeof(DepartmentUpdateDto), typeof(Department));
            _repoWrapper.DepartmentRepo.Update(department);
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableDepartment(Guid departmentId, DepartmentUpdateStatusDto dto)
        {
            var department = await _repoWrapper.DepartmentRepo.GetByIdAsync(departmentId);
            if (department == null)
            {
                return false;
            }
            department.IsActive = dto.IsActive;
            _repoWrapper.DepartmentRepo.Update(department);
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteDepartments(DeleteMultiDto dto)
        {
            foreach (var departmentId in dto.Guids)
            {
                var department = await _repoWrapper.DepartmentRepo.GetByIdAsync(departmentId);
                if (department == null)
                {
                    continue;
                }
                department.IsDeleted = true;
                _repoWrapper.DepartmentRepo.Update(department);
            }
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }
    }
}
