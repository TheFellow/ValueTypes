﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    [TestClass]
    public class LongSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { (long)123, (long)456 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { (long)15, (long)16 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { (long)15, (long)16 }.AsValues();
    }
}
