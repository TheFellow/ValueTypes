using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Finance
{
    public sealed class Currency : Value
    {
        private string Value { get; }
        private Currency(string currency)
        {
            this.Value = currency;
        }

        protected override IEnumerable<ValueBase> GetValues()
        {
            yield return Value;
        }

        public static Currency USD => new Currency("USD");
        public static Currency EUR => new Currency("EUR");
    }
}
