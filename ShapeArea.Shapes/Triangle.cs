using System;

namespace Tech.ShapeArea.Shapes
{
    /// <summary>
    /// Геометрическая фигура - Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        /// <inheritdoc />
        public string Description 
            => "Initialise string of triangle is coma separated list of sides of triagle in dotted-decimal notation.";

        /// <inheritdoc />
        public double CalculateArea()
        {
            if (_a < double.Epsilon || _b < double.Epsilon || _c < double.Epsilon)
                return 0.0;

            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <inheritdoc />
        public void Initialise(string initialiseString)
        {
            var args = initialiseString.Split(',');
            if (args.Length < 3)
                throw new ArgumentException(Description, nameof(args));

            if (!double.TryParse(args[0], out _a) || _a < 0.0 ||
                !double.TryParse(args[1], out _b) || _b < 0.0 ||
                !double.TryParse(args[2], out _c) || _c < 0.0)
            {
                throw new ArgumentException("Side of triangle must be nonnegative.", nameof(args));
            }
        }

        /// <summary>
        /// Возвращает признак того, что треугольник прямоугольный.
        /// </summary>
        /// <returns> Признак того, что треугольник прямоугольный</returns>
        public bool IsRightAngled()
        {
            double a2 = _a * _a, b2 = _b * _b, c2 = _c * _c;
            return Math.Abs( a2 + b2 - c2) < double.Epsilon
                || Math.Abs( a2 - b2 + c2) < double.Epsilon
                || Math.Abs(-a2 + b2 + c2) < double.Epsilon;
        }

        private double _a, _b, _c;
    }
}
