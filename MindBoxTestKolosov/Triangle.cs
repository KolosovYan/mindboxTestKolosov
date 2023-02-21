using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestKolosov
{
    public class Triangle : Figure
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public bool IsRectangular;

        protected Triangle() : base("Triangle")
        {
            IsRectangular = CheckTriangleIsRectangular();
        }

        public Triangle(double a, double b, double c) : this()
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Get Triangle Area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double Area;
            double p = (SideA + SideB + SideC) / 2; //Half of perimeter
            Area = Math.Sqrt( p * (p - SideA) * (p - SideB) * (p - SideC) );
            return Area;
        }

        public bool CheckTriangleIsRectangular()
        {
            List<double> Sides = new List<double> { SideA, SideB, SideC };
            double Hypotenuse = Sides.Max();
            Sides.Remove(Sides.Max());
            if ( Math.Pow(Hypotenuse, 2) == ( Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) ) )
            {
                return true;
            }

            return false;
        }
    }
}
