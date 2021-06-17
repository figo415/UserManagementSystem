using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserResourceParameter
    {
        public const int MaxPageSize = 50;

        private int _pageSize = 10;

        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public string DepartmentName { get; set; }

        public string SkillName { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
