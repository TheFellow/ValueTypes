using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class GuidTests : AbstractValueTypeTests<Guid>
    {
        protected override ValueBase GetOtherValue() => new Guid("{9BC8C864-E196-4162-8C60-D0AE98D2B781}");
        protected override ValueBase GetSampleValue1() => new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}");
        protected override ValueBase GetSampleValue2() => new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}");
    }

    [TestClass]
    public class GuidSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[]
        {
            new Guid("{9BC8C864-E196-4162-8C60-D0AE98D2B781}"),
            new Guid("{0BC8C064-E196-4162-8C60-D0AE98D2B781}")
        }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[]
        {
            new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}"),
            new Guid("{1B6642DF-7E87-46B5-AA67-699941479ACF}")
        }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[]
        {
            new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}"),
            new Guid("{1B6642DF-7E87-46B5-AA67-699941479ACF}")
        }.AsValues();
    }

    [TestClass]
    public class GuidGroupTests : AbstractGroupTypeTests
    {
        protected override ValueGroup GetOtherGroup() => new[]
        {
            new Guid("{9BC8C864-E196-4162-8C60-D0AE98D2B781}"),
            new Guid("{9BC8C064-E196-4162-8C60-D0AE98D2B781}")
        }.AsGroup();
        protected override ValueGroup GetSampleGroup() => new[]
        {
            new Guid("{1B6642DF-7E87-46B5-AA67-699941479ACF}"),
            new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}")
        }.AsGroup();
        protected override ValueGroup GetEquivalentGroup() => new[]
        {
            new Guid("{0B6642DF-7E87-46B5-AA67-699941479ACF}"),
            new Guid("{1B6642DF-7E87-46B5-AA67-699941479ACF}")
        }.AsGroup();
    }
}
