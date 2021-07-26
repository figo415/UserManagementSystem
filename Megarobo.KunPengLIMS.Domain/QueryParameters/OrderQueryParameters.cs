﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class OrderQueryParameters:PagedParameters
    {
        public string ContractCode { get; set; }

        public string ContractType { get; set; }

        public string Status { get; set; }

        public string CarrierCode { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}