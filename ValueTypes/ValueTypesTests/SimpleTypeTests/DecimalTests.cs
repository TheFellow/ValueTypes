using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DecimalTests : AbstractValueTypeTests<decimal>
    {
        protected override ValueBase GetOtherValue() => (decimal)3.141m;
        protected override ValueBase GetSampleValue1() => (decimal)2.718m;
        protected override ValueBase GetSampleValue2() => (decimal)2.718m;
    }
}
