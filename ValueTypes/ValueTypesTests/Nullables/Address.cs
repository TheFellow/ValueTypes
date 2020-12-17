using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Nullables
{
    public class Address : Value
    {
        public string Street1 { get; }
        public string? Street2 { get; }
        public string City { get; }

        public Address(string street1, string? street2, string city)
        {
            Street1 = street1;
            Street2 = street2;
            City = city;
        }
        public override string ToString() => $"{Street1} {Street2}, {City}";
        protected override IEnumerable<ValueBase> GetValues() => Yield(Street1, Street2, City);
    }
}
