using System;
using System.Diagnostics.CodeAnalysis;

namespace ValueTypes
{
    public abstract class ValueBase : IEquatable<ValueBase>
    {
        public abstract bool Equals([AllowNull] ValueBase other);
        public override bool Equals(object? obj) => this.Equals(obj as ValueBase);
        public abstract override int GetHashCode();

        public static bool operator ==(ValueBase a, ValueBase b) => a.Equals(b);
        public static bool operator !=(ValueBase a, ValueBase b) => !(a == b);
    }
}
