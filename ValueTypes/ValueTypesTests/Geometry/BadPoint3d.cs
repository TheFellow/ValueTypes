using System.Collections.Generic;
using System.Linq;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public class BadPoint3d : Point2d
    {
        public int Z { get; }

        public BadPoint3d(int x, int y, int z) : base(x, y) => this.Z = z;

        protected override IEnumerable<ValueBase> GetValues() => base.GetValues().Concat(new ValueBase[] { Z });
    }
}
