using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject
{
    public class Money : BaseValueObject<(float Amount, Currency Currency), Money>
    {
        public override string ToString()
        {
            return $"{this.Value.Amount}{this.Value.Currency.Value.Symbol}";
        }

        protected static bool Equal(Money a, Money b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Currency.Value.Symbol == b.Value.Currency.Value.Symbol;
        }


        public static Money operator + (Money a, Money b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Amount + b.Value.Amount), a.Value.Currency));
        }

        public static Money operator - (Money a, Money b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Amount - b.Value.Amount), a.Value.Currency));
        }
    }
}
