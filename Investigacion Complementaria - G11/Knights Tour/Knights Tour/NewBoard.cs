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
    public partial class NewBoard : Form
    {
        public bool control; //Variable de control
        public NewBoard()
        {
            InitializeComponent();
            control = false;
        }

        private void NewBoard_Load(object sender, EventArgs e)
        {
            txtBoardSize.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valorX = txtBoardSize.Text.Trim();
            if ((valorX == "") || (valorX == " "))
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

        private void NewBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void NewBoard_Shown(object sender, EventArgs e)
        {
            txtBoardSize.Clear();
            txtBoardSize.Focus();
        }

        private void txtXSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
