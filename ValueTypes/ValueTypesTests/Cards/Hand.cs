using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Cards
{
    public class Hand : Value
    {
        public Card[] Cards { get; }
        public Hand(params Card[] cards) => Cards = cards;
        protected override IEnumerable<ValueBase> GetValues() => Group(Cards);
        public override string ToString() => string.Join<Card>(", ", Cards);

    }
}
