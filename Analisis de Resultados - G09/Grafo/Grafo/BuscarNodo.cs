using System;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Grafo
{
    public partial class BuscarNodo : MetroForm
    {
        public bool control; // variable de control
        public string dato; // el dato que almacenará el vértice

        public BuscarNodo()
        {
            InitializeComponent();
            this.StyleManager = BuscarNodoStyleManager;
            control = false;
            dato = " ";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valor = txtVertice.Text.Trim();
            if ((valor == "") || (valor == " "))
            {
                MessageBox.Show("Debes ingresar un valor", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                control = true;
                Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }

        private void BuscarNodo_Load(object sender, EventArgs e)
        {
            txtVertice.Focus();
        }

        private void BuscarNodo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void BuscarNodo_Shown(object sender, EventArgs e)
        {
            txtVertice.Clear();
            txtVertice.Focus();
        }

        private void txtVertice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, null);
            }
        }

        private void txtVertice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
