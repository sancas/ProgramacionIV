using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MetodosDeOrdenamiento
{
    public class HeapSorter
    {
        private int[] a = new int[100]; // arreglo de enteros
        private int x = 0; // número de elementos en el arreglo
        public bool ascendente;
        public Form1 myForm = new Form1();
        public HeapSorter(ref int[] array)
        {
            a = array;
            x = array.Length;
        }
        // Algoritmo HeapSort
        public void sortArray(ref Button[] Arreglo, ref Button[] ArregloArbol)
        {
            int i;
            int temp;
            for (i = (x - 1) / 2; i >= 0; i--)
            {
                MaxHeapify(a, x, i, ref Arreglo, ref ArregloArbol);
            }

            for (i = x - 1; i > 0; i--)
            {
                temp = a[i];
                a[i] = a[0];
                a[0] = temp;
                x--;
                myForm.intercambio(ref Arreglo, i, 0);
                myForm.intercambioArbol(ref ArregloArbol, i, 0);
                MaxHeapify(a, x, 0, ref Arreglo, ref ArregloArbol);
            }
        }
        public void MaxHeapify(int[] a, int x, int indice, ref Button[] Arreglo, ref Button[] ArregloArbol)
        {
            int left = (indice + 1) * 2 - 1;
            int right = (indice + 1) * 2;
            int largest;
            if (ascendente)
            {
                largest = 0;
                if (left < x && a[left] > a[indice])
                    largest = left;
                else
                    largest = indice;
                if (right < x && a[right] > a[largest])
                    largest = right;
            }
            else
            {
                largest = 99;
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
                myForm.intercambio(ref Arreglo, largest, indice);
                myForm.intercambioArbol(ref ArregloArbol, largest, indice);
                MaxHeapify(a, x, largest, ref Arreglo, ref ArregloArbol);
            }
        } // final de MaxHeapify
    } // final de clase HeapSorter
}
