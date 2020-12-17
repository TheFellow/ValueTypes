using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using ValueTypes;

namespace ValueTypesTests
{
    [TestClass]
    public abstract class AbstractEnumerableValueTypeTests
    {
        protected abstract ValueSequence GetSampleSequence1();
        protected abstract ValueSequence GetSampleSequence2();
        protected abstract ValueSequence GetOtherSequence();

        private static readonly IEqualityComparer<ValueSequence> _comparer = EqualityComparer<ValueSequence>.Default;

        [TestMethod]
        public void AsValues_EqualsNull_IsFalse()
        {
            var value = GetSampleSequence1();

            Assert.IsFalse(_comparer.Equals(value, null));
            Assert.IsFalse(value!.Equals(null));
            Assert.IsFalse(value! == null!);
            Assert.IsFalse(null! == value!);
            Assert.IsTrue(value! != null!);
            Assert.IsTrue(null! != value!);
        }

        [TestMethod]
        public void AsValues_SameInstance_IsTrue()
        {
            var value = GetSampleSequence1();

            Assert.IsTrue(_comparer.Equals(value, value));
            Assert.IsTrue(value.Equals(value));
#pragma warning disable CS1718 // Comparison made to same variable
            Assert.IsTrue(value == value);
            Assert.IsFalse(value != value);
#pragma warning restore CS1718 // Comparison made to same variable
        }

        [TestMethod]
        public void AsValues_EquivalentInstance_IsTrue()
        {
            var value1 = GetSampleSequence1();
            var value2 = GetSampleSequence2();

            Assert.IsTrue(_comparer.Equals(value1, value2));
            Assert.IsTrue(value1.Equals(value2));
            Assert.IsTrue(value1 == value2);
            Assert.IsTrue(value2 == value1);
            Assert.IsFalse(value1 != value2);
            Assert.IsFalse(value2 != value1);
        }

        [TestMethod]
        public void AsValues_DifferentInstance_IsFalse()
        {
            var value1 = GetSampleSequence1();
            var value2 = GetOtherSequence();

            Assert.IsFalse(_comparer.Equals(value1, value2));
            Assert.IsFalse(value1.Equals(value2));
            Assert.IsFalse(value2.Equals(value1));
            Assert.IsFalse(value1 == value2);
            Assert.IsFalse(value2 == value1);
            Assert.IsTrue(value1 != value2);
            Assert.IsTrue(value2 != value1);
        }

        [TestMethod]
        public void GetHashCode_ForEquivalentInstances_AreEqual()
        {
            var value1 = GetSampleSequence1();
            var value2 = GetSampleSequence2();

            Assert.AreEqual(value1.GetHashCode(), value2.GetHashCode());
        }
    }
}
