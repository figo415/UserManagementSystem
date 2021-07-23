using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class UserWithRightsDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public List<string> BtnList { get; set; }

        public List<MenuDto> Menus { get; set; }
    }
}
