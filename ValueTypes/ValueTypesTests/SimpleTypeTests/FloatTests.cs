using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class FloatTests : AbstractValueTypeTests<float>
    {
        protected override float GetOtherValue() => (float)3.141;
        protected override float GetSampleValue1() => (float)2.718;
        protected override float GetSampleValue2() => (float)2.718;
    }
}
