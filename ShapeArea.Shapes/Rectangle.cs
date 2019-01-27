using System;

namespace Tech.ShapeArea.Shapes
{
    /// <summary>
    /// Геометрическая фигура - Прямоугольник
    /// </summary>
    public class Rectangle : IShape
    {
        /// <inheritdoc />
        public string Description 
            => "Initialise string of rectangle is coma separated list of sides of rectangle in dotted-decimal notation.";

        /// <inheritdoc />
        public double CalculateArea()
        {
            if (_a < double.Epsilon || _b < double.Epsilon)
                return 0.0;

            return _a * _b;
        }

        /// <inheritdoc />
        public void Initialise(string initialiseString)
        {
            var args = initialiseString.Split(',');
            if (args.Length < 2)
                throw new ArgumentException(Description, nameof(args));

            if (!double.TryParse(args[0], out _a) || _a < 0.0 ||
                !double.TryParse(args[1], out _b) || _b < 0.0 )
            {
                throw new ArgumentException("Side of rectangle must be nonnegative number.", nameof(args));
            }
        }

        private double _a, _b;
    }
}
