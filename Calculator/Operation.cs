using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operation
    {
        public decimal a {  get; set; }
        public decimal b { get; set; }

        // Method to perform addition
        public static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        // Method to perform subtraction
        public static decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        // Method to perform multiplication
        public static decimal Mult(decimal a, decimal b)
        {
            return a * b;
        }

        // Method to perform division
        public static decimal Div(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
