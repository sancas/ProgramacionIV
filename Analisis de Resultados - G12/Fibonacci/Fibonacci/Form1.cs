using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        private int[] secuencia;
        private string mensaje;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != String.Empty && txtCantidad.Text != "-")
            {
                txtCantidad.BackColor = Color.LimeGreen;
            }
            else
            {
                txtCantidad.BackColor = Color.White;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantidad.Text);
            if (rbtnDinamica.Checked)
            {
                secuencia = FibonacciDinamico(cantidad);
                mensaje = secuencia[0].ToString();
                for (int x = 1; x < cantidad; x++)
                {
                    mensaje += ", " + secuencia[x].ToString();
                }
            }
            else if (rbtnRecursiva.Checked)
            {
                secuencia = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    secuencia[i] = FibonacciRecursivo(i);
                    mensaje += secuencia[i] + ", ";
                }
                mensaje = mensaje.Substring(0, mensaje.Length - 2);
            }
            MessageBox.Show("Fibonacci de " + cantidad.ToString() + " numeros es: \n" + mensaje);
        }

        public int[] FibonacciDinamico(int n) 
        {
            int[] secuencia = new int[n];
            for (int i = 0; i < n; i++) {
                if (i <= 1) {
                    secuencia[i] = 1; //se engloban dos estados
                } else {
                    secuencia[i] = secuencia[i - 1] + secuencia[i - 2]; //tercer estado
                }
            }
            return secuencia;
        }

        public int FibonacciRecursivo(int n)
        {
            if (n <= 1)
                return 1;
            else
                return (FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2));
        }
    }
}
