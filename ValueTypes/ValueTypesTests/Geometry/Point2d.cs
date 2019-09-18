using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public class Point2d : Value  // Deliberately unsealed (bad)
    {
        public int X { get; }
        public int Y { get; }

        public Point2d(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        protected override IEnumerable<ValueBase> GetValues()
        {
            yield return X;
            yield return Y;
        }
    }
}
