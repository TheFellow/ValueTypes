using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class IntTests : AbstractValueTypeTests<int>
    {
        protected override int GetOtherValue() => (int)4;
        protected override int GetSampleValue1() => (int)5;
        protected override int GetSampleValue2() => (int)5;
    }
}
