﻿using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Finance
{
    public sealed class Currency : Value
    {
        private string Symbol { get; }
        private Currency(string currency)
        {
            Symbol = currency;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(Symbol);

        public static Currency USD => new Currency("USD");
        public static Currency EUR => new Currency("EUR");
    }
}
