using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public class BadPoint3d : Point2d
    {
        public int Z { get; }

        public BadPoint3d(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }

        protected override IEnumerable<ValueBase> GetValues()
        {
            foreach (var value in base.GetValues())
                yield return value;

            yield return Z;
        }
    }
}
