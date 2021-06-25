using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Exceptions
{
    public class InvalidParentException:Exception
    {
        public InvalidParentException(string message):base(message)
        {

        }
    }
}
