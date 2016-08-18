using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace MetodosDeOrdenamiento
{
    public partial class Form1 : Form
    {
        bool estado = false;
        int[] Arreglo_numeros;
        Button[] Arreglo;
        Numeros Datos = new Numeros();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                Datos.insertar_Dato(num);
                Arreglo_numeros = Datos.Obtener_Arreglo();
                Arreglo = Datos.Arreglo_Botones();
            }
            catch
            {
                MessageBox.Show("Solo se admiten numeros enteros");
            }
            estado = true;
            tabPage1.Refresh();
        }
        
        //Metodo de Ordenamiento Burbuja
        public void BubbleSort(ref int[] arreglo, ref Button[] Arreglo_Numeros)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if(arreglo[j] > arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                        intercambio(ref Arreglo_Numeros, j + 1, j);
                    }
                }
            }
        }

        //Metodo de Ordenamiento por Seleccion
        public void SelectionSort(ref int[] arreglo, ref Button[] Arreglo_Numeros)
        {
            int pos_min, temp;
            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[pos_min])
                    {
                        pos_min = j;
                    }
                }
                if (pos_min != i)
                {
                    temp = arreglo[i];
                    arreglo[i] = arreglo[pos_min];
                    arreglo[pos_min] = temp;
                    intercambio(ref Arreglo_Numeros, i, pos_min);
                }
            }
        }

        //Metodo de Ordenamiento por Insercion
        public void InsertionSort(ref int[] arreglo, ref Button[] Arreglo_Numeros)
        {
            for (int i = 1; i < arreglo.Length; i++)
            {
                int temp = arreglo[i];
                int j = i - 1;

                while ((j >= 1) && (arreglo[j] > temp))
                {
                    arreglo[j + 1] = arreglo[j];
                    intercambio(ref Arreglo_Numeros, j, j + 1);
                    j--;
                }
                arreglo[j + 1] = temp;
            }
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Point xy = new Point(50, 70);

                try
                {
                    Dibujar_Arreglo(ref Arreglo, xy, ref tabPage1);
                }
                catch
                {
                }
                estado = false;
            }
        }

        public void Dibujar_Arreglo(ref Button[] Arreglo, Point xy, ref TabPage tp1)
        {
            for (int i = 1; i < Arreglo.Length; i++)
            {
                Arreglo[i].Location = xy;
                tp1.Controls.Add(Arreglo[i]);
                xy += new Size(70, 0);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Stopwatch miReloj = new Stopwatch();
            miReloj.Restart();
            this.Cursor = Cursors.WaitCursor;
            btnOrdenar.Enabled = false;
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;
            cmbMetodos.Enabled = false;

            if (cmbMetodos.SelectedItem == "Burbujas")
                BubbleSort(ref Arreglo_numeros, ref Arreglo);
            else if (cmbMetodos.SelectedItem == "Insercion")
                InsertionSort(ref Arreglo_numeros, ref Arreglo);
            else if (cmbMetodos.SelectedItem == "Seleccion")
                SelectionSort(ref Arreglo_numeros, ref Arreglo);
            else
                MessageBox.Show("Seleccione un metodo de ordenamiento");

            this.Cursor = Cursors.Default;
            btnOrdenar.Enabled = true;
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;
            cmbMetodos.Enabled = true;
            miReloj.Stop();
            lblTiempo.Text = "Tiempo de ejecucion: " + miReloj.Elapsed.TotalSeconds.ToString().Substring(0, 4) + "s";
            lblTiempo.Visible = true;
        }

        public void intercambio(ref Button[] boton, int a, int b)
        {
            string temp = boton[a].Text;

            Point pa = boton[a].Location;
            Point pb = boton[b].Location;
            int diferencia = pa.X - pb.X;
            int x = 10;
            int y = 10;
            int t = 70;

            while (y != 70)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, 10);
                boton[b].Location += new Size(0, -10);
                y += 10;
            }

            y = 0;

            while(y != -60)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, -10);
                boton[b].Location += new Size(0, +10);
                y -= 10;
            }

            boton[a].Text = boton[b].Text;
            boton[b].Text = temp;
            boton[b].Location = pb;
            boton[a].Location = pa;
            estado = true;
            tabPage1.Refresh();
        }
    }
}
