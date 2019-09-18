﻿using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Geometry
{
    public sealed class DirectedLineSegment : Value
    {
        public Point2d From { get; }
        public Point2d To { get; }

        public DirectedLineSegment(Point2d from, Point2d to)
        {
            this.From = from;
            this.To = to;
        }

        protected override IEnumerable<ValueBase> GetValues()
        {
            yield return From;
            yield return To;
        }
    }
}
