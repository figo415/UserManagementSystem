﻿using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.DepartmentApp
{
    public interface IDepartmentAppService
    {
        Task<PagedList<DepartmentDto>> GetDepartmentsByPage(DepartmentQueryParameters parameters);

        Task<DepartmentDto> GetDepartment(Guid departmentId);

        Task<PagedList<UserDto>> GetUsersByDepartment(Guid departmentId, PagedParameters parameters);

        Task<bool> InsertDepartment(DepartmentCreationDto dto);

        Task<bool> UpdateDepartment(Guid departmentId, DepartmentUpdateDto dto);

        Task<bool> EnableDepartment(Guid departmentId, DepartmentUpdateStatusDto dto);

        Task<bool> DeleteDepartments(DeleteMultiDto dto);
    }
}
