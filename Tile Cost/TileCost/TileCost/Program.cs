using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileCost
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Please provide width, length and cost pr sqm.");
            Console.WriteLine("The total cost is " + calc.CalculateCost() + "$");

            Console.ReadKey();

        }


    }
}
