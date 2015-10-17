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
    public partial class NodoDijkstra : Form
    {
        public bool control; // variable de control
        public string dato; // el dato que almacenará el arco

        public NodoDijkstra()
        {
            InitializeComponent();
            control = false;
            dato = " ";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valor = cmbNodoDijkstra.Text.Trim();
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

        private void NodoDijkstra_Load(object sender, EventArgs e)
        {
            cmbNodoDijkstra.Focus();
        }

        private void NodoDijkstra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void NodoDijkstra_Shown(object sender, EventArgs e)
        {
            cmbNodoDijkstra.Focus();
        }
    }
}
