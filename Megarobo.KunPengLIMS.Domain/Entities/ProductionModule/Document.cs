using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Document:Entity
    {
        public string FileName { get; set; }

        public DateTime CreatedAt { get; set; }

        public byte[] Content { get; set; }
    }
}
