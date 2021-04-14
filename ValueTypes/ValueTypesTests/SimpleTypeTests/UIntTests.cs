using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class UIntTests : AbstractValueTypeTests<uint>
    {
        protected override ValueBase GetOtherValue() => (uint)4;
        protected override ValueBase GetSampleValue1() => (uint)5;
        protected override ValueBase GetSampleValue2() => (uint)5;
    }

    [TestClass]
    public class UIntSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (uint)4, (uint)8 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (uint)15, (uint)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (uint)15, (uint)16 }.AsValues();
    }

    [TestClass]
    public class UIntGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (uint)4, (uint)8 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (uint)16, (uint)15 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (uint)15, (uint)16 }.AsGroup();
    }
}
