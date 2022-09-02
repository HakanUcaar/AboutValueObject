using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject
{
    internal class NotEqualMoneyCurrencyException : RankException
    {
        public NotEqualMoneyCurrencyException() : base($"Two money currency not equal")
        {
        }
    }
}
