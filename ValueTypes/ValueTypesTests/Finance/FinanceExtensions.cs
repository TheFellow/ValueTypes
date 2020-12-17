namespace ValueTypesTests.Finance
{
    public static class FinanceExtensions
    {
        public static Amount ToAmount(this decimal amount) => new Amount(amount);

        public static Money Dollars(this decimal amount) => new Money(Currency.USD, amount.ToAmount());
        public static Money Euros(this decimal amount) => new Money(Currency.EUR, amount.ToAmount());

        public static CreditCard For(this CreditCompany company, Amount limit) => new CreditCard(company, limit);
    }
}
