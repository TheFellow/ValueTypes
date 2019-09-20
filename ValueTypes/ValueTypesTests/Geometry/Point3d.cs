using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public sealed class Point3d : Value
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point3d(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(X, Y, Z);
    }
}
