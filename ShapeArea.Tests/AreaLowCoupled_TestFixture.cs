using NUnit.Framework;

namespace Tech.ShapeArea.Tests
{
    public class AreaLowCoupled_TestFixture : AreaBase_TestFixture
    {
        [OneTimeSetUp]
        public void Init()
        {
            _shapeManager.RegisterShape("Point",     "Tech.ShapeArea.Shapes.Point,     Tech.ShapeArea.Shapes");
            _shapeManager.RegisterShape("Circle",    "Tech.ShapeArea.Shapes.Circle,    Tech.ShapeArea.Shapes");
            _shapeManager.RegisterShape("Rectangle", "Tech.ShapeArea.Shapes.Rectangle, Tech.ShapeArea.Shapes");
            _shapeManager.RegisterShape("Triangle",  "Tech.ShapeArea.Shapes.Triangle,  Tech.ShapeArea.Shapes");
        }
    }
}
