using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class WrongOperationException : ApplicationException
    {
        private string _msg;

        public WrongOperationException()
        {
            _msg = "Wrong operation. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
