using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class UIntTests : AbstractValueTypeTests<uint>
    {
        protected override ValueBase GetOtherValue() => (uint)4;
        protected override ValueBase GetSampleValue1() => (uint)5;
        protected override ValueBase GetSampleValue2() => (uint)5;
    }
}
