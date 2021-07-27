using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MolecularCloningDto
    {
        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public string CarrierStructure { get; set; }

        public float Thickness { get; set; }

        public float Od { get; set; }

        public string Enzyme { get; set; }

        public string Status { get; set; }
    }
}
