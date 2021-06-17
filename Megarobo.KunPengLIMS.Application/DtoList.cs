using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application
{
    public class DtoList<T>
    {
        public IEnumerable<T> ObjectList { get; set; }
    }
}
