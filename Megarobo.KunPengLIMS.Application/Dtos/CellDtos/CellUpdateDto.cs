using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class CellUpdateDto
    {
        public string Name { get; set; }

        public string TissueType { get; set; }

        public string CellLineType { get; set; }

        public string CultivationMethod { get; set; }

        public int BioSafetyLevel { get; set; }

        public string Disease { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public int CrisprOrderLevel { get; set; }

        public string AtccId { get; set; }

        public string AtccUrl { get; set; }

        public string PurchaseFromName { get; set; }

        public string PurchaseFromUrl { get; set; }

        public string PurchasePrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string Remarks { get; set; }

        public Guid SpeciesId { get; set; }
    }
}
