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
    public partial class MenuPrincipal : Form
    {
        public Cuenta miCuenta; //Cuenta actual
        private Cajero miCajero; //Cajero actual
        private Retirar ventanaRetirar;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Cuenta miCuenta, Cajero miCajero)
        {
            InitializeComponent();
            this.miCuenta = miCuenta;
            this.miCajero = miCajero;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Tarjeta: {0}\nSaldo: {1}", miCuenta.Tarjeta, miCuenta.balance.ToString()),
                "Estado de la cuenta.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            ventanaRetirar = new Retirar(miCuenta, miCajero);
            this.Hide();
            ventanaRetirar.ShowDialog();
            this.Show();
        }
    }
}
