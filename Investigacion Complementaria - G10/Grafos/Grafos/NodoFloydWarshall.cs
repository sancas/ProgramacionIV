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
    public partial class NodoFloydWarshall : Form
    {
        public bool control; // variable de control
        public string dato; // el dato que almacenará el arco

        public NodoFloydWarshall()
        {
            InitializeComponent();
            control = false;
            dato = " ";
        }

        private void NodoFloydWarshall_Load(object sender, EventArgs e)
        {
            cmbNodoFinal.Focus();
        }

        private void NodoFloydWarshall_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nodoInicial = cmbNodoInicial.Text.Trim();
            string nodoFinal = cmbNodoFinal.Text.Trim();
            if ((nodoInicial == "") || (nodoInicial == " "))
            {
                MessageBox.Show("Debes seleccionar un valor de inicio", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if ((nodoFinal == "") || (nodoFinal == " "))
            {
                MessageBox.Show("Debes seleccionar un valor final", "Error", MessageBoxButtons.OK,
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

        private void NodoFloydWarshall_Shown(object sender, EventArgs e)
        {
            cmbNodoInicial.Focus();
        }
    }
}
