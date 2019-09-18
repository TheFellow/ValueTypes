using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DecimalTests : AbstractValueTypeTests<decimal>
    {
        protected override decimal GetOtherValue() => (decimal)3.141m;
        protected override decimal GetSampleValue1() => (decimal)2.718m;
        protected override decimal GetSampleValue2() => (decimal)2.718m;
    }
}
