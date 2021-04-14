using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTypes;
using ValueTypesTests.Records;

namespace ValueTypesTests
{

    [TestClass]
    public class ValueRecordTests : AbstractValueTypeTests<ThermalUnit>
    {
        protected override ValueBase GetOtherValue() => ThermalUnit.Fahrenheit.AsValue();
        protected override ValueBase GetSampleValue1() => ThermalUnit.Celsius.AsValue();
        protected override ValueBase GetSampleValue2() => ThermalUnit.Celsius.AsValue();
    }

    [TestClass]
    public class ValueOfRecordTests : AbstractValueTypeTests<Temperature>
    {
        protected override ValueBase GetOtherValue() => new Temperature(ThermalUnit.Fahrenheit, 32);
        protected override ValueBase GetSampleValue1() => new Temperature(ThermalUnit.Celsius, 0);
        protected override ValueBase GetSampleValue2() => new Temperature(ThermalUnit.Celsius, 0);
    }

    [TestClass]
    public class RecordOfValueTests : AbstractValueTypeTests<ChemicalCompound>
    {
        protected override ValueBase GetOtherValue() => new ChemicalCompound(Chemical.Alcohol, new("C2H6O")).AsValue();
        protected override ValueBase GetSampleValue1() => new ChemicalCompound(Chemical.Chalk, new("CaCO3")).AsValue();
        protected override ValueBase GetSampleValue2() => new ChemicalCompound(Chemical.Chalk, new("CaCO3")).AsValue();
    }
}
