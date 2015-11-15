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
    public partial class MergeQueues : Form
    {
        public bool crear = false;

        public int Queue1Index
        {
            get
            {
                return cmbColaA.SelectedIndex;
            }
        }

        public int Queue2Index
        {
            get
            {
                return cmbColaB.SelectedIndex;
            }
        }

        public MergeQueues()
        {
            InitializeComponent();
        }

        private void MergeQueues_Load(object sender, EventArgs e)
        {
            cmbColaA.Focus();
        }

        public void Refresh(List<BinomialQueue> C)
        {
            cmbColaA.Items.Clear();
            cmbColaB.Items.Clear();
            for (int i = 0; i < C.Count; i++)
            {
                if (C[i].isMin)
                {
                    cmbColaA.Items.Add("Cola " + (i + 1).ToString() + "(Min)");
                    cmbColaB.Items.Add("Cola " + (i + 1).ToString() + "(Min)");
                }
                else
                {
                    cmbColaA.Items.Add("Cola " + (i + 1).ToString() + "(Max)");
                    cmbColaB.Items.Add("Cola " + (i + 1).ToString() + "(Max)");
                }
            }
            cmbColaA.SelectedIndex = 0;
            cmbColaB.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbColaA.Text != "" && cmbColaB.Text != "")
            {
                if (cmbColaA.SelectedIndex != cmbColaB.SelectedIndex)
                {
                    crear = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar 2 colas distintas.",
                        "Seleccione colas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione las colas deseadas.",
                    "Seleccione colas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            crear = false;
            this.Hide();
        }
    }
}
