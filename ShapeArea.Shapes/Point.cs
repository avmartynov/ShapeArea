namespace Tech.ShapeArea.Shapes
{
    /// <summary>
    /// Геометрическая фигура - Точка
    /// </summary>
    public class Point : IShape
    {
        /// <inheritdoc />
        public string Description 
            => "Initialise string of point is not used.";

        /// <inheritdoc />
        public double CalculateArea() 
            => 0.0;

        /// <inheritdoc />
        public void Initialise(string initialiseString)
        {
        }
    }
}
