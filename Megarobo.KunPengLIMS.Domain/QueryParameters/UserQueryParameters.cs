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

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
