using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Finance
{
    public class Money : Value
    {
        public Currency Currency { get; }
        public Amount Amount { get; }

        public Money(Currency currency, Amount amount)
        {
            this.Currency = currency;
            this.Amount = amount;
        }

        protected override IEnumerable<ValueBase> GetValues()
        {
            yield return Currency;
            yield return Amount;
        }
    }
}
