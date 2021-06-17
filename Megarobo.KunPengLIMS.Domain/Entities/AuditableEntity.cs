using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public abstract class AuditableEntity : Entity, IAuditableEntity,ISoftDelete
    {
        //public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        //public string LastModifiedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
