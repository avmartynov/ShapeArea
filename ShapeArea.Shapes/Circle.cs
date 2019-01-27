using System;

namespace Tech.ShapeArea.Shapes
{
    /// <summary>
    /// Геометрическая фигура - Круг
    /// </summary>
    public sealed class Circle : IShape
    {
        /// <inheritdoc />
        public string Description 
            => "Initialise string of circle is circle radius in	dotted-decimal notation.";

        /// <inheritdoc />
        public double CalculateArea() 
            => Math.PI * _radius * _radius;

        /// <inheritdoc />
        public void Initialise(string initialiseString)
        {
            if (!double.TryParse(initialiseString, out _radius) || _radius < 0.0)
                throw new ArgumentException("Radius of circle must be nonnegative number.", nameof(initialiseString));
        }

        private double _radius;
    }
}
