using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Cards
{
    public class CardValue : Value
    {
        public char Value { get; }
        private CardValue(char value) => Value = value;
        protected override IEnumerable<ValueBase> GetValues() => Yield(Value);
        public override string ToString() => $"{Value}";

        public static CardValue Ace => new('A');
        public static CardValue Number(int n) => new(n.ToString()[0]);
        public static CardValue Jack => new('J');
        public static CardValue Queen => new('Q');
        public static CardValue King => new('K');
    }
}
