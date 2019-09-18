using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class BoolTests : AbstractValueTypeTests<bool>
    {
        protected override bool GetOtherValue() => true;
        protected override bool GetSampleValue1() => false;
        protected override bool GetSampleValue2() => false;
    }
}
