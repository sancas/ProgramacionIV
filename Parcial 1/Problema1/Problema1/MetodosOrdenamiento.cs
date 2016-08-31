using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class MetodosOrdenamiento
    {
        //Metodo de Ordenamiento por Seleccion
        public static void SelectionSort(ref int[] arreglo, bool asc)
        {
            int pos_min, temp;
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (asc)
                    {
                        if (arreglo[j] < arreglo[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                    else
                    {
                        if (arreglo[j] > arreglo[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                }
                if (pos_min != i)
                {
                    temp = arreglo[i];
                    arreglo[i] = arreglo[pos_min];
                    arreglo[pos_min] = temp;
                }
            }
        }

        //Metodo de Ordenamiento por Insercion
        public static void InsertionSort(ref int[] arreglo, bool asc)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                int temp = arreglo[i];
                int j = i - 1;

                if (asc)
                {
                    while ((j >= 0) && (arreglo[j] > temp))
                    {
                        arreglo[j + 1] = arreglo[j];
                        j--;
                    }
                }
                else
                {
                    while ((j >= 0) && (arreglo[j] < temp))
                    {
                        arreglo[j + 1] = arreglo[j];
                        j--;
                    }
                }
                arreglo[j + 1] = temp;
            }
        }
    }
}
