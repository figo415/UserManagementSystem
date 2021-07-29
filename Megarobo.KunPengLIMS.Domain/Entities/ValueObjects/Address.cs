using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Owned]
    public class Address:IValueObject
    {
        public string Province { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Detail{ get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", Province, City, District, Detail);
        }
    }
}
