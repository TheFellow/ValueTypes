using System;

namespace ValueTypes
{
    public static class IEquatableExtensions
    {
        public static ValueBase AsValue<T>(this IEquatable<T> value) where T : IEquatable<T>
            => new ValueEquatable<T>(value);
    }
}
