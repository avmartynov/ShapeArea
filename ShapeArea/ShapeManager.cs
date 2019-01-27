using System;
using System.Collections.Generic;
using System.Linq;
using Tech.Infrastructure.CodeAnnotation;

namespace Tech.ShapeArea
{
    /// <summary>
    /// Менеджер геометрических фигур. 
    /// </summary>
    public class ShapeManager
    {
        /// <summary>
        /// Список доступных геометрических фигур.
        /// </summary>
        public string[] RegisteredShapes 
            => _shapeTypes.Keys.ToArray();

        /// <summary>
        /// Регистрирует тип геометрической фигуры.
        /// </summary>
        public void RegisterShape([NotNull] string shapeName, [NotNull] Type shapeType)
        {
            if (typeof(IShape).IsAssignableFrom(shapeType))
                _shapeTypes.Add(shapeName, shapeType);
            else
                throw new ArgumentException(nameof(shapeType), $"'{shapeType}' has not IShape interface");
        }
 
        /// <summary>
        /// Регистрирует фабрику для создания геометрической фигуры определённого типа.
        /// </summary>
        public void RegisterShape([NotNull] string shapeName, [NotNull] string shapeTypeName)
        {
            var shapeType = Type.GetType(shapeTypeName);
            if (shapeType == null)
                throw new InvalidOperationException($"Can't load type '{shapeTypeName}'");

            RegisterShape(shapeName, shapeType);
        }
 
        /// <summary>
        /// Создаёт экземпляр фигуры.
        /// </summary>
        public IShape CreateShape([NotNull] string shapeName, string initializeString = null)
        {
            if(!_shapeTypes.TryGetValue(shapeName, out var shapeType))
                throw new InvalidOperationException($"Shape '{shapeName}' is not registered.");

            var shape = (IShape)Activator.CreateInstance(shapeType);

            if (!string.IsNullOrEmpty(initializeString))
                shape.Initialise(initializeString);

            return shape;
        }
 
        private readonly Dictionary<string, Type> _shapeTypes = new Dictionary<string, Type>();
    }
}
