using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests
{
    [TestClass]
    public abstract class AbstractValueTypeTests<T>
    {
        protected abstract ValueBase GetSampleValue1();
        protected abstract ValueBase GetSampleValue2();
        protected abstract ValueBase GetOtherValue();


        [TestMethod]
        public void Value_EqualsNull_IsFalse()
        {
            var value = GetSampleValue1();

            Assert.IsFalse(value.Equals(null));
            Assert.IsFalse(value == null);
            Assert.IsFalse(null == value);
            Assert.IsTrue(value != null);
            Assert.IsTrue(null != value);
        }

        [TestMethod]
        public void Equals_SameInstance_IsTrue()
        {
            var value = GetSampleValue1();

            Assert.IsTrue(value.Equals(value));
#pragma warning disable CS1718 // Comparison made to same variable
            Assert.IsTrue(value == value);
            Assert.IsFalse(value != value);
#pragma warning restore CS1718 // Comparison made to same variable
        }
    }
}
