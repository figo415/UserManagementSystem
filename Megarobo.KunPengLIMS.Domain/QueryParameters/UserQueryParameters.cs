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

        public override string ToString()
        {
            return string.Format("UserName={0}, MobileNumber={1}, IsActive={2}, DepartmentId={3}, StartDate={4}, EndDate={5}, PageNumber={6}, PageSize={7}", UserName, MobileNumber, IsActive, DepartmentId, StartDate, EndDate, PageNumber, PageSize);
        }
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
