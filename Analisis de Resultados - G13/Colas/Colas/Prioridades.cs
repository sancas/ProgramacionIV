using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Prioridades : Form
    {
        private int cantidad;
        private AdminPrioridades ventanaAdminPrioridades;

        public Prioridades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtCantidadPrioridades.Text);
            ventanaAdminPrioridades = new AdminPrioridades(cantidad);
            this.Hide();
            ventanaAdminPrioridades.ShowDialog();
            this.Close();
        }
    }
}
