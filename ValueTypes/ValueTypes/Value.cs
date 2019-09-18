using System.Diagnostics.CodeAnalysis;

namespace ValueTypes
{
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
