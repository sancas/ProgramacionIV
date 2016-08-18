using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeapSort
{
    public partial class frmHome : Form
    {
        bool estado = false;
        bool limpiar = false;
        Point[] posicionBotones =
        {
            new Point(0,0),
            new Point(480, 40),
            new Point(220, 120),
            new Point(740, 120),
            new Point(90, 200),
            new Point(350, 200),
            new Point(610, 200),
            new Point(870, 200),
            new Point(25, 280),
            new Point(155, 280),
            new Point(285, 280),
            new Point(415, 280),
            new Point(545, 280),
            new Point(675, 280),
            new Point(805, 280),
            new Point(935, 280)
        };
        int[] Arreglo_numeros;
        Button[] Arreglo;
        Button[] ArregloArbol;
        Numeros Datos = new Numeros();
        public frmHome()
        {
            InitializeComponent();
            rdbtnNumeros.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                Random myRandom = new Random();
                if (txtNumero.Text == String.Empty)
                {
                    if (rdbtnNumeros.Checked)
                    {
                        num = myRandom.Next(1, 99);
                        Datos.insertar_Dato(num, false);
                    }
                    else
                    {
                        num = myRandom.Next(65, 90);
                        Datos.insertar_Dato(num, true);
                    }
                }
                else
                {
                    if (rdbtnNumeros.Checked)
                    {
                        num = Convert.ToInt32(txtNumero.Text);
                        Datos.insertar_Dato(num, false);
                    }
                    else
                    {
                        num = Convert.ToInt32(txtNumero.Text.ToUpper().ToString()[0]);
                        Datos.insertar_Dato(num, true);
                    }
                }
                Arreglo_numeros = Datos.Obtener_Arreglo();
                Arreglo = Datos.Arreglo_BotonesArbol();
                ArregloArbol = Datos.Arreglo_Botones();
            }
            catch
            {
                MessageBox.Show("Solo se admiten numeros enteros");
            }
            estado = true;
            tabControlSimulacion.Refresh();
            if (Arreglo_numeros.Length == 16)
                btnAgregar.Enabled = false;
        }

        private void tabSimulacion_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                try
                {
                    Dibujar_Arreglo(ref Arreglo, ref tabSimulacion);
                    Dibujar_ArregloArbol(ref ArregloArbol, ref tabSimulacion);
                }
                catch
                {
                }
                estado = false;
                limpiar = false;
            }
        }

        public void Dibujar_ArregloArbol(ref Button[] Arreglo, ref TabPage tp1)
        {
            for (int i = 1; i < this.Arreglo.Length; i++)
            {
                this.Arreglo[i].Location = posicionBotones[i];
                if (limpiar)
                    tp1.Controls.Remove(this.Arreglo[i]);
                else
                    tp1.Controls.Add(this.Arreglo[i]);
                if (i >= 2)
                {
                    //Agregar lineas desde i hasta i-1
                }
            }
        }

        public void Dibujar_Arreglo(ref Button[] Arreglo, ref TabPage tp1)
        {
            for (int i = 1; i < Arreglo.Length; i++)
            {
                Arreglo[i].Location = new Point(40 * i + 20, 340);
                if (limpiar)
                    tp1.Controls.Remove(Arreglo[i]);
                else
                    tp1.Controls.Add(Arreglo[i]);
                if (i >= 2)
                {
                    //Agregar lineas desde i hasta i-1
                }
            }
        }
    }
}
