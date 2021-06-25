using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Exceptions
{
    public class NotExistedException:Exception
    {
        public NotExistedException(string message):base(message)
        {

        }
    }
}
