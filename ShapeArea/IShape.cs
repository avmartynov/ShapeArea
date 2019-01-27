using Tech.Infrastructure.CodeAnnotation;

namespace Tech.ShapeArea
{
    /// <summary>
    /// Интерфейс для вычисления площади геометрической фигуры
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Описание формата инициализирующей строки.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Инициализирует геометрическую фигуру.
        /// </summary>
        void Initialise([NotNull] string initialiseString);

        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        double CalculateArea();
    }
}
