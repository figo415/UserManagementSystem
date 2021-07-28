using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MenuButtonForRole
    {
        public Guid MenuId { get; set; }

        public List<string> SelectedButtonList { get; set; }
    }
}
