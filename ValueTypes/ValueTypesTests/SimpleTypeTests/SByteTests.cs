using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class SByteTests : AbstractValueTypeTests<sbyte>
    {
        protected override ValueBase GetOtherValue() => (sbyte)4;
        protected override ValueBase GetSampleValue1() => (sbyte)5;
        protected override ValueBase GetSampleValue2() => (sbyte)5;
    }

    [TestClass]
    public class SByteSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (sbyte)4, (sbyte)8 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (sbyte)15, (sbyte)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (sbyte)15, (sbyte)16 }.AsValues();
    }

    [TestClass]
    public class SByteGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (sbyte)4, (sbyte)8 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (sbyte)16, (sbyte)15 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (sbyte)15, (sbyte)16 }.AsGroup();
    }
}
