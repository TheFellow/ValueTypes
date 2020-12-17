using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class CharTests : AbstractValueTypeTests<char>
    {
        protected override ValueBase GetOtherValue() => (char)'a';
        protected override ValueBase GetSampleValue1() => (char)'A';
        protected override ValueBase GetSampleValue2() => (char)'A';
    }

    [TestClass]
    public class CharSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { 'a', 'b', 'c' }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { 'a', 'B', 'c' }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { 'a', 'B', 'c' }.AsValues();
    }
}
