﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class NodeQueryParameters
    {
        public string Name { get; set; }

        public string NodeTypeName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, NodeTypeName={1}, StartDate={2}, EndDate={3}", Name, NodeTypeName, StartDate, EndDate);
        }
    }
}
