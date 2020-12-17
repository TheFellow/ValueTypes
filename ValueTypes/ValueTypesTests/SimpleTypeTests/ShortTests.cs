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

    [TestClass]
    public class ShortGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (short)4, (short)8 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (short)16, (short)15 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (short)15, (short)16 }.AsGroup();
    }
}
