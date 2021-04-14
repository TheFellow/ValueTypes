﻿using System.Collections.Generic;
using ValueTypes;

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

        public static Currency USD => new("USD");
        public static Currency EUR => new("EUR");
    }
}
