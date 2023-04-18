using System.Reflection;

namespace GeometricFigureSquare
{
    public static class GeometricFigureSquare
    {
        /// <summary>
        /// Get square of the figure
        /// </summary>
        /// <param name="figure">Geometric figure</param>
        /// <returns>Square of the figure</returns>
        public static double GetSquare(IFigure figure)
        {
            return figure.GetSquare();
        }

        /// <summary>
        /// Try get square of the figure
        /// </summary>
        /// <param name="obj">Geometric figure</param>
        /// <param name="result">Result of calculation</param>
        /// <returns>true if square was calculated successfully; otherwise, false</returns>
        public static bool TryGetSquare(object obj, out double result)
        {
            var figure = obj as IFigure;
            if (figure != null)
            {
                result = figure.GetSquare();
                return true;
            }
            result = 0;
            return false;
        }
    }
}