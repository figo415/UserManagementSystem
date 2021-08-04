using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DocumentDto
    {
        public Guid Id { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }
    }
}
