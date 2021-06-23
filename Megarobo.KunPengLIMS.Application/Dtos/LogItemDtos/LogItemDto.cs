using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LogItemDto
    {
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
