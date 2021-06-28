using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class SkillQueryParameters:PagedParameters
    {
        public string SkillName { get; set; }

        public override string ToString()
        {
            return string.Format("SkillName={0}, PageNumber={1}, PageSize={2}", SkillName, PageNumber, PageSize);
        }
    }
}
