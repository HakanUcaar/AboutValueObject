using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutValueObject
{
    public class Currency : BaseValueObject<(string Symbol, string IsoCode, string NumericCode, string Name), Currency>
    {
        public override string ToString()
        {
            return Value.Name;
        }
    }
}
