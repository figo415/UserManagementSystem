using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class PageModel
    {
        public int RowCount { get; set; }

        public int PageCount { get; set; }

        public object Rows { get; set; }
    }
}
