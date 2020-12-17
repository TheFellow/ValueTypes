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
}
