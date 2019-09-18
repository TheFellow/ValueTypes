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
}
