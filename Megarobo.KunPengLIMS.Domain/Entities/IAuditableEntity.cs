using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public interface IAuditableEntity
    {
        //string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        //string LastModifiedBy { get; set; }
        DateTime LastModifiedAt { get; set; }
    }
}
