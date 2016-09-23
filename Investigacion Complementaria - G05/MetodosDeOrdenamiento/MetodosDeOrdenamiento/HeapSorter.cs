using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeOrdenamiento
{
    public class HeapSorter
    {
        private int[] a = new int[100]; // arreglo de enteros
        private int x = 0; // número de elementos en el arreglo
        private bool asc = true;
        public HeapSorter(ref int[] array)
        {
            a = array;
            x = array.Length;
        }
        public HeapSorter(ref int[] array, bool desc)
        {
            a = array;
            x = array.Length;
            asc = desc;
        }
        // Algoritmo HeapSort
        public void sortArray()
        {
            int i;
            int temp;
            for (i = (x - 1) / 2; i >= 0; i--)
            {
                MaxHeapify(a, x, i);
            }

            for (i = x - 1; i > 0; i--)
            {
                temp = a[i];
                a[i] = a[0];
                a[0] = temp;
                x--;
                MaxHeapify(a, x, 0);
            }
        }
        public void MaxHeapify(int[] a, int x, int indice)
        {
            int left = (indice + 1) * 2 - 1;
            int right = (indice + 1) * 2;
            int largest = 0;
            if (asc)
            {
                if (left < x && a[left] > a[indice])
                    largest = left;
                else
                    largest = indice;
                if (right < x && a[right] > a[largest])
                    largest = right;
            }
            else
            {
                if (left < x && a[left] < a[indice])
                    largest = left;
                else
                    largest = indice;
                if (right < x && a[right] < a[largest])
                    largest = right;
            }
            if (largest != indice)
            {
                int temp = a[indice];
                a[indice] = a[largest];
                a[largest] = temp;
                MaxHeapify(a, x, largest);
            }
        } // final de MaxHeapify
    }
}
