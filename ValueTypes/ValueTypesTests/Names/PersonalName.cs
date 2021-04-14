using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Names
{
    public class PersonalName : Value
    {
        public string FirstName { get; }
        public string LastName { get; }

        public PersonalName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(FirstName, LastName);
    }
}
