using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class MetodoBurbuja
    {
        //Metodo de Ordenamiento Burbuja
        public static void BubbleSort(ref string[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j].CompareTo(arreglo[j + 1]) > 0)
                    {
                        string aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }
        }
    }
}
