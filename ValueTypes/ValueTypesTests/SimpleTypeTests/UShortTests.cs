using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class UShortTests : AbstractValueTypeTests<ushort>
    {
        protected override ValueBase GetOtherValue() => (ushort)88;
        protected override ValueBase GetSampleValue1() => (ushort)99;
        protected override ValueBase GetSampleValue2() => (ushort)99;
    }
}
