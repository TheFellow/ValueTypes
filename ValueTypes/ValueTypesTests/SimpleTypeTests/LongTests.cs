using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class LongTests : AbstractValueTypeTests<long>
    {
        protected override ValueBase GetOtherValue() => (long)123;
        protected override ValueBase GetSampleValue1() => (long)456;
        protected override ValueBase GetSampleValue2() => (long)456;
    }
}
