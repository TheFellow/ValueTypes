using System.Collections.Generic;
using ValueTypes;
using ValueTypes.Implementation;

namespace ValueTypesTests.Cards
{
    public class CardValue : Value
    {
        public char Value { get; }
        private CardValue(char value) => Value = value;
        protected override IEnumerable<ValueBase> GetValues() => Yield(Value);
        public override string ToString() => $"{Value}";

        public static CardValue Ace => new CardValue('A');
        public static CardValue Number(int n) => new CardValue(n.ToString()[0]);
        public static CardValue Jack => new CardValue('J');
        public static CardValue Queen => new CardValue('Q');
        public static CardValue King => new CardValue('K');
    }
}
