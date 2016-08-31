using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema2
{
    public static class Validaciones
    {
        public static bool IsLetters(this string sCaracteres)
        {
            Regex Val = new Regex(@"[A-ZÑ]");
            return Val.IsMatch(sCaracteres);
        }

        public static bool IsNumber(this string sCaracteres)
        {
            Regex Val = new Regex(@"[0-9]");
            return Val.IsMatch(sCaracteres);
        }

        public static bool validarCarnet(this string carnet)
        {
            Regex Val = new Regex(@"[A-Z]{2}[0-9]{6}");
            return Val.IsMatch(carnet);
        }

        public static bool isValidNote(this string nota)
        {
            if (!nota.IsNumber())
                return false;
            if (double.Parse(nota) >= 0 && double.Parse(nota) <= 10)
            {
                Regex Val = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
                if (Val.IsMatch(nota))
                    return true;
            }
            return false;
        }
    }
}
