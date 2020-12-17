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

    [TestClass]
    public class ShortSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (short)4, (short)8 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (short)15, (short)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (short)15, (short)16 }.AsValues();
    }
}
