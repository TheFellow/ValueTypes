using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class ULongTests : AbstractValueTypeTests<ulong>
    {
        protected override ValueBase GetOtherValue() => (ulong)789;
        protected override ValueBase GetSampleValue1() => (ulong)654;
        protected override ValueBase GetSampleValue2() => (ulong)654;
    }

    [TestClass]
    public class ULongSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (long)4, (long)8 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (long)15, (long)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (long)15, (long)16 }.AsValues();
    }

    [TestClass]
    public class ULongGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (long)4, (long)8 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (long)16, (long)15 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (long)15, (long)16 }.AsGroup();
    }
}
