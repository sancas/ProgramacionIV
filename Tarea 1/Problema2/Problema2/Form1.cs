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

namespace Problema2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.TabPages.Remove(tabDescuentosSalarios);
            txtSalarioBruto.Text = string.Empty;
        }

        private void edadBar_ValueChanged(object sender, EventArgs e)
        {
            lblEdadBarCount.Text = edadBar.Value.ToString();
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                nombreErrorProvider.SetError(txtNombres, "Debe ingresar un nombre");
            }
            else
            {
                nombreErrorProvider.SetError(txtNombres, string.Empty);
            }
        }

        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                apellidoErrorProvider.SetError(txtApellidos, "Debe ingresar un apellido");
            }
            else
            {
                apellidoErrorProvider.SetError(txtApellidos, string.Empty);
            }
        }

        private void txtSalarioBruto_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalarioBruto.Text))
            {
                salarioBrutoErrorProvider.SetError(txtSalarioBruto, "Debe ingresar un salario");
            }
            else if (!isNumber(txtSalarioBruto.Text))
            {
                salarioBrutoErrorProvider.SetError(txtSalarioBruto, "Solo se admiten numeros.");
            }
            else
            {
                salarioBrutoErrorProvider.SetError(txtSalarioBruto, string.Empty);
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
            txtNombres.Focus();
            txtApellidos.Focus();
            txtSalarioBruto.Focus();
            btnCalcular.Focus();
            validaciones += nombreErrorProvider.GetError(txtNombres);
            validaciones += apellidoErrorProvider.GetError(txtApellidos);
            validaciones += salarioBrutoErrorProvider.GetError(txtSalarioBruto);
            if (!rdbtnFemenino.Checked && !rdbtnMasculino.Checked)
            {
                sexoErrorProvider.SetError(lblSexo, "Debe seleccionar un sexo");
            }
            if (validaciones == string.Empty)
            {
                if (!metroTabControl1.TabPages.Contains(tabDescuentosSalarios))
                    metroTabControl1.TabPages.Add(tabDescuentosSalarios);
                metroTabControl1.SelectTab("tabDescuentosSalarios");
            }
        }

        private void rdbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexoErrorProvider.SetError(lblSexo, string.Empty);
        }

        private void rdbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            sexoErrorProvider.SetError(lblSexo, string.Empty);
        }

        private void tabDescuentosSalarios_Enter(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombres.Text;
            lblApellido.Text = txtApellidos.Text;
            lblEdad.Text = edadBar.Value.ToString() + " años";
            if (rdbtnMasculino.Checked)
                pictureSexo.Image = Properties.Resources.hombre;
            else
                pictureSexo.Image = Properties.Resources.mujer;
            double salarioBruto, descISSS, descRenta, descAFP, salarioLiquido;         
            salarioBruto = double.Parse(txtSalarioBruto.Text);
            if (salarioBruto >= 60)
                descISSS = 40.00;
            else
                descISSS = salarioBruto * 0.06;
            if (edadBar.Value > 50)
                descRenta = salarioBruto * 0.04;
            else if (edadBar.Value > 36)
                descRenta = salarioBruto * 0.05;
            else
                descRenta = salarioBruto * 0.06;
            descAFP = salarioBruto * 0.035;
            salarioLiquido = salarioBruto - descISSS - descAFP - descRenta;
            txtSalarioB.Text += " " + salarioBruto.ToString();
            txtDescISSS.Text += " " + descISSS.ToString();
            txtDescRenta.Text += " " + descRenta.ToString();
            txtDescAFP.Text += " " + descAFP.ToString();
            txtSalarioLiquido.Text += " " + salarioLiquido.ToString();
        }

        private void tabInformacionPersonal_Enter(object sender, EventArgs e)
        {
            if (metroTabControl1.TabPages.Contains(tabDescuentosSalarios))
                metroTabControl1.TabPages.Remove(tabDescuentosSalarios);
        }
    }
}
