using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class StringTests : AbstractValueTypeTests<string>
    {
        protected override ValueBase GetOtherValue() => "Hello World";
        protected override ValueBase GetSampleValue1() => "Hello Mars";
        protected override ValueBase GetSampleValue2() => "Hello Mars";
    }

    [TestClass]
    public class StringSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { "Hello", "World" }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { "Hola", "Amigo" }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { "Hola", "Amigo" }.AsValues();
    }
}
