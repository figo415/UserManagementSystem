using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class LogItem
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string ModuleName { get; set; }

        public string OperationType { get; set; }

        public string OperationName { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public string Operator { get; set; }

        public DateTime OperationTime { get; set; }

        public string RequestUrl { get; set; }

        public string RequestParameters { get; set; }

        public string StackTrace { get; set; }
    }
}
