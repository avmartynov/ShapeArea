using NUnit.Framework;
using System;

namespace Tech.ShapeArea.Tests
{
    /// <summary>
    /// Тесты-наследники по разному инициализируют ShapeManager
    /// </summary>
    public abstract class AreaBase_TestFixture
    {
        [Test]
        public void _10_Basic_Test()
        {
            var areaOfShape = _shapeManager.CreateShape("Circle", "2.0").CalculateArea();

            AssertThatEqual(areaOfShape, Math.PI * 2.0 * 2.0);
        }

        [Test]
        public void _20_WrongParameterType_Test()
        {
            Assert.Throws<ArgumentException>(() => _shapeManager.CreateShape("Circle", "-5.7"));
        }


        [Test]
        public void _30_WrongParameterType_Test()
        {
            Assert.Throws<ArgumentException>(() => _shapeManager.CreateShape("Circle", "a"));
        }


        [Test]
        public void _40_Basic_Test()
        {
            var areaOfShape = _shapeManager.CreateShape("Triangle", "3.0, 4.0, 5.0").CalculateArea();

            AssertThatEqual(areaOfShape, 6.0);
        }


        [Test]
        public void _42_Basic_Test()
        {
            var areaOfShape = _shapeManager.CreateShape("Triangle", "0.0, 4.0, 5.0").CalculateArea();

            AssertThatEqual(areaOfShape, 0.0);
        }

        [Test]
        public void _43_Basic_Test()
        {
            Assert.Throws<ArgumentException>(() => _shapeManager.CreateShape("Triangle", "2.0, -4.0, 5.0"));
        }

        [Test]
        public void _50_Basic_Test()
        {
            var areaOfShape = _shapeManager.CreateShape("Point").CalculateArea();

            AssertThatEqual(areaOfShape, 0.0);
        }

        private void AssertThatEqual(double actual, double expected)
        {
            Assert.That(Math.Abs(expected - actual), Is.LessThan(double.Epsilon));
        }

        protected readonly ShapeManager _shapeManager = new ShapeManager();
    }
}
