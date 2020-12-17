using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Names
{
    public class Seat : Value
    {
        public PersonalName Name { get; }
        public int SeatNumber { get; }

        public Seat(PersonalName name, int seatNumber)
        {
            Name = name;
            SeatNumber = seatNumber;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(Name, SeatNumber);
    }
}
