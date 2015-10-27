using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knights_Tour
{
    public partial class PosicionInicial : Form
    {
        public bool control; //Variable de control

        public PosicionInicial()
        {
            InitializeComponent();
            control = false;
        }

        private void PosicionInicial_Load(object sender, EventArgs e)
        {
            txtPosX.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valorX = txtPosX.Text.Trim();
            string valorY = txtPosY.Text.Trim();
            if ((valorX == "") || (valorX == " ") || (valorY == "") || (valorY == " "))
            {
                MessageBox.Show("Debes ingresar valores", "Error", MessageBoxButtons.OK,
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

        private void PosicionInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void PosicionInicial_Shown(object sender, EventArgs e)
        {
            txtPosX.Clear();
            txtPosY.Clear();
            txtPosX.Focus();
        }

        private void txtPosX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPosY.Focus();
            }
        }

        private void txtPosY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
