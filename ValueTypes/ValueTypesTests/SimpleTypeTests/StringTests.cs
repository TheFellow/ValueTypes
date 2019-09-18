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
}
