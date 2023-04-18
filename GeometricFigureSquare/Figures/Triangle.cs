using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureSquare.Figures
{
    public class Triangle : IFigure
    {
        private readonly IEnumerable<double> _sides = new double[3];
        /// <summary>
        /// Sides of the triangle
        /// </summary>
        public IEnumerable<double> Sides
        {
            get
            {
                return _sides;
            }
        }
        /// <summary>
        /// Is this triangle right
        /// </summary>
        public bool IsRight
        {
            get
            {
                var squaredMaxSide = Math.Pow(_sides.Max(), 2);
                return squaredMaxSide == _sides.Select(c => Math.Pow(c, 2)).Sum() - squaredMaxSide;
            }
        }

        /// <summary>
        /// Geometric figure: triangle
        /// </summary>
        /// <param name="sides">Sides of the triangle</param>
        /// <exception cref="ArgumentOutOfRangeException">If there are less than three sides or some side has a negative value</exception>
        public Triangle(IEnumerable<double> sides)
        {
            if (sides.Count() != _sides.Count() || sides.Where(c => c <= 0).Any())
            {
                throw new ArgumentOutOfRangeException("Side value cannot be negative");
            }
            if (sides.Max() >= sides.Sum() - sides.Max())
            {
                throw new ArgumentOutOfRangeException("Side value cannot be negative");
            }
            _sides = sides;
        }
        double IFigure.GetSquare()
        {
            var semiPer = _sides.Sum() / 2;
            return Math.Sqrt(semiPer * _sides.Select(c => semiPer - c).Aggregate((c, x) => c * x));
        }
    }
}
