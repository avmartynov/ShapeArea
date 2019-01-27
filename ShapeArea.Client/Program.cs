using System;
using System.Collections.Specialized;
using System.Configuration;
using Tech.ShapeArea;

namespace ShapeArea.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var shapeManager = CreateShapeManager();

                if (args.Length == 0)
                {
                    // Выводим список доступных геометрический фигур.
                    Console.WriteLine("Evailable shapes:");
                    foreach (var shape in shapeManager.RegisteredShapes)
                        Console.WriteLine($"\t{shape}");
                    Console.WriteLine(".");
                }
                else if (args.Length < 2)
                {
                    // Выводим формат инициализирующей строки.
                    var helpString = shapeManager.CreateShape(args[0]).Description;
                    Console.WriteLine($"Initialise string format: {helpString}");
                }
                else
                {
                    // Выводим подсчитанную площадь фигуры.
                    var area = shapeManager.CreateShape(args[0], args[1]).CalculateArea();
                    Console.WriteLine($"Initialise string format: {area:N}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static ShapeManager CreateShapeManager()
        {
            var shapeManager = new ShapeManager();

            var shapes = (NameValueCollection) ConfigurationManager.GetSection("shapes");
            foreach (var shape in shapes.AllKeys)
                shapeManager.RegisterShape(shape, shapes[shape]);

            return shapeManager;
        }

    }
}
