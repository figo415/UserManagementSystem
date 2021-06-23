using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DtoList<T>
    {
        public IEnumerable<T> ObjectList { get; set; }
    }
}
