using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class CharTests : AbstractValueTypeTests<char>
    {
        protected override char GetOtherValue() => (char)'a';
        protected override char GetSampleValue1() => (char)'A';
        protected override char GetSampleValue2() => (char)'A';
    }
}
