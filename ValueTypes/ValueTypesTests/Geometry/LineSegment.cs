using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public class LineSegment : Value
    {
        public Point2d A { get; }
        public Point2d B { get; }

        public LineSegment(Point2d a, Point2d b)
        {
            A = a;
            B = b;
        }

        protected override IEnumerable<ValueBase> GetValues() => Group(A, B);
    }
}
