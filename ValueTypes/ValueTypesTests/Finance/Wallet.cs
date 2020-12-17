using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Finance
{
    public class Wallet : Value
    {
        private IEnumerable<Money> Cash { get; }
        private IEnumerable<CreditCard> CreditCards { get; }

        public Wallet(IEnumerable<Money> cash, IEnumerable<CreditCard> creditCards) => (Cash, CreditCards) = (cash, creditCards);

        protected override IEnumerable<ValueBase> GetValues() => Yield(Cash.AsGroup(), CreditCards.AsGroup());
    }
}
