using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureSquare.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        /// <summary>
        /// Radius of the circle
        /// </summary>
        public double Radius
        {
            get { return _radius; }
        }
        /// <summary>
        /// Geometric figure: circle
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        /// <exception cref="ArgumentOutOfRangeException">If the radius is a negative value</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius value cannot be negative");
            _radius = radius;
        }
        double IFigure.GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
