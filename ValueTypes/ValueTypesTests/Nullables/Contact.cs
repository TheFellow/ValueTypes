using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Nullables
{
    public class Contact : Value
    {
        public string Name { get; }
        public Address? Address { get; }
        public Contact(string name, Address? address)
        {
            Name = name;
            Address = address;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(Name, Address!);
    }
}
