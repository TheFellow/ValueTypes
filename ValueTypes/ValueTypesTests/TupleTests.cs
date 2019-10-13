using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypesTests.Geometry;

namespace ValueTypesTests
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void Tuple_OfEquivalentValues_AreEqual()
        {
            var t1 = (4, 8, new Point2d(4, 8));
            var t2 = (4, 8, new Point2d(4, 8));

            Assert.AreEqual(t1, t2);
            Assert.IsTrue(t1.Equals(t2));
            Assert.IsTrue(t1 == t2);
            Assert.IsTrue(t2 == t1);
            Assert.IsFalse(t1 != t2);
            Assert.IsFalse(t2 != t1);
        }

        [TestMethod]
        public void Tuple_OfNonEquivalentValues_AreEqual()
        {
            var t1 = (4, new Point2d(4, 8), 8);
            var t2 = (4, 8, new Point2d(4, 8));

            Assert.AreNotEqual(t1, t2);
            Assert.IsFalse(t1.Equals(t2));
            Assert.IsFalse(t1 == t2);
            Assert.IsFalse(t2 == t1);
            Assert.IsTrue(t1 != t2);
            Assert.IsTrue(t2 != t1);
        }

        [TestMethod]
        public void VectorsAsTuple_OfEquivalentValues_AreEqual()
        {
            var t1 = (new Point2d(4, 8), new Point2d(15, 16));
            var t2 = (new Point2d(4, 8), new Point2d(15, 16));

            Assert.AreEqual(t1, t2);
            Assert.IsTrue(t1.Equals(t2));
            Assert.IsTrue(t1 == t2);
            Assert.IsTrue(t2 == t1);
            Assert.IsFalse(t1 != t2);
            Assert.IsFalse(t2 != t1);
        }

        [TestMethod]
        public void VectorsAsTuple_OfNonEquivalentValues_AreEqual()
        {
            var t1 = (new Point2d(15, 16), new Point2d(4, 8));
            var t2 = (new Point2d(4, 8), new Point2d(15, 16));

            Assert.AreNotEqual(t1, t2);
            Assert.IsFalse(t1.Equals(t2));
            Assert.IsFalse(t1 == t2);
            Assert.IsFalse(t2 == t1);
            Assert.IsTrue(t1 != t2);
            Assert.IsTrue(t2 != t1);
        }
    }
}
