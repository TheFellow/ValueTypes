﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;

namespace ValueTypesTests.SimpleTypeTests
{
    [TestClass]
    public class StringTests : AbstractValueTypeTests<string>
    {
        protected override ValueBase GetOtherValue() => "Hello World";
        protected override ValueBase GetSampleValue1() => "Hello Mars";
        protected override ValueBase GetSampleValue2() => "Hello Mars";
    }

    [TestClass]
    public class NullableStringTests
    {
        [TestMethod]
        public void NullValueString_EqualsNullValueString_IsTrue()
        {
            ValueBase value1 = (string)null!;
            ValueBase value2 = (string)null!;

            Assert.AreEqual(value1, value2);
        }
    }

    [TestClass]
    public class StringSequenceTests : AbstractEnumerableValueTypeTests
    {
        protected override ValueSequence GetOtherSequence() => new[] { "Hello", "World" }.AsValues();
        protected override ValueSequence GetSampleSequence1() => new[] { "Hola", "Amigo" }.AsValues();
        protected override ValueSequence GetSampleSequence2() => new[] { "Hola", "Amigo" }.AsValues();
    }
}
