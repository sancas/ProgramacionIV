using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinomialQueue
{
    public partial class ModifiedNode : Form
    {
        public bool crear = false;
        public int NumeroNodoActual
        {
            get
            {
                return int.Parse(txtNode.Text);
            }
            set
            {
                txtNode.Text = value.ToString();
            }
        }

        public int NumeroNodoNuevo
        {
            get
            {
                return int.Parse(txtNewNode.Text);
            }
            set
            {
                txtNewNode.Text = value.ToString();
            }
        }

        public ModifiedNode()
        {
            InitializeComponent();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            crear = true;
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            crear = false;
            this.Hide();
        }

        private void ModifiedNode_Load(object sender, EventArgs e)
        {
            txtNewNode.Text = "";
            txtNode.Text = "";
            txtNode.Focus();
        }
    }
}
