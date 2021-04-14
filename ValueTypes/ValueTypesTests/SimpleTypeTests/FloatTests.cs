using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class FloatTests : AbstractValueTypeTests<float>
    {
        protected override ValueBase GetOtherValue() => (float)3.141;
        protected override ValueBase GetSampleValue1() => (float)2.718;
        protected override ValueBase GetSampleValue2() => (float)2.718;
    }

    [TestClass]
    public class FloatSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (float)3.14, (float)2.718 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (float)15.16, (float)23.42 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (float)15.16, (float)23.42 }.AsValues();
    }

    [TestClass]
    public class FloatGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[] { (float)3.14, (float)2.718 }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[] { (float)23.42, (float)15.16 }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[] { (float)15.16, (float)23.42 }.AsGroup();
    }
}
