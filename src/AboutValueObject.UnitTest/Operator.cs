using AboutValueObject.Currencies;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject.UnitTest
{
    public class OperatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlusOperator()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, UsdCurrency.GetInfo()));
            Assert.AreEqual((first + second).Value.Amount,2.6, "Plus operator broken");
        }

        [Test]
        public void MinusOperator()
        {
            var first = Money.From((2.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, UsdCurrency.GetInfo()));
            Assert.AreEqual((first - second).Value.Amount, 1, "Minus operator broken");
        }

        [Test]
        public void EqualOperator()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, UsdCurrency.GetInfo()));
            Assert.IsTrue(first == second, "Equal operator broken");
        }

        [Test]
        public void NotEqualOperator()
        {
            var first = Money.From((1.3F, UsdCurrency.GetInfo()));
            var second = Money.From((1.3F, TryCurrency.GetInfo()));
            Assert.IsTrue(first != second, "Not Equal operator broken");
        }
    }
}
