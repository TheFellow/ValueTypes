using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class UIntTests : AbstractValueTypeTests<uint>
    {
        protected override uint GetOtherValue() => (uint)4;
        protected override uint GetSampleValue1() => (uint)5;
        protected override uint GetSampleValue2() => (uint)5;
    }
}
