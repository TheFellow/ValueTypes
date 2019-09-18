using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypesTests.Geometry;

namespace ValueTypesTests
{
    [TestClass]
    public class Point2dTests : AbstractValueTypeTests<Point2d>
    {
        protected override ValueBase GetOtherValue() => new Point2d(4, 8);
        protected override ValueBase GetSampleValue1() => new Point2d(4, 15);
        protected override ValueBase GetSampleValue2() => new Point2d(4, 15);
    }

    [TestClass]
    public class Point3dTests : AbstractValueTypeTests<Point3d>
    {
        protected override ValueBase GetOtherValue() => new Point3d(4, 8, 15);
        protected override ValueBase GetSampleValue1() => new Point3d(4, 15, 16);
        protected override ValueBase GetSampleValue2() => new Point3d(4, 15, 16);
    }

    [TestClass]
    public class DirectedLineSegmentTests : AbstractValueTypeTests<DirectedLineSegment>
    {
        protected override ValueBase GetOtherValue() => new DirectedLineSegment(new Point2d(4, 8), new Point2d(15, 16));
        protected override ValueBase GetSampleValue1() => new DirectedLineSegment(new Point2d(4, 8), new Point2d(23, 42));
        protected override ValueBase GetSampleValue2() => new DirectedLineSegment(new Point2d(4, 8), new Point2d(23, 42));
    }

    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Point3dAndBadPoint3d_WithSameValues_AreNotEqual()
        {
            var value1 = new Point3d(4, 8, 15);
            var value2 = new BadPoint3d(4, 8, 15);

            Assert.IsFalse(value1.Equals(value2));
            Assert.IsFalse(value2.Equals(value1));
            Assert.IsFalse(value1 == value2);
            Assert.IsFalse(value2 == value1);
            Assert.IsTrue(value1 != value2);
            Assert.IsTrue(value2 != value1);
        }
    }
}
