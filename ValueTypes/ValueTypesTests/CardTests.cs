using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypesTests.Cards;

namespace ValueTypesTests
{
    [TestClass]
    public class SuitTests : AbstractValueTypeTests<Suit>
    {
        protected override ValueBase GetOtherValue() => Suit.Hearts;
        protected override ValueBase GetSampleValue1() => Suit.Diamonds;
        protected override ValueBase GetSampleValue2() => Suit.Diamonds;
    }

    [TestClass]
    public class CardValueTests : AbstractValueTypeTests<CardValue>
    {
        protected override ValueBase GetOtherValue() => CardValue.Ace;
        protected override ValueBase GetSampleValue1() => CardValue.Jack;
        protected override ValueBase GetSampleValue2() => CardValue.Jack;
    }

    [TestClass]
    public class CardTests : AbstractValueTypeTests<Card>
    {
        protected override ValueBase GetOtherValue() => new Card(CardValue.King, Suit.Spades);
        protected override ValueBase GetSampleValue1() => new Card(CardValue.Number(4), Suit.Spades);
        protected override ValueBase GetSampleValue2() => new Card(CardValue.Number(4), Suit.Spades);
    }

    [TestClass]
    public class HandTests : AbstractValueTypeTests<Hand>
    {
        private static Hand Pair => new Hand(new[]
        {
            new Card(CardValue.Queen, Suit.Clubs),
            new Card(CardValue.Queen, Suit.Spades),
            new Card(CardValue.Number(2), Suit.Spades)
        });

        private static Hand SmStraight1 => new Hand(new[]
        {
            new Card(CardValue.Ace, Suit.Hearts),
            new Card(CardValue.Number(2), Suit.Spades),
            new Card(CardValue.Number(3), Suit.Hearts)
        });
        private static Hand SmStraight2 => new Hand(new[]
        {
            new Card(CardValue.Number(2), Suit.Spades),
            new Card(CardValue.Number(3), Suit.Hearts),
            new Card(CardValue.Ace, Suit.Hearts)
        });
        protected override ValueBase GetOtherValue() => Pair;
        protected override ValueBase GetSampleValue1() => SmStraight1;
        protected override ValueBase GetSampleValue2() => SmStraight2;
    }
}
