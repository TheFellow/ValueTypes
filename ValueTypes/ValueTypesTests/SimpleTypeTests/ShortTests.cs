using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ShortTests : AbstractValueTypeTests<short>
    {
        protected override ValueBase GetOtherValue() => (short)88;
        protected override ValueBase GetSampleValue1() => (short)99;
        protected override ValueBase GetSampleValue2() => (short)99;
    }
}
