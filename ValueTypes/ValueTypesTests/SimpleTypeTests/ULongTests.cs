using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ULongTests : AbstractValueTypeTests<ulong>
    {
        protected override ValueBase GetOtherValue() => (ulong)789;
        protected override ValueBase GetSampleValue1() => (ulong)654;
        protected override ValueBase GetSampleValue2() => (ulong)654;
    }
}
