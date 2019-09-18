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
}
