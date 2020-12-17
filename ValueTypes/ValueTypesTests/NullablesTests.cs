using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypesTests.Nullables;

namespace ValueTypesTests
{
    [TestClass]
    public class AddressTests : AbstractValueTypeTests<Address>
    {
        protected override ValueBase GetOtherValue() => new Address("123 Main St.", "Suite 2", "San Mateo");
        protected override ValueBase GetSampleValue1() => new Address("123 Main St.", null, "San Mateo");
        protected override ValueBase GetSampleValue2() => new Address("123 Main St.", null, "San Mateo");
    }

    [TestClass]
    public class ContactTests : AbstractValueTypeTests<Contact>
    {
        protected override ValueBase GetOtherValue() => new Contact("Alice", null);
        protected override ValueBase GetSampleValue1() => new Contact("Bob", null);
        protected override ValueBase GetSampleValue2() => new Contact("Bob", null);
    }

    [TestClass]
    public class ContactWithAddressTests : AbstractValueTypeTests<Contact>
    {
        protected override ValueBase GetOtherValue() => new Contact("Alice", new Address("888 First Ave", "Apt 77", "Eight City"));
        protected override ValueBase GetSampleValue1() => new Contact("Alice", new Address("888 First Ave", "Apt 88", "Eight City"));
        protected override ValueBase GetSampleValue2() => new Contact("Alice", new Address("888 First Ave", "Apt 88", "Eight City"));
    }
}
