using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class TakeDto
    {
        public int TakeNum { get; set; }

        public string ProjectName { get; set; }

        public int ParentTakeNum { get; set; }

        public string StartNode { get; set; }

        public string Status { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
