using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Std
    {
        public static string ToString(object that)
        {
            return Convert.ToString(that);
        }
        public static P SafeCast<T, P>(this T inp)
            where T : class, P
            where P : class
        {
            if (inp == null)
            {
                throw new NullReferenceException("Cannot cast nuul object");
            }
            P output = inp as T;
            return output;
        }
    }
}
