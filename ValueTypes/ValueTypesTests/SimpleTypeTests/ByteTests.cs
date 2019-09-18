using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ByteTests : AbstractValueTypeTests<byte>
    {
        protected override ValueBase GetOtherValue() => (byte)4;
        protected override ValueBase GetSampleValue1() => (byte)5;
        protected override ValueBase GetSampleValue2() => (byte)5;
    }
}
