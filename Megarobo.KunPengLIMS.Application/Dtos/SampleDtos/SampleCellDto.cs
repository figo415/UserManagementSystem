using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleCellDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TissueType { get; set; }

        public string CellLineType { get; set; }

        public string CultivationMethod { get; set; }
    }
}
