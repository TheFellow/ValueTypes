using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DecimalTests : AbstractValueTypeTests<decimal>
    {
        protected override ValueBase GetOtherValue() => 3.141m;
        protected override ValueBase GetSampleValue1() => 2.718m;
        protected override ValueBase GetSampleValue2() => 2.718m;
    }

    [TestClass]
    public class DecimalSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { 4m, 8m }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { 15m, 16.2m }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { 15m, 16.2m }.AsValues();
    }

    [TestClass]
    public class DecimalGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { 4m, 8m }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { 15m, 16.2m }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { 16.2m, 15m }.AsGroup();
    }
}
