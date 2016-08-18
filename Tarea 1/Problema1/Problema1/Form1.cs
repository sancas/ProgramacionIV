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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            txtPrestamo.Focus();
            txtTasa.Focus();
            txtMeses.Focus();
            txtCuota.CustomButton.Focus();
            validaciones += prestamoErrorProvider.GetError(txtPrestamo);
            validaciones += tasaErrorProvider.GetError(txtTasa);
            validaciones += mesesErrorProvider.GetError(txtMeses);
            if (validaciones == string.Empty)
            {
                double c, p, i;
                int n;
                p = double.Parse(txtPrestamo.Text);
                i = double.Parse(txtTasa.Text) / 100;
                n = int.Parse(txtMeses.Text);
                c = p * ((i * Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n) - 1));
                txtCuota.Text = Math.Round(c, 2).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtCuota.CustomButton.Click += new EventHandler(btnCalcular_Click);
            txtPrestamo.Focus();
        }
    }
}
