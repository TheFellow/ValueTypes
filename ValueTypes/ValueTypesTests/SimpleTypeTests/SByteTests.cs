using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class SByteTests : AbstractValueTypeTests<sbyte>
    {
        protected override sbyte GetOtherValue() => (sbyte)4;
        protected override sbyte GetSampleValue1() => (sbyte)5;
        protected override sbyte GetSampleValue2() => (sbyte)5;
    }
}
