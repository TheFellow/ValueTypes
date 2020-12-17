using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Names
{
    public class Rollcall : Value
    {
        public IEnumerable<Seat> Seats { get; }
        public Rollcall(IEnumerable<Seat> seats) => Seats = seats;

        protected override IEnumerable<ValueBase> GetValues() => Yield(Seats.AsValues());
    }
}
