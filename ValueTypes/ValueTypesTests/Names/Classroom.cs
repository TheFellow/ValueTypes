using System.Collections.Generic;
using System.Linq;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Names
{
    public class Classroom : Value
    {
        private readonly Seat[] _seats;

        public Classroom(IEnumerable<Seat> seats) => _seats = seats.ToArray();

        protected override IEnumerable<ValueBase> GetValues() => Group(_seats);
    }
}
