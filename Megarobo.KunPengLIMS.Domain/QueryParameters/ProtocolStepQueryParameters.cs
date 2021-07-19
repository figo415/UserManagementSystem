using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class  ProtocolStepQueryParameters
    {
        public string Description { get; set; }

        public string Note { get; set; }

        public override string ToString()
        {
            return string.Format("Description={0}, Note={1}", Description, Note);
        }
    }
}
