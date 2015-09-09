using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SH
{
    public void Sort(int[] list)
    {
        int j, inc;
        inc = list.Length / 2;
        while (inc >= 1)
        {
            for (int i = inc; i < list.Length; i++)
            {
                int v = list[i];
                j = i - inc;
                while (j >= 0 && list[j] > v)
                {
                    list[j + inc] = list[j];
                    j = j - inc;
                }
                list[j + inc] = v;
            }
            inc = inc / 2;
        }
    }
}

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[] { 22, 15, 3, 16, 30, 45, 9, 27, 7, 12, 44, 85, 24, 47, 33, 67, 55, 1, 93, 16 };
            System.Console.WriteLine("Metodo de Ordenamiento: Shell");
            SH sh = new SH();
            sh.Sort(iArray);
            System.Console.WriteLine("Se imprimen: ");
            for (int m = 0; m <= 19; m++)
                Console.WriteLine("Valor {0}: {1}", m + 1, iArray[m]);
            Console.ReadKey();
        }
    }
}
