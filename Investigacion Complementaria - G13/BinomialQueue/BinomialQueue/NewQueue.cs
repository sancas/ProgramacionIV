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
    public partial class NewQueue : Form
    {
        public bool isMin = true;
        public bool crear = false;

        public NewQueue()
        {
            InitializeComponent();
        }

        private void NewQueue_Load(object sender, EventArgs e)
        {
            cmbSelect.Focus();
            cmbSelect.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            crear = true;
            if (cmbSelect.SelectedIndex == 0)
                isMin = true;
            else
                isMin = false;
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            crear = false;
            this.Hide();
        }
    }
}
