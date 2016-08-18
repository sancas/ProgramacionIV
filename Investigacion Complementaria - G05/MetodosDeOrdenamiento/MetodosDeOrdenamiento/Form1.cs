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
        bool limpiar = false;
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
                if (cmbMetodos.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un metodo de ordenamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int num;
                    Random myRandom = new Random();
                    if (txtNumero.Text == String.Empty)
                    {
                        num = myRandom.Next(1, 99);
                        Datos.insertar_Dato(num);
                    }
                    else
                    {
                        num = Convert.ToInt32(txtNumero.Text);
                        if (num > 99)
                        {
                            MessageBox.Show("Se recomienda ingresar solamente numeros de 2 digitos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Datos.insertar_Dato(num);
                    }
                    Arreglo_numeros = Datos.Obtener_Arreglo();
                    Arreglo = Datos.Arreglo_Botones();
                }
            }
            catch
            {
                MessageBox.Show("No se admiten numeros tan grandes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estado = true;
            tabPage1.Refresh();
            estado = false;
            limpiar = false;
        }

        //Metodo de ordenamiento QuickSort
        public void QuickSort(ref int[] arreglo, int primero, int ultimo, ref Button[] Arreglo_Numeros)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = arreglo[central];
            i = primero;
            j = ultimo;
            do
            {
                if (rdbtnAscendente.Checked)
                {
                    while (arreglo[i] < pivote) i++;
                    while (arreglo[j] > pivote) j--;
                }
                else if (rdbtnDescendente.Checked)
                {
                    while (arreglo[i] > pivote) i++;
                    while (arreglo[j] < pivote) j--;
                }
                if (i <= j)
                {
                    int temp;
                    temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    intercambio(ref Arreglo_Numeros, j, i);
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (primero < j)
            {
                QuickSort(ref arreglo, primero, j, ref Arreglo_Numeros);
            }
            if (i < ultimo)
            {
                QuickSort(ref arreglo, i, ultimo, ref Arreglo_Numeros);
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
                    if (rdbtnAscendente.Checked)
                    {
                        if (arreglo[j] < arreglo[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                    else if (rdbtnDescendente.Checked)
                    {
                        if (arreglo[j] > arreglo[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                }
                if (pos_min != i)
                {
                    temp = arreglo[i];
                    arreglo[i] = arreglo[pos_min];
                    arreglo[pos_min] = temp;
                    intercambio(ref Arreglo_Numeros, pos_min, i);
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

                if (rdbtnAscendente.Checked)
                {
                    while ((j >= 1) && (arreglo[j] > temp))
                    {
                        arreglo[j + 1] = arreglo[j];
                        intercambio(ref Arreglo_Numeros, j + 1, j);
                        j--;
                    }
                }
                else if (rdbtnDescendente.Checked)
                {
                    while ((j >= 1) && (arreglo[j] < temp))
                    {
                        arreglo[j + 1] = arreglo[j];
                        intercambio(ref Arreglo_Numeros, j + 1, j);
                        j--;
                    }
                }
                
                arreglo[j + 1] = temp;
            }
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Point xy = new Point(30, 35);

                try
                {
                    Dibujar_Arreglo(ref Arreglo, xy, ref tabPage1);
                }
                catch
                {
                }
            }
        }

        public void Dibujar_Arreglo(ref Button[] Arreglo, Point xy, ref TabPage tp1)
        {
            for (int i = 1; i < Arreglo.Length; i++)
            {
                Arreglo[i].Location = xy;
                if (limpiar)
                    tp1.Controls.Remove(Arreglo[i]);
                else
                    tp1.Controls.Add(Arreglo[i]);               
                xy += new Size(40, 0);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Stopwatch miReloj = new Stopwatch();
            miReloj.Restart();
            this.Cursor = Cursors.WaitCursor;
            btnOrdenar.Enabled = false;
            btnAgregar.Enabled = false;
            cmbMetodos.Enabled = false;

            if (cmbMetodos.SelectedIndex != -1)
            {
                if (cmbMetodos.SelectedItem.ToString() == "QuickSort")
                    QuickSort(ref Arreglo_numeros, 1, Arreglo_numeros.Length - 1, ref Arreglo);
                else if (cmbMetodos.SelectedItem.ToString() == "SelectionSort")
                    SelectionSort(ref Arreglo_numeros, ref Arreglo);
                else if (cmbMetodos.SelectedItem.ToString() == "InsertionSort")
                    InsertionSort(ref Arreglo_numeros, ref Arreglo);
            }
            else
                MessageBox.Show("Seleccione un metodo de ordenamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Cursor = Cursors.Default;
            btnOrdenar.Enabled = true;
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

            while (y != 40)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, 10);
                boton[b].Location += new Size(0, -10);
                y += 10;
            }

            while (x != diferencia + 10)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(-10, 0);
                boton[b].Location += new Size(10, 0);
                x += 10;
            }

            y = 0;

            while(y != -30)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Datos.limpiar_Datos();
            limpiar = true;
            estado = true;
            tabPage1.Refresh();
            Arreglo_numeros = Datos.Obtener_Arreglo();
            Arreglo = Datos.Arreglo_Botones();
            limpiar = false;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != String.Empty)
            {
                try
                {
                    int num;
                    num = Convert.ToInt32(txtNumero.Text);
                    if (num > 99)
                    {
                        txtNumero.BackColor = Color.Orange;
                    }
                    else
                    {
                        txtNumero.BackColor = Color.Green;
                    }
                }
                catch
                {
                    MessageBox.Show("No se admiten numeros tan grandes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.BackColor = Color.Red;
                }
            }
            else
                txtNumero.BackColor = Color.Green;
        }
    }
}
