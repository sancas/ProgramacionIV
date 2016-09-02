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

namespace HeapForm
{
    public partial class Form1 : MetroForm
    {
        string[] v = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            cmbTipoValor.Focus();
            txtTotalElementos.Focus();
            btnOrdenar.Focus();
            this.Focus();

            validaciones = errorProvider.GetError(cmbTipoValor);
            validaciones += errorProvider.GetError(txtTotalElementos);

            if (validaciones == string.Empty)
            {
                int cantidadElementos;
                cantidadElementos = int.Parse(txtTotalElementos.Text);
                int[] arreglo = new int[cantidadElementos];
                Random miRandom = new Random();
                for (int x = 0; x < cantidadElementos; x++)
                {
                    if (cmbTipoValor.SelectedIndex == 0)
                    {
                        arreglo[x] = miRandom.Next(0, 100);
                        arregloDesordenado.Items.Add(arreglo[x]);
                    }
                    else
                    {
                        arreglo[x] = miRandom.Next(0, 25);
                        arregloDesordenado.Items.Add(v[arreglo[x]]);
                    }
                }
                HeapSorter miHeapSort = new HeapSorter(ref arreglo);
                miHeapSort.sortArray();
                for (int x = 0; x < cantidadElementos; x++)
                {
                    if (cmbTipoValor.SelectedIndex == 0)
                    {
                        arregloOrdenado.Items.Add(arreglo[x].ToString());
                    }
                    else
                    {
                        arregloOrdenado.Items.Add(v[arreglo[x]]);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Verifique que ingreso los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalElementos_Validated(object sender, EventArgs e)
        {
            if (!txtTotalElementos.Text.IsNumber())
            {
                errorProvider.SetError(txtTotalElementos, "Solo se admiten numeros enteros");
            }
            else if (!txtTotalElementos.Text.IsInt())
            {
                errorProvider.SetError(txtTotalElementos, "Solo se admiten numeros enteros");
            }
            else if (int.Parse(txtTotalElementos.Text) < 1 || int.Parse(txtTotalElementos.Text) > 100)
            {
                errorProvider.SetError(txtTotalElementos, "Numeros entre 1 y 100");
            }
            else
            {
                errorProvider.SetError(txtTotalElementos, string.Empty);
            }
        }

        private void cmbTipoValor_Validated(object sender, EventArgs e)
        {
            if (cmbTipoValor.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbTipoValor, "Debe seleccionar un tipo");
            }
            else
            {
                errorProvider.SetError(cmbTipoValor, string.Empty);
            }
        }

        private void cmbTipoValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            arregloOrdenado.Items.Clear();
            arregloDesordenado.Items.Clear();
        }
    }
}
