using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ULongTests : AbstractValueTypeTests<ulong>
    {
        protected override ulong GetOtherValue() => (ulong)789;
        protected override ulong GetSampleValue1() => (ulong)654;
        protected override ulong GetSampleValue2() => (ulong)654;
    }
}
