using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Ejemplo1 : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;
        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }
        public void limpiarPantalla()
        {
            Pantalla.Text = "";
        }
        public double obtenerValor()
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiarPantalla();
            return valor;
        }
        public void actualizarPantalla(String texto)
        {
            Pantalla.Text = Pantalla.Text + texto;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            actualizarPantalla("0");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            actualizarPantalla("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            actualizarPantalla("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            actualizarPantalla("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            actualizarPantalla("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            actualizarPantalla("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            actualizarPantalla("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            actualizarPantalla("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            actualizarPantalla("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            actualizarPantalla("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                Is1 = true;
                Operacion = 0;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                Is1 = true;
                Operacion = 1;
            }
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                Is1 = true;
                Operacion = 2;
            }
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                Is1 = true;
                Operacion = 3;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Is1)
                {
                    Num2 = obtenerValor();
                    if (Operacion == 0)
                        actualizarPantalla(operar(Num1, Num2, "+").ToString());
                    else if (Operacion == 1)
                        actualizarPantalla(operar(Num1, Num2, "-").ToString());
                    else if (Operacion == 2)
                        actualizarPantalla(operar(Num1, Num2, "*").ToString());
                    else if (Operacion == 3)
                    {
                        if (Num2 == 0)
                            MessageBox.Show("No se puede realizar la division entre cero");
                        else
                            actualizarPantalla(operar(Num1, Num2, "/").ToString());
                    }
                    else if (Operacion == 4)
                        actualizarPantalla(operar(Num1, Num2, "^").ToString());
                    Is1 = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una operacion para realizar");
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operandos");
            }
        }
        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;
                case "-":
                    Resultado = operador1 - operador2;
                    break;
                case "*":
                    Resultado = operador1 * operador2;
                    break;
                case "/":
                    Resultado = operador1 / operador2;
                    break;
                case "^":
                    Resultado = Math.Pow(operador1, operador2);
                    break;
                case "sin":
                    Resultado = Math.Sin(operador1 * Math.PI / 180.0);
                    break;
                case "cos":
                    Resultado = Math.Cos(operador1 * Math.PI / 180.0);
                    break;
                case "tan":
                    Resultado = Math.Tan(operador1 * Math.PI / 180.0);
                    break;
                case "log":
                    Resultado = Math.Log10(operador1);
                    break;
                case "ln":
                    Resultado = Math.Log(operador1);
                    break;
                default:
                    break;
            }
            return Resultado;
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                Is1 = true;
                Operacion = 4;
            }
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                actualizarPantalla(operar(Num1, 0.0, "sin").ToString());
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                actualizarPantalla(operar(Num1, 0.0, "cos").ToString());
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                actualizarPantalla(operar(Num1, 0.0, "tan").ToString());
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                actualizarPantalla(operar(Num1, 0.0, "log").ToString());
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (!Is1 && Pantalla.Text != "")
            {
                Num1 = obtenerValor();
                actualizarPantalla(operar(Num1, 0.0, "ln").ToString());
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            actualizarPantalla(".");
        }
    }
}
