using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:Irectangle
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public double Breadth{get; set;}

        public void CalculateArea( )
        {
            double Length=20;
            double Breadth=2;
            double Area=Length*Breadth;
            System.Console.WriteLine("Area "+Area);
        }

    }
}