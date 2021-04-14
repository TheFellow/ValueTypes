using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Cards
{
    public class Suit : Value
    {
        public char Symbol { get; }
        private Suit(char symbol) => Symbol = symbol;

        public static Suit Clubs => new Suit('♣');
        public static Suit Spades => new Suit('♠');
        public static Suit Hearts => new Suit('♥');
        public static Suit Diamonds => new Suit('♦');

        protected override IEnumerable<ValueBase> GetValues() => Yield(Symbol);

        public override string ToString() => $"{Symbol}";
    }
}
