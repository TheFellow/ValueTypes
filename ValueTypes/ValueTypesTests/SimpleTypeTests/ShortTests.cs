using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ShortTests : AbstractValueTypeTests<short>
    {
        protected override short GetOtherValue() => (short)88;
        protected override short GetSampleValue1() => (short)99;
        protected override short GetSampleValue2() => (short)99;
    }
}
