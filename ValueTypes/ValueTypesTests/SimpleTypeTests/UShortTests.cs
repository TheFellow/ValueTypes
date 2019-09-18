using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class UShortTests : AbstractValueTypeTests<ushort>
    {
        protected override ushort GetOtherValue() => (ushort)88;
        protected override ushort GetSampleValue1() => (ushort)99;
        protected override ushort GetSampleValue2() => (ushort)99;
    }
}
