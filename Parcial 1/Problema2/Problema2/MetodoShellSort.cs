using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class MetodoShellSort
    {
        public static void ShellSort(ref int[] arreglo)
        {
            int j, inc;
            inc = arreglo.Length / 2;
            while (inc >= 1)
            {
                for (int i = inc; i < arreglo.Length; i++)
                {
                    int v = arreglo[i];
                    j = i - inc;
                    while (j >= 0 && arreglo[j] < v)
                    {
                        arreglo[j + inc] = arreglo[j];
                        j = j - inc;
                    }
                    arreglo[j + inc] = v;
                }
                inc = inc / 2;
            }
        }
    }
}
