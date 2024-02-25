using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class WrongNumberException : ApplicationException
    {
        private string _msg;

        public WrongNumberException()
        {
            _msg = "Wrong input. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
