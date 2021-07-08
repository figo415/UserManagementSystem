using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Exceptions
{
    public class AlreadyExistedException:Exception
    {
        public AlreadyExistedException(string message) : base(message)
        {

        }
    }
}
