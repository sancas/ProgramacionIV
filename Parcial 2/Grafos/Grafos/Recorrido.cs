using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Recorrido : Form
    {
        public bool control; // variable de control
        public string dato; // el dato que almacenara el valor del nodo inicial

        public Recorrido()
        {
            InitializeComponent();
            control = false;
            dato = " ";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valor = txtNodo.Text.Trim();
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

        private void Recorrido_Load(object sender, EventArgs e)
        {
            txtNodo.Focus();
        }

        private void Recorrido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Recorrido_Shown(object sender, EventArgs e)
        {
            txtNodo.Clear();
            txtNodo.Focus();
        }

        private void txtNodo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
