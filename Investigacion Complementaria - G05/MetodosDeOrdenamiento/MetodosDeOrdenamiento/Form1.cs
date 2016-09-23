using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace MetodosDeOrdenamiento
{
    public partial class Form1 : Form
    {
        int[] Arreglo_numeros;
        int cantidadNumeros;
        string Complejidad;

        public Form1()
        {
            InitializeComponent();
        }

        //Metodo de ordenamiento QuickSort
        public void QuickSort(ref int[] arreglo, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = arreglo[central];
            i = primero;
            j = ultimo;
            do
            {
                if (rdbtnAscendente.Checked)
                {
                    while (arreglo[i] < pivote) i++;
                    while (arreglo[j] > pivote) j--;
                }
                else if (rdbtnDescendente.Checked)
                {
                    while (arreglo[i] > pivote) i++;
                    while (arreglo[j] < pivote) j--;
                }
                if (i <= j)
                {
                    int temp;
                    temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (primero < j)
            {
                QuickSort(ref arreglo, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(ref arreglo, i, ultimo);
            }
        }

        //Metodo de Ordenamiento por Seleccion
        public void SelectionSort(ref int[] arreglo)
        {
            int pos_min, temp;
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (rdbtnAscendente.Checked)
                    {
                        if (arreglo[j] < arreglo[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                    else if (rdbtnDescendente.Checked)
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

        //Metodo de Ordenamiento Burbuja
        public void BubbleSort(ref int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1] && rdbtnAscendente.Checked)
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                    else if (arreglo[j] < arreglo[j + 1] && rdbtnDescendente.Checked)
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }
        }

        //Metodo de Ordenamiento por Insercion
        public void InsertionSort(ref int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                int temp = arreglo[i];
                int j = i - 1;

                if (rdbtnAscendente.Checked)
                {
                    while ((j >= 0) && (arreglo[j] > temp))
                    {
                        arreglo[j + 1] = arreglo[j];
                        j--;
                    }
                }
                else if (rdbtnDescendente.Checked)
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

        //Metodo ordenamiento por ShellSort
        public void ShellSort(ref int[] arreglo)
        {
            int j, inc;
            inc = arreglo.Length / 2;
            while (inc >= 1)
            {
                for (int i = inc; i < arreglo.Length; i++)
                {
                    int v = arreglo[i];
                    j = i - inc;
                    if (rdbtnAscendente.Checked)
                    {
                        while (j >= 0 && arreglo[j] > v)
                        {
                            arreglo[j + inc] = arreglo[j];
                            j = j - inc;
                        }
                        arreglo[j + inc] = v;
                    }
                    else
                    {
                        while (j >= 0 && arreglo[j] < v)
                        {
                            arreglo[j + inc] = arreglo[j];
                            j = j - inc;
                        }
                        arreglo[j + inc] = v;
                    }
                }
                inc = inc / 2;
            }
        }

        //Metodo de Ordenamiento de MergeSort
        public void MergeSort(ref int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(ref input, left, middle);
                MergeSort(ref input, middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j] && rdbtnAscendente.Checked)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] >= rightArray[j] && rdbtnDescendente.Checked)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }

        //Metodo de Ordenamiento de HeapSort
        public void HeapSort()
        {
            HeapSorter miHeap = new HeapSorter(ref Arreglo_numeros, rdbtnAscendente.Checked);
            miHeap.sortArray();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cmbMetodos.SelectedIndex != -1 && Arreglo_numeros != null)
            {
                if (cmbMetodos.SelectedItem.ToString() == "BubbleSort")
                {
                    BubbleSort(ref Arreglo_numeros);
                    Complejidad = "La complejidad para este ejemplo de BubbleSort es: " + Math.Pow(cantidadNumeros, 2).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "SelectionSort")
                {
                    SelectionSort(ref Arreglo_numeros);
                    Complejidad = "La complejidad para este ejemplo de SelectionSort es: " + Math.Pow(cantidadNumeros, 2).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "InsertionSort")
                {
                    InsertionSort(ref Arreglo_numeros);
                    Complejidad = "La complejidad para este ejemplo de InsertionSort es: " + Math.Pow(cantidadNumeros, 2).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "ShellSort")
                {
                    ShellSort(ref Arreglo_numeros);
                    Complejidad = "La complejidad para este ejemplo de ShellSort es: " + Math.Pow(Math.Log10(cantidadNumeros), 2).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "MergeSort")
                {
                    MergeSort(ref Arreglo_numeros, 0, Arreglo_numeros.Length - 1);
                    Complejidad = "La complejidad para este ejemplo de MergeSort es: " + (cantidadNumeros * Math.Log10(cantidadNumeros)).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "QuickSort")
                {
                    QuickSort(ref Arreglo_numeros, 0, Arreglo_numeros.Length - 1);
                    Complejidad = "La complejidad para este ejemplo de QuickSort es: " + Math.Pow(cantidadNumeros, 2).ToString();
                }
                else if (cmbMetodos.SelectedItem.ToString() == "HeapSort")
                {
                    HeapSort();
                    Complejidad = "La complejidad para este ejemplo de HeapSort es: " + (cantidadNumeros * Math.Log10(cantidadNumeros)).ToString();
                }
                for (int x = 0; x < cantidadNumeros; x++)
                {
                    listOrdenados.Items.Add(Arreglo_numeros[x]);
                }
                txtComplejidad.Text = Complejidad;
                btnOrdenar.Enabled = false;
            }
            else if (Arreglo_numeros == null)
                MessageBox.Show("Debe generar una lista de numeros primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Seleccione un metodo de ordenamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != string.Empty)
            {
                Random miRandom = new Random();
                cantidadNumeros = int.Parse(txtNumero.Text);
                Arreglo_numeros = new int[cantidadNumeros];
                for (int x = 0; x < cantidadNumeros; x++)
                {
                    Arreglo_numeros[x] = miRandom.Next(-99, 99);
                    listDesordenados.Items.Add(Arreglo_numeros[x]);
                }
                btnGenerar.Enabled = false;
            }
            else
                MessageBox.Show("Debe ingresar una cantidad de numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Arreglo_numeros = null;
            listOrdenados.Items.Clear();
            listDesordenados.Items.Clear();
            cmbMetodos.SelectedIndex = -1;
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
            txtComplejidad.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtNumero.Focus();
        }
    }
}
