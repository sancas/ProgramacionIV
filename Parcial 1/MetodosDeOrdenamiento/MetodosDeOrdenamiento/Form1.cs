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
        bool estado = false;
        bool limpiar = false;
        int[] Arreglo_numeros;
        Button[] Arreglo;
        Numeros Datos = new Numeros();
        Button[] Arreglo_heap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnManual.Checked)
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
                }
                else
                {
                    if(txtArchivo.Text != String.Empty)
                    {
                        String NumerosLeidos = System.IO.File.ReadAllText(txtArchivo.Text);
                        String []NumerosArray = NumerosLeidos.Split(',');
                        foreach (string num in NumerosArray)
                        {
                            int num2;
                            if (rdbtnNumeros.Checked)
                            {
                                num2 = Convert.ToInt32(num);
                                Datos.insertar_Dato(num2, false);
                            }
                            else
                            {
                                num2 = Convert.ToInt32(num.ToUpper().ToString()[0]);
                                Datos.insertar_Dato(num2, true);
                            }
                        }
                    }
                }
                Arreglo_numeros = Datos.Obtener_Arreglo();
                Arreglo = Datos.Arreglo_Botones();
                Arreglo_heap = Datos.Arreglo_Botones_Heap();
                if (Arreglo_numeros.Length == 16 && cmbMetodos.Text == "HeapSort")
                    btnAgregar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Solo se admiten numeros enteros");
            }
            estado = true;
            tabPage1.Refresh();
            tabSimulacion.Refresh();
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

        //Metodo de Ordenamiento de MergeSort
        public void MergeSort(ref int[] input, int left, int right, ref Button[] Arreglo_Numeros)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(ref input, left, middle, ref Arreglo_Numeros);
                MergeSort(ref input, middle + 1, right, ref Arreglo_Numeros);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        intercambio(ref Arreglo_Numeros, k, leftArray.Length + j);
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        intercambio(ref Arreglo_Numeros, k, i + 1);
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    for (int t = 1; t < Arreglo_numeros.Length; t++)
                    {
                        if (rdbtnNumeros.Checked)
                            Arreglo[t].Text = Arreglo_numeros[t].ToString();
                        else
                            Arreglo[t].Text = Char.ConvertFromUtf32(Arreglo_numeros[t]).ToString();
                    }
                }
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

        public void Dibujar_ArregloArbol(ref Button[] Arreglo2, ref TabPage tp1)
        {
            for (int i = 1; i < Arreglo2.Length; i++)
            {
                Arreglo2[i].Location = posicionBotones[i];
                if (limpiar)
                    tp1.Controls.Remove(Arreglo2[i]);
                else
                    tp1.Controls.Add(Arreglo2[i]);
                if (i >= 2 && !limpiar)
                {
                    System.Drawing.Pen myPen;
                    myPen = new System.Drawing.Pen(System.Drawing.Color.Purple);
                    System.Drawing.Graphics formGraphics = tabSimulacion.CreateGraphics();
                    if(i%2==0)
                        formGraphics.DrawLine(myPen, posicionBotones[i/2].X+15, posicionBotones[i/2].Y+30, Arreglo2[i].Location.X+15, Arreglo2[i].Location.Y);
                    else
                        formGraphics.DrawLine(myPen, posicionBotones[(i - 1) / 2].X+15, posicionBotones[(i - 1) / 2].Y+30, Arreglo2[i].Location.X+15, Arreglo2[i].Location.Y);
                    myPen.Dispose();
                    formGraphics.Dispose();
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
                else if (cmbMetodos.SelectedItem.ToString() == "MergeSort")
                {
                    MergeSort(ref Arreglo_numeros, 1, Arreglo_numeros.Length - 1, ref Arreglo);
                }
                else if (cmbMetodos.SelectedItem.ToString() == "HeapSort")
                {
                    HeapSorter hs = new HeapSorter(ref Arreglo_numeros);
                    hs.ascendente = rdbtnAscendente.Checked;
                    hs.sortArray(ref Arreglo, ref Arreglo_heap);
                }
            }
            else
                MessageBox.Show("Seleccione un metodo de ordenamiento");
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
            boton[a].BackColor = Color.GreenYellow;
            boton[b].BackColor = Color.GreenYellow;
            estado = true;
            tabPage1.Refresh();
        }

        public void intercambioArbol(ref Button[] boton, int a, int b)
        {
            string temp = boton[a].Text;

            Point pa = boton[a].Location;
            Point pb = boton[b].Location;
            int diferenciax = pa.X - pb.X;
            int diferenciay = pa.Y - pb.Y;
            int x = 10;
            int y = 10;
            int t = 0;

            while (x <= diferenciax + 10)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(-1, 0);
                boton[b].Location += new Size(1, 0);
                x += 1;
            }

            while (y <= diferenciay + 10)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, -1);
                boton[b].Location += new Size(0, 1);
                y += 1;
            }

            boton[a].Text = boton[b].Text;
            boton[b].Text = temp;
            boton[b].Location = pb;
            boton[a].Location = pa;
            estado = true;
            tabSimulacion.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Datos.limpiar_Datos();
            limpiar = true;
            estado = true;
            Arreglo_numeros = Datos.Obtener_Arreglo();
            Arreglo = Datos.Arreglo_Botones();
            Arreglo_heap = Datos.Arreglo_Botones_Heap();
            tabPage1.Refresh();
            tabSimulacion.Refresh();
            limpiar = false;
        }

        private void rdbtnLetras_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
        }

        private void rdbtnExternFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnExternFile.Checked)
            {
                txtArchivo.Enabled = true;
                btnSeleccionarArchivo.Enabled = true;
                txtNumero.Enabled = false;
                lblExtraInfo.Visible = true;
                btnLimpiar.PerformClick();
            }
            else
            {
                txtArchivo.Enabled = false;
                btnSeleccionarArchivo.Enabled = false;
                txtNumero.Enabled = true;
                lblExtraInfo.Visible = false;
            }
        }

        private void cmbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodos.Text == "HeapSort")
            {
                tabSimulacionHeapsort.Visible = true;
                Form1.ActiveForm.Height = 625;
            }
            else
            {
                tabSimulacionHeapsort.Visible = false;
                Form1.ActiveForm.Height = 265;
            }
            btnLimpiar.PerformClick();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asegurese de haber seleccionado numeros o letras segun corresponda y el metodo de ordenamiento deseado");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtArchivo.Text = openFileDialog1.FileName;
            }
        }

        private void tabSimulacion_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Point xy = new Point(30, 30);

                try
                {
                    Dibujar_ArregloArbol(ref Arreglo_heap, ref tabSimulacion);
                }
                catch
                {
                }
            }
        }
    }
}
