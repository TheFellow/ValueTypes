using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class BoolTests : AbstractValueTypeTests<bool>
    {
        protected override ValueBase GetOtherValue() => true;
        protected override ValueBase GetSampleValue1() => false;
        protected override ValueBase GetSampleValue2() => false;
    }

    [TestClass]
    public class BoolSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { true, false }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { true, true }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { true, true }.AsValues();
    }

    [TestClass]
    public class BoolGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { true }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { true, false }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { false, true }.AsGroup();
    }
}
