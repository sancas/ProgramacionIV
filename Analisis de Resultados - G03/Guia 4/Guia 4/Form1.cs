using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ExtensionMethods;

namespace Guia_4
{
    public partial class Form1 : MetroForm
    {
        int[] arregloNumeros;
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabListadoDeNumeros);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            txtTotalNumeros.Focus();
            cmbMetodos.Focus();
            this.Focus();
            if (cmbMetodos.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbMetodos, "Debe elegir un metodo");
            }
            validaciones += errorProvider.GetError(txtTotalNumeros);
            validaciones += errorProvider.GetError(cmbMetodos);
            if (validaciones == string.Empty)
            {
                if (!tabControl.TabPages.Contains(tabListadoDeNumeros))
                    tabControl.TabPages.Add(tabListadoDeNumeros);
                tabControl.SelectedIndex = 1;
                arregloNumeros = new int[int.Parse(txtTotalNumeros.Text)];
                Random miRandom = new Random();
                for (int x = 0; x < int.Parse(txtTotalNumeros.Text); x++)
                {
                    arregloNumeros[x] = miRandom.Next(-999, 999);
                    listNumerosDesordenados.Items.Add(arregloNumeros[x].ToString());
                }
            }
        }

        private void txtTotalNumeros_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalNumeros.Text))
            {
                errorProvider.SetError(txtTotalNumeros, "Debe ingresar un numero");
            }
            else if (!txtTotalNumeros.Text.IsNumber())
            {
                errorProvider.SetError(txtTotalNumeros, "Solo se admiten numeros enteros positivos");
            }
            else
            {
                errorProvider.SetError(txtTotalNumeros, string.Empty);
            }
        }

        private void cmbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbMetodos, string.Empty);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cmbMetodos.SelectedItem == "ShellSort")
            { ShellSort(ref arregloNumeros); }
            else if (cmbMetodos.SelectedItem == "MergeSort")
            { MergeSort(ref arregloNumeros, 0, arregloNumeros.Length - 1);  }
            for (int x = 0; x < arregloNumeros.Length; x++)
            {
                listNumerosOrdenados.Items.Add(arregloNumeros[x]);
            }
            this.Focus();
        }

        //Algoritmo para ordenar por shellsort
        private void ShellSort(ref int[] arreglo)
        {
            int j, inc;
            inc = arreglo.Length / 2;
            while (inc >= 1)
            {
                for (int i = inc; i < arreglo.Length; i++)
                {
                    int v = arreglo[i];
                    j = i - inc;
                    while (j >= 0 && arreglo[j] > v)
                    {
                        arreglo[j + inc] = arreglo[j];
                        j = j - inc;
                    }
                    arreglo[j + inc] = v;
                }
                inc = inc / 2;
            }
        }

        //Algoritmo para ordenar por mergesort
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
                    else if (leftArray[i] <= rightArray[j])
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

        private void tabListadoDeNumeros_Leave(object sender, EventArgs e)
        {
            txtTotalNumeros.Clear();
            cmbMetodos.SelectedIndex = -1;
            listNumerosOrdenados.Items.Clear();
            listNumerosDesordenados.Items.Clear();
            tabControl.TabPages.Remove(tabListadoDeNumeros);
        }
    }
}
