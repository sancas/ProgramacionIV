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
    public partial class frmLogin : Form
    {
        //Crear un nuevo cajero con 5 billetes de $5, 2 billetes de $10 y 1 billete de $20, en total $65
        public Cajero miCajero = new Cajero(new int[] { 5, 2, 1 });
        public MenuPrincipal ventanaMenu = null;
        /*
        Cuentas.
        Cuenta 1. No. Tarjeta: 1234, Pin: 1122, Saldo: $1000,
        Cuenta 2. No. Tarjeta: 1111, Pin: 3344, Saldo: $10,
        Cuenta 3. No. Tarjeta: 2222, Pin: 5566, Saldo: $999,
        Cuenta 4. No. Tarjeta: 3333, Pin: 7788, Saldo: $18
        */
        public Cuenta[] Cuentas =
        {
            new Cuenta("1234", "1122", 1000),
            new Cuenta("1111", "3344", 10),
            new Cuenta("2222", "5566", 999),
            new Cuenta("3333", "7788", 18)
        };
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            foreach (Cuenta miCuenta in Cuentas)
            {
                if (miCuenta.Tarjeta == txtTarjeta.Text && miCuenta.Pin == txtPin.Text)
                {
                    ventanaMenu = new MenuPrincipal(miCuenta, miCajero);
                    this.Hide();
                    ventanaMenu.ShowDialog();
                    this.Show();
                }
            }
            if(ventanaMenu == null)
            {
                MessageBox.Show("Los datos no coinciden",
                    "Datos incorrectos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                ventanaMenu = null;
                txtTarjeta.Text = "";
                txtPin.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
