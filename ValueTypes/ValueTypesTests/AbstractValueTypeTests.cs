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
        public void Equals_Null_IsFalse()
        {
            Assert.Inconclusive();
        }
    }
}
