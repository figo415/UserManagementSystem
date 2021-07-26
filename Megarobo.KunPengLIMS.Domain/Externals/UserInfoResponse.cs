using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class UserInfoResponse
    {
        public string sub { get; set; }

        public bool email_verified { get; set; }

        public string preferred_username { get; set; }

        public string email { get; set; }
    }
}
