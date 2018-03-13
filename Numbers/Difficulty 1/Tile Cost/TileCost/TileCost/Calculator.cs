using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileCost
{
    public class Calculator
    {

        private double totalCost = 0;
        private double area = 0;

        public double CalculateCost()
        {
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double costPrSqm = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            totalCost = costPrSqm * area;

            return totalCost;
        }
    }
}
