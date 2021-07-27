using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class OrderUpdateDto
    {
        public string CarrierCode { get; set; }

        public string CarrierStructure { get; set; }

        public int PlasmidSize { get; set; }

        public string InsertionSequence { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime Deadline { get; set; }

        public float DemandTiter { get; set; }

        public float TotelDemand { get; set; }

        public string SeroType { get; set; }

        public int PackagingTrayNumber { get; set; }

        public float SubpackageCubage { get; set; }

        public int SubpackageNumber { get; set; }

        public float Plasmid1 { get; set; }

        public float Plasmid2 { get; set; }

        public float Plasmid3 { get; set; }

        public float Plasmid4 { get; set; }

        public object AnalysisReport { get; set; }

        public string Memo { get; set; }
    }
}
