using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject.Currencies
{
    public class UsdCurrency
    {
        public static Currency GetInfo()
        {
            return Currency.From(("$", "USD", "840", "US Dollar"));
        }
    }
}
