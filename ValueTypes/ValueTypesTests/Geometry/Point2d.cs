using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Geometry
{
    public class Point2d : Value  // Deliberately unsealed (bad)
    {
        public int X { get; }
        public int Y { get; }

        public Point2d(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(X, Y);
    }
}
