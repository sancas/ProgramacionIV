using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola miCola = new Cola();
            Console.WriteLine("Colando 5 elementos en la cola...");

            miCola.Encolar(3);
            miCola.Encolar(27);
            miCola.Encolar(5);
            miCola.Encolar(22);
            miCola.Encolar(23);

            miCola.Mostrar();
            Console.ReadKey();

            Console.WriteLine("Retirando 2 elementos de la cola...");

            miCola.Desencolar();
            miCola.Desencolar();

            miCola.Mostrar();
            Console.ReadKey();

            Console.WriteLine("Se retiro el elemento: {0}", miCola.DesencolarValor().ToString());
            miCola.Mostrar();
            Console.ReadKey();
        }
    }
}
