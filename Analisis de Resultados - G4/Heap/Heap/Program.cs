using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainClass
{
    public static void showArray(int[] iArray)
    {
        for (int m = 0; m < iArray.Length; m++)
            Console.Write("{0} ", iArray[m]);
        Console.ReadLine();
    }
} 

public class HeapSorter {
    private int[] a = new int[100]; // arreglo de enteros
    private int x = 0; // número de elementos en el arreglo
    public HeapSorter(ref int[] array) {
            a = array;
            x = array.Length;
        }
        // Algoritmo HeapSort
    public void sortArray() {
        int i;
        int temp;
        for (i = ( x - 1) / 2; i >= 0; i--) {
            MaxHeapify(a, x, i);
        }

        MainClass.showArray(a);
        for (i = x - 1; i > 0; i--) {
            temp = a[i];
            a[i] = a[0];
            a[0] = temp;
            x--;
            MaxHeapify(a, x, 0);
            MainClass.showArray(a);
        }
    }
    public void MaxHeapify(int[] a, int x, int indice) {
            int left = (indice + 1) * 2 - 1;
            int right = (indice + 1) * 2;
            int largest = 0;
            if (left < x && a[left] > a[indice])
                largest = left;
            else
                largest = indice;
            if (right < x && a[right] > a[largest])
                largest = right;
            if (largest != indice) {
                int temp = a[indice];
                a[indice] = a[largest];
                a[largest] = temp;
                MaxHeapify(a, x, largest);
            }
        } // final de MaxHeapify
} // final de clase HeapSorter

namespace Heap
{
    class Program
    {
        public static void Main()
        {
            int[] iArray = new int[] { 11, 25, 33, 6, 30, 75, 29, 2, 107, 32, 54, 95, 43, 67 };
            HeapSorter hs = new HeapSorter(ref iArray);

            MainClass.showArray(iArray);
            hs.sortArray();
            MainClass.showArray(iArray);
        }
    }
}
