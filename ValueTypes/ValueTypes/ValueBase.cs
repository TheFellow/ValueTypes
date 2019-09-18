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

    public sealed class Value<T> : ValueBase
        where T : struct
    {
        public T Content { get; }
        public Value(T content) => this.Content = content;


        public override bool Equals([AllowNull] ValueBase other)
        {
            if (other is null) return false;
            if (other is Value<T> value) return this.Content.Equals(value.Content);
            return false;
        }

        public override int GetHashCode() => Content.GetHashCode();
        public override string ToString() => $"Value({Content})";
    }
}
