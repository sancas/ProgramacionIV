using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace Problema1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrestamo.Text = String.Empty;
            txtTasa.Text = String.Empty;
            txtMeses.Text = String.Empty;
            txtCuota.Text = String.Empty;
            txtPrestamo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double c, p, i;
                int n;
                p = Convert.ToDouble(txtPrestamo.Text);
                i = Convert.ToDouble(txtTasa.Text);
                n = Convert.ToInt32(txtMeses.Text);
                c = p * ((i/100 * Math.Pow(1 + i/100, n)) / ((Math.Pow(1 + i/100, n) - 1)));
                txtCuota.Text = c.ToString();
            }
            catch (Exception)
            {
                var texts = Controls.OfType<MetroFramework.Controls.MetroTextBox>();
                foreach (var text in texts)
                {
                    if (string.IsNullOrWhiteSpace(text.Text) && text.Name != "txtCuota")
                    {
                        errores.SetError(text, "Por favor llena los campos requeridos");
                    }
                    if (text.Text.Contains())
                }
            }
        }
    }
}
