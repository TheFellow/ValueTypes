using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests.Records
{
    public record ThermalUnit
    {
        private ThermalUnit() { }
        public string Symbol { get; init; } = string.Empty;

        public static ThermalUnit Farenheit => new() { Symbol = "F" };
        public static ThermalUnit Celsius => new() { Symbol = "C" };

    }

    public class Temperature : Value
    {
        ThermalUnit Unit { get; }
        int Amount { get; }

        public Temperature(ThermalUnit unit, int amount)
        {
            Unit = unit;
            Amount = amount;
        }

        protected override IEnumerable<ValueBase> GetValues() => Yield(Amount, Unit.AsValue());
    }

    public sealed class Chemical : Value
    {
        private readonly string _commonName;
        private readonly string _chemicalName;
        private Chemical(string commonName, string chemicalName) =>
            (_commonName, _chemicalName) = (commonName, chemicalName);
        protected override IEnumerable<ValueBase> GetValues() => Yield(_commonName, _chemicalName);

        public static Chemical Alcohol => new("Alcohol", "Ethanol");
        public static Chemical Chalk => new("Chalk", "Calcium Carbonate");
        public static Chemical VitaminC => new("Vitamin C", "Ascorbic Acid");
    }

    public record MolecularFormula(string Formula);

    public record ChemicalCompound
    {
        public Chemical Chemical { get; }
        public MolecularFormula Formula { get; }

        public ChemicalCompound(Chemical chemical, MolecularFormula formula)
        {
            Chemical = chemical;
            Formula = formula;
        }
    }
}
