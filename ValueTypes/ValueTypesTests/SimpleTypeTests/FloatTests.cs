using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class FloatTests : AbstractValueTypeTests<float>
    {
        protected override ValueBase GetOtherValue() => (float)3.141;
        protected override ValueBase GetSampleValue1() => (float)2.718;
        protected override ValueBase GetSampleValue2() => (float)2.718;
    }
}
