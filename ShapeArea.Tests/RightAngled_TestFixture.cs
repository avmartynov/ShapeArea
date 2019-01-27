using NUnit.Framework;
using Tech.ShapeArea.Shapes;

namespace Tech.ShapeArea.Tests
{
    public class RightAngled_TestFixture
    {
        [Test]
        public void _61_RightAngled_Test()
        {
            var triangle = (Triangle) _shapeManager.CreateShape("Triangle", "3.0, 4.0, 5.0");

            var isTriangleRightAngled = triangle.IsRightAngled();

            Assert.That(isTriangleRightAngled, Is.True);
        }

        [Test]
        public void _62_RightAngled_Test()
        {
            var triangle = (Triangle)_shapeManager.CreateShape("Triangle", "4.0, 3.0, 5.0");

            var isTriangleRightAngled = triangle.IsRightAngled();

            Assert.That(isTriangleRightAngled, Is.True);
        }

        [Test]
        public void _63_RightAngled_Test()
        {
            var triangle = (Triangle)_shapeManager.CreateShape("Triangle", "5.0, 3.0, 4.0");

            var isTriangleRightAngled = triangle.IsRightAngled();

            Assert.That(isTriangleRightAngled, Is.True);
        }

        [Test]
        public void _64_RightAngled_Test()
        {
            var triangle = (Triangle)_shapeManager.CreateShape("Triangle", "3.0, 3.0, 3.0");

            var isTriangleRightAngled = triangle.IsRightAngled();

            Assert.That(isTriangleRightAngled, Is.False);
        }

        [OneTimeSetUp]
        public void Init()
        {
            _shapeManager.RegisterShape("Triangle", typeof(Triangle));
        }


        private readonly ShapeManager _shapeManager = new ShapeManager();
    }
}
