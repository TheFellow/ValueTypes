using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests
{
    public class EquatableInt : IEquatable<EquatableInt>
    {
        private readonly int _value;
        public EquatableInt(int value) => _value = value;

        public bool Equals(EquatableInt? other) => other is not null && _value.Equals(other._value);
        public override bool Equals(object? obj) => obj is EquatableInt equatableInt && Equals(equatableInt);
        public override int GetHashCode() => _value.GetHashCode();
    }

    [TestClass]
    public class EquatableTypeTests : AbstractValueTypeTests<EquatableInt>
    {
        protected override ValueBase GetOtherValue() => new EquatableInt(5).AsValue();
        protected override ValueBase GetSampleValue1() => new EquatableInt(4).AsValue();
        protected override ValueBase GetSampleValue2() => new EquatableInt(4).AsValue();
    }

    [TestClass]
    public class ColorTests : AbstractValueTypeTests<Color>
    {
        protected override ValueBase GetOtherValue() => Color.Red.AsValue();
        protected override ValueBase GetSampleValue1() => Color.Blue.AsValue();
        protected override ValueBase GetSampleValue2() => Color.Blue.AsValue();
    }
}
