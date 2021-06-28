using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class UserQueryParameters:PagedParameters
    {
        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public bool? IsActive { get; set; }

        public Guid? DepartmentId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }

    public class UserQueryParametersExt:UserQueryParameters
    {
        public List<Guid> DepartmentIds { get; set; }

        public UserQueryParametersExt(UserQueryParameters parameters)
        {
            UserName = parameters.UserName;
            MobileNumber = parameters.MobileNumber;
            IsActive = parameters.IsActive;
            DepartmentId = parameters.DepartmentId;
            StartDate = parameters.StartDate;
            EndDate = parameters.EndDate;
            PageNumber = parameters.PageNumber;
            PageSize = parameters.PageSize;
        }
    }
}
