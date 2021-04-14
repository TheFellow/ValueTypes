using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Finance
{
    public class CreditCompany : Value
    {
        public string Company { get; }
        private CreditCompany(string company) => Company = company;

        protected override IEnumerable<ValueBase> GetValues() => Yield(Company);

        public static CreditCompany Visa => new("Visa");
        public static CreditCompany MasterCard => new("MasterCard");
    }
}
