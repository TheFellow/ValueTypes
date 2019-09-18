using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests
{
    [TestClass]
    public abstract class AbstractValueTypeTests<T>
    {
        protected abstract T GetSampleValue1();
        protected abstract T GetSampleValue2();
        protected abstract T GetOtherValue();


        [TestMethod]
        public void Value_EqualsNull_IsFalse()
        {
            T value = GetSampleValue1();

            Assert.IsFalse(value.Equals(null));
            Assert.IsFalse(value == null);
            Assert.IsFalse(null == value);
            Assert.IsTrue(value != null);
            Assert.IsTrue(null != value);
        }
    }
}
