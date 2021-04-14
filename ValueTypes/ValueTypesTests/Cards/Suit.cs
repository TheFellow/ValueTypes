using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Cards
{
    public class Suit : Value
    {
        public char Symbol { get; }
        private Suit(char symbol) => Symbol = symbol;

        public static Suit Clubs => new('♣');
        public static Suit Spades => new('♠');
        public static Suit Hearts => new('♥');
        public static Suit Diamonds => new('♦');

        protected override IEnumerable<ValueBase> GetValues() => Yield(Symbol);

        public override string ToString() => $"{Symbol}";
    }
}
