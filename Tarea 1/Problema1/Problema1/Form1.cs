using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            }
        }

        private void txtPrestamo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrestamo.Text))
            {
                prestamoErrorProvider.SetError(txtPrestamo, "Debe ingresar un valor.");
            }
            else if (!isNumber(txtPrestamo.Text))
            {
                prestamoErrorProvider.SetError(txtPrestamo, "Solo se admiten numeros.");
            }
            else
            {
                prestamoErrorProvider.SetError(txtPrestamo, string.Empty);
            }
        }

        private void txtTasa_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTasa.Text))
            {
                tasaErrorProvider.SetError(txtTasa, "Debe ingresar un valor.");
            }
            else if (!isNumber(txtTasa.Text))
            {
                tasaErrorProvider.SetError(txtTasa, "Solo se admiten numeros.");
            }
            else
            {
                tasaErrorProvider.SetError(txtTasa, string.Empty);
            }
        }

        private void txtMeses_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMeses.Text))
            {
                mesesErrorProvider.SetError(txtMeses, "Debe ingresar un valor.");
            }
            else if (!isNumber(txtMeses.Text))
            {
                mesesErrorProvider.SetError(txtMeses, "Solo se admiten numeros.");
            }
            else
            {
                mesesErrorProvider.SetError(txtMeses, string.Empty);
            }
        }

        private bool isNumber(string value)
        {
            double noNeed = 0;
            return double.TryParse(value, out noNeed);
        }
    }
}
