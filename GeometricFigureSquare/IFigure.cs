using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureSquare
{
    /// <summary>
    /// Geometric figure
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculates square of the figure
        /// </summary>
        /// <returns>Square of the figure</returns>
        double GetSquare();
    }
}
