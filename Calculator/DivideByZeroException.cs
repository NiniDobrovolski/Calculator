using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class DivideBy0Exception : ApplicationException
    {
        private string _msg;

        public DivideBy0Exception()
        {
            _msg = "Impossible to divide by zero. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
