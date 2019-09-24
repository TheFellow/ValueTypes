using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests
{
    [TestClass]
    public abstract class AbstractValueTypeTests<T>
    {
        protected abstract ValueBase GetSampleValue1();
        protected abstract ValueBase GetSampleValue2();
        protected abstract ValueBase GetOtherValue();

        private static IEqualityComparer<ValueBase> _comparer = EqualityComparer<ValueBase>.Default;

        [TestMethod]
        public void Value_EqualsNull_IsFalse()
        {
            var value = GetSampleValue1();

            Assert.IsFalse(_comparer.Equals(value, null));
            Assert.IsFalse(value!.Equals(null));
            Assert.IsFalse(value! == null!);
            Assert.IsFalse(null! == value!);
            Assert.IsTrue(value! != null!);
            Assert.IsTrue(null! != value!);
        }

        [TestMethod]
        public void Equals_SameInstance_IsTrue()
        {
            var value = GetSampleValue1();

            Assert.IsTrue(_comparer.Equals(value, value));
            Assert.IsTrue(value.Equals(value));
#pragma warning disable CS1718 // Comparison made to same variable
            Assert.IsTrue(value == value);
            Assert.IsFalse(value != value);
#pragma warning restore CS1718 // Comparison made to same variable
        }

        [TestMethod]
        public void Equals_EquivalentInstance_IsTrue()
        {
            var value1 = GetSampleValue1();
            var value2 = GetSampleValue2();

            Assert.IsTrue(_comparer.Equals(value1, value2));
            Assert.IsTrue(value1.Equals(value2));
            Assert.IsTrue(value1 == value2);
            Assert.IsTrue(value2 == value1);
            Assert.IsFalse(value1 != value2);
            Assert.IsFalse(value2 != value1);
        }

        [TestMethod]
        public void Equals_DifferentInstance_IsFalse()
        {
            var value1 = GetSampleValue1();
            var value2 = GetOtherValue();

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
            var value1 = GetSampleValue1();
            var value2 = GetSampleValue2();

            Assert.AreEqual(value1.GetHashCode(), value2.GetHashCode());
        }
    }
}
