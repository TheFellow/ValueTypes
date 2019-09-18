using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ByteTests : AbstractValueTypeTests<byte>
    {
        protected override byte GetOtherValue() => (byte)4;
        protected override byte GetSampleValue1() => (byte)5;
        protected override byte GetSampleValue2() => (byte)5;
    }
}
