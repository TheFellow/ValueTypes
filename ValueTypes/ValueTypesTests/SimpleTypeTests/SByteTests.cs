using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class SByteTests : AbstractValueTypeTests<sbyte>
    {
        protected override ValueBase GetOtherValue() => (sbyte)4;
        protected override ValueBase GetSampleValue1() => (sbyte)5;
        protected override ValueBase GetSampleValue2() => (sbyte)5;
    }
}
