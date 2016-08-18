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

namespace Problema3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
        }

        private void txtCodigoProducto_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                errorProvider.SetError(txtCodigoProducto, "Debe digitar un codigo");
            }
            else if (txtCodigoProducto.Text.Length < 3)
            {
                errorProvider.SetError(txtCodigoProducto, "El codigo debe ser de 3 caracteres");
            }
            else
            {
                errorProvider.SetError(txtCodigoProducto, string.Empty);
            }
        }

        private void txtNombreProducto_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider.SetError(txtNombreProducto, "Debe digitar un nombre");
            }
            else if (!txtNombreProducto.Text.IsLetters())
            {
                errorProvider.SetError(txtNombreProducto, "Solo se permiten letras");
            }
            else
            {
                errorProvider.SetError(txtNombreProducto, string.Empty);
            }
        }

        private void txtPrecioProducto_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                errorProvider.SetError(txtPrecioProducto, "Debe digitar un precio");
            }
            else if (!txtPrecioProducto.Text.IsNumber())
            {
                errorProvider.SetError(txtPrecioProducto, "Solo se permiten numeros enteros");
            }
            else
            {
                errorProvider.SetError(txtPrecioProducto, string.Empty);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            txtCodigoProducto.Focus();
            txtNombreProducto.Focus();
            txtPrecioProducto.Focus();
            btnGuardar.Focus();
            if (cmbPaisFabricacion.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbPaisFabricacion, "Debe seleccionar un pais");
            }
            validaciones += errorProvider.GetError(txtCodigoProducto);
            validaciones += errorProvider.GetError(txtNombreProducto);
            validaciones += errorProvider.GetError(txtPrecioProducto);
            validaciones += errorProvider.GetError(cmbPaisFabricacion);
            if (validaciones == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Producto guardado con exito", "Accion ejecutada", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                gridProductos.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecioProducto.Text, cmbPaisFabricacion.SelectedText);
                listPrecios.Items.Add(txtPrecioProducto.Text);
                listCodigos.Items.Add(txtCodigoProducto.Text);
                metroTabControl1.SelectTab("tabInformacionRegistrada");
            }
        }

        private void cmbPaisFabricacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbPaisFabricacion, string.Empty);
        }

        private void tabInformacionOrdenada_Enter(object sender, EventArgs e)
        {
            string[] codigos = new string[listCodigos.Items.Count];
            int[] precios = new int[listPrecios.Items.Count];
            for (int x = 0; x < listCodigos.Items.Count; x++)
            {
                precios[x] = int.Parse(listPrecios.Items[x].ToString());
                codigos[x] = listCodigos.Items[x].ToString();
            }
            OrdenarCodigos(codigos);
            OrdenarPrecios(precios);
            for (int x = 0; x < listCodigos.Items.Count; x++)
            {
                listCodigos.Items[x] = codigos[x];
                listPrecios.Items[x] = precios[x];
            }
        }

        public void OrdenarPrecios(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] < arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }
        }

        static void OrdenarCodigos(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }

        private void tabRegistrarInformacion_Enter(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            cmbPaisFabricacion.SelectedIndex = -1;
        }
    }
}
