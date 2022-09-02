using AboutValueObject.Currencies;
using NUnit.Framework;

namespace AboutValueObject.UnitTest
{
    public class EqualTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Equal()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, UsdCurrency.GetInfo()));
            Assert.AreEqual(first,second,"Two money not equal");
        }

        [Test]
        public void NotEqual()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((2.3F, UsdCurrency.GetInfo()));
            Assert.AreNotEqual(first, second, "Two money equal");
        }

        [Test]
        public void NotEqualCurrency()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, TryCurrency.GetInfo()));
            Assert.AreNotEqual(first.Value.Currency.Value.Symbol, second.Value.Currency.Value.Symbol, "Two money currency equal");
        }
    }
}