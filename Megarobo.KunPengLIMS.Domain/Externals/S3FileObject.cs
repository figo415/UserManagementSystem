using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class S3FileObject
    {
        public string ETag { get; set; }

        public string Url { get; set; }

        public string ExceptionMessage { get; set; }
    }
}
