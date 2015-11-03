using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Retirar : Form
    {
        private Cuenta miCuenta;
        private Cajero miCajero;
        public Retirar()
        {
            InitializeComponent();
        }

        public Retirar(Cuenta miCuenta, Cajero miCajero)
        {
            InitializeComponent();
            this.miCuenta = miCuenta;
            this.miCajero = miCajero;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtMonto.Text != "" && txtMonto.Text != " " )
            {
                int monto = int.Parse(txtMonto.Text);
                if (monto % 5 == 0)
                {
                    if (miCajero.sePuedeRetirar(miCuenta, monto))
                    {
                        MessageBox.Show(miCajero.retirar(miCuenta, monto),
                            "Retirado correctamente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (!miCuenta.sePuedeRetirar(monto))
                        MessageBox.Show("No tienes tantos fondos, revisa tus fondos en la ventana anterior",
                            "Error al retirar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Este ATM no tiene suficiente fondos",
                            "Error al retirar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Solo montos que sean multiplos de 5.",
                        "Error monto.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
