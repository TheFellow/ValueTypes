using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Finance
{
    public class Money : Value
    {
        public Currency Currency { get; }
        public Amount Amount { get; }

        public Money(Currency currency, Amount amount)
        {
            Currency = currency;
            Amount = amount;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(Currency, Amount);
    }
}
