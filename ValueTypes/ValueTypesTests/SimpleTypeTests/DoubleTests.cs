using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DoubleTests : AbstractValueTypeTests<double>
    {
        protected override double GetOtherValue() => (double)3.14;
        protected override double GetSampleValue1() => (double)2.718;
        protected override double GetSampleValue2() => (double)2.718;
    }
}
