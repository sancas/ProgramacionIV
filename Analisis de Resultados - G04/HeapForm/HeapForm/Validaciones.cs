using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapForm
{
    public static class Validaciones
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

        public static bool IsInt(this string sCaracteres)
        {
            int noSirve = 0;
            return int.TryParse(sCaracteres, out noSirve);
        }
    }
}
