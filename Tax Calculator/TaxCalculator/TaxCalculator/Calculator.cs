using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Calculator
    {
        double sum = 0;

        public double CalculateTax()
        {
            Console.WriteLine("Please enter a value");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the tax percentage");
            double tax = Convert.ToDouble(Console.ReadLine());
            double convertedTax = tax / 100 + 1;
            sum = (convertedTax) * value;

            return sum;
        }
    }
}
