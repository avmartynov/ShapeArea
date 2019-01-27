using NUnit.Framework;
using Tech.ShapeArea.Shapes;

namespace Tech.ShapeArea.Tests
{
    public class AreaStrongCoupled_TestFixture : AreaBase_TestFixture
    {
        [OneTimeSetUp]
        public void Init()
        {
            _shapeManager.RegisterShape(nameof(Circle),   typeof(Circle));
            _shapeManager.RegisterShape(nameof(Triangle), typeof(Triangle));
            _shapeManager.RegisterShape(nameof(Point),    typeof(Point));
        }
    }
}
