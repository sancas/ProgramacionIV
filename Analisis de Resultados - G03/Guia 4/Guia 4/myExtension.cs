using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class myExtension
    {
        public static bool IsNumber(this string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (!Char.IsNumber(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
