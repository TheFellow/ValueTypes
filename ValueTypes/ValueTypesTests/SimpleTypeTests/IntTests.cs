using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class IntTests : AbstractValueTypeTests<int>
    {
        protected override ValueBase GetOtherValue() => (int)4;
        protected override ValueBase GetSampleValue1() => (int)5;
        protected override ValueBase GetSampleValue2() => (int)5;
    }
}
