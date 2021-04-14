using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Cards
{
    public class Card : Value
    {
        public CardValue CardValue { get; }
        public Suit Suit { get; }

        public Card(CardValue cardValue, Suit suit)
        {
            CardValue = cardValue;
            Suit = suit;
        }
        protected override IEnumerable<ValueBase> GetValues() => Yield(CardValue, Suit);
        public override string ToString() => $"{CardValue}{Suit}";
    }
}
