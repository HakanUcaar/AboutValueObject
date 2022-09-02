using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject.Currencies
{
    public class TryCurrency
    {
        public static Currency GetInfo()
        {
            return Currency.From(("₺", "TRY", "949", "Turkish Lira"));
        }
    }
}
