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

    [TestClass]
    public class UShortSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (ushort)4, (ushort)8 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (ushort)15, (ushort)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (ushort)15, (ushort)16 }.AsValues();
    }

    [TestClass]
    public class UShortGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (ushort)4, (ushort)8 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (ushort)16, (ushort)15 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (ushort)15, (ushort)16 }.AsGroup();
    }
}
