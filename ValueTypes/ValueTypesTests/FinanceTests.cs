using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ValueTypes;
using ValueTypesTests.Finance;

namespace ValueTypesTests
{
    [TestClass]
    public class AmountTests : AbstractValueTypeTests<Amount>
    {
        protected override ValueBase GetOtherValue() => new Amount(3.14m);
        protected override ValueBase GetSampleValue1() => new Amount(2.72m);
        protected override ValueBase GetSampleValue2() => new Amount(2.72m);
    }

    [TestClass]
    public class CurrencyTests : AbstractValueTypeTests<Currency>
    {
        protected override ValueBase GetOtherValue() => Currency.USD;
        protected override ValueBase GetSampleValue1() => Currency.EUR;
        protected override ValueBase GetSampleValue2() => Currency.EUR;
    }

    [TestClass]
    public class MoneyTests : AbstractValueTypeTests<Money>
    {
        protected override ValueBase GetOtherValue() => new Money(Currency.USD, new Amount(1234.56m));
        protected override ValueBase GetSampleValue1() => new Money(Currency.EUR, new Amount(1234.56m));
        protected override ValueBase GetSampleValue2() => new Money(Currency.EUR, new Amount(1234.56m));
    }

    [TestClass]
    public class CreditCompanyTests : AbstractValueTypeTests<CreditCompany>
    {
        protected override ValueBase GetOtherValue() => CreditCompany.MasterCard;
        protected override ValueBase GetSampleValue1() => CreditCompany.Visa;
        protected override ValueBase GetSampleValue2() => CreditCompany.Visa;
    }

    [TestClass]
    public class CreditCardTests : AbstractValueTypeTests<CreditCard>
    {
        protected override ValueBase GetOtherValue() => new CreditCard(CreditCompany.MasterCard, new Amount(10_000m));
        protected override ValueBase GetSampleValue1() => new CreditCard(CreditCompany.Visa, new Amount(10_000m));
        protected override ValueBase GetSampleValue2() => new CreditCard(CreditCompany.Visa, new Amount(10_000m));
    }

    [TestClass]
    public class FinanceTests
    {
        [TestMethod]
        public void Monies_OfDifferentCurrencyAndSameAmount_AreNotEqual()
        {
            var money1 = new Money(Currency.USD, new Amount(45.08m));
            var money2 = new Money(Currency.EUR, new Amount(45.08m));

            Assert.IsFalse(money1.Equals(money2));
            Assert.IsFalse(money2.Equals(money1));
            Assert.IsFalse(money1 == money2);
            Assert.IsFalse(money2 == money1);
            Assert.IsTrue(money1 != money2);
            Assert.IsTrue(money2 != money1);
        }

        [TestMethod]
        public void Monies_OfSameCurrencyAndDifferentAmount_AreNotEqual()
        {
            var money1 = new Money(Currency.USD, new Amount(45.08m));
            var money2 = new Money(Currency.USD, new Amount(14.15m));

            Assert.IsFalse(money1.Equals(money2));
            Assert.IsFalse(money2.Equals(money1));
            Assert.IsFalse(money1 == money2);
            Assert.IsFalse(money2 == money1);
            Assert.IsTrue(money1 != money2);
            Assert.IsTrue(money2 != money1);
        }

        [TestMethod]
        public void Wallet_WithSameCashAndCards_AreEqual()
        {
            var wallet1 = new Wallet(
                new[] { 20m.Dollars(), 10m.Euros(), 5m.Euros() },
                new[] { CreditCompany.Visa.For(1000m.ToAmount()), CreditCompany.MasterCard.For(5000m.ToAmount())
                });

            var wallet2 = new Wallet(
                new[] { 10m.Euros(), 20m.Dollars(), 5m.Euros() },
                new[] { CreditCompany.MasterCard.For(5000m.ToAmount()), CreditCompany.Visa.For(1000m.ToAmount())
                });

            EqualityComparer<Wallet>.Default.Equals(wallet1, wallet2);
            Assert.AreEqual(wallet1, wallet2);
            Assert.IsTrue(wallet1.Equals(wallet2));
            Assert.IsTrue(wallet1 == wallet2);
            Assert.IsTrue(wallet2 == wallet1);
            Assert.IsFalse(wallet1 != wallet2);
            Assert.IsFalse(wallet2 != wallet1);
        }
    }
}
