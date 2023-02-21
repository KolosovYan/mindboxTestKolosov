using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestKolosov
{
    public class Circle : Figure
    {
        public double Radius;
        protected Circle() : base("Circle")
        {

        }

        /// <summary>
        /// Create Circle
        /// </summary>
        /// <param name="r">Radius</param>
        public Circle(double r) : this()
        {
            Radius = r;
        }

        /// <summary>
        /// Get Circle Area
        /// </summary>
        public override double CalculateArea()
        {
            double Area;
            Area = (Math.PI * (Radius * Radius));
            return Area;
        }
    }
}
