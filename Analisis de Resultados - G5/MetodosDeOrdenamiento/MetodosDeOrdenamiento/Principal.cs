using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosDeOrdenamiento {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            frmBubbleSort frmBubbleSort = new frmBubbleSort();
            this.Hide();
            frmBubbleSort.ShowDialog();
            this.Show();
        }

        private void btnShellsort_Click(object sender, EventArgs e)
        {
            frmShellSort frmShellSort = new frmShellSort();
            this.Hide();
            frmShellSort.ShowDialog();
            this.Show();
        }
    }
}
