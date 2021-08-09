using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MolecularCloningUpdateDto
    {
        public float ThicknessValue { get; set; }

        public float Od { get; set; }

        public string Enzyme { get; set; }

        public List<string> Files { get; set; }
    }
}
