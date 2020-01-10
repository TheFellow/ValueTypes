using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class GuidTests : AbstractValueTypeTests<Guid>
    {
        protected override ValueBase GetOtherValue() => new Guid("{9BC8C864-E196-4162-8C60-D0AE98D2B781}");
        protected override ValueBase GetSampleValue1() => new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}");
        protected override ValueBase GetSampleValue2() => new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}");
    }
}
