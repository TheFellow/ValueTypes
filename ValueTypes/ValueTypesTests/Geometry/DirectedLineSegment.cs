using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public sealed class DirectedLineSegment : Value
    {
        public Point2d From { get; }
        public Point2d To { get; }

        public DirectedLineSegment(Point2d from, Point2d to)
        {
            From = from;
            To = to;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(From, To);
    }
}
