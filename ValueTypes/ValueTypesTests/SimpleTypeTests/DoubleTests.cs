using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DoubleTests : AbstractValueTypeTests<double>
    {
        protected override ValueBase GetOtherValue() => (double)3.14;
        protected override ValueBase GetSampleValue1() => (double)2.718;
        protected override ValueBase GetSampleValue2() => (double)2.718;
    }

    [TestClass]
    public class DoubleSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { 3.14, 2.718 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { 15.16, 23.42 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { 15.16, 23.42 }.AsValues();
    }

    [TestClass]
    public class DoubleGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { 3.14, 2.718 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { 23.42, 15.16 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { 15.16, 23.42 }.AsGroup();
    }
}
