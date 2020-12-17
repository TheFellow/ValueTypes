﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class IntTests : AbstractValueTypeTests<int>
    {
        protected override ValueBase GetOtherValue() => (int)4;
        protected override ValueBase GetSampleValue1() => (int)5;
        protected override ValueBase GetSampleValue2() => (int)5;
    }

    [TestClass]
    public class IntSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { 4, 8, 15 }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { 16, 23, 42 }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { 16, 23, 42 }.AsValues();
    }
}
