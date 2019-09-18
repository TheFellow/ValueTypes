using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class LongTests : AbstractValueTypeTests<long>
    {
        protected override long GetOtherValue() => (long)123;
        protected override long GetSampleValue1() => (long)456;
        protected override long GetSampleValue2() => (long)456;
    }
}
