using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class DoubleTests : AbstractValueTypeTests<double>
    {
        protected override ValueBase GetOtherValue() => (double)3.14;
        protected override ValueBase GetSampleValue1() => (double)2.718;
        protected override ValueBase GetSampleValue2() => (double)2.718;
    }
}
