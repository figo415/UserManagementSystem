using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class DictItemQueryParameters:PagedParameters
    {
        public string KeyName { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("KeyName={0}, Type={1}, PageNumber={2}, PageSize={3}", KeyName, Type, PageNumber, PageSize);
        }
    }
}
