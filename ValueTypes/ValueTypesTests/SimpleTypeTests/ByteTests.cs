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

    [TestClass]
    public class ByteSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new byte[] { 0b_0010, 0b_1010 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new byte[] { 0b_0010, 0b_1110 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new byte[] { 0b_0010, 0b_1110 }.AsValues();
    }
}
