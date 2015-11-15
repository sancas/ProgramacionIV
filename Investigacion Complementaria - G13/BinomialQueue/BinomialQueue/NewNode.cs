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
    public partial class NewNode : Form
    {
        public bool crear = false;
        public int Value
        {
            get
            {
                return int.Parse(txtValor.Text);
            }
            set
            {
                txtValor.Text = value.ToString();
            }
        }        
        public NewNode()
        {
            InitializeComponent();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtValor.Text != "" && txtValor.Text != " ")
            {
                crear = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor numerico valido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            crear = false;
            this.Hide();
        }

        private void NewNode_Load(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Focus();
        }

        private void NewNode_Shown(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Focus();
        }
    }
}
