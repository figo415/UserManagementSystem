using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
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
        
        public async Task<IEnumerable<DepartmentDto>> GetDepartmentTree(DepartmentQueryParameters parameters)
        {
            var departments = await _repoWrapper.DepartmentRepo.GetDepartments(parameters);
            departments = departments.OrderByDescending(d => d.CreatedAt);
            var departmentDtos = _mapper.Map<IEnumerable<DepartmentDto>>(departments);
            var tree = GetTree(Guid.Empty, departmentDtos);
            return tree;
        }

        private List<DepartmentDto> GetTree(Guid parentId,IEnumerable<DepartmentDto> dtos)
        {
            var tree = dtos.Where(d => d.ParentId == parentId).ToList();
            foreach(var item in tree)
            {
                item.Children = GetTree(item.Id, dtos);
            }
            return tree;
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
                throw new NotExistedException("Department with Guid=" + departmentId + " is not existed");
            }
            var guids = await GetSelfAndChildren(departmentId);
            if(guids.Contains(dto.ParentId))
            {
                throw new InvalidParentException("Parent department can't be it self and its children");
            }
            _mapper.Map(dto, department, typeof(DepartmentUpdateDto), typeof(Department));
            department.LastModifiedAt = DateTime.Now;
            _repoWrapper.DepartmentRepo.Update(department);
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }

        private async Task<List<Guid>> GetSelfAndChildren(Guid id)
        {
            var children = await _repoWrapper.DepartmentRepo.GetChildrenOfDepartment(id);
            var guids = children.Select(d => d.Id).ToList();
            guids.Add(id);
            return guids;
        }

        public async Task<bool> EnableDepartment(Guid departmentId, DepartmentUpdateStatusDto dto)
        {
            var department = await _repoWrapper.DepartmentRepo.GetByIdAsync(departmentId);
            if (department == null)
            {
                throw new NotExistedException("Department with Guid=" + departmentId + " is not existed");
            }
            department.IsActive = dto.IsActive;
            department.LastModifiedAt = DateTime.Now;
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
                department.LastModifiedAt = DateTime.Now;
                _repoWrapper.DepartmentRepo.Update(department);
            }
            var result = await _repoWrapper.DepartmentRepo.SaveAsync();
            return result;
        }
    }
}
