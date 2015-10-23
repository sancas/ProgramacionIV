using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Simulador : Form
    {
        private CGrafo grafo; // instanciamos la clase CGrafo
        private CVertice nuevoNodo; // instanciamos la clase CVertice
        private CVertice NodoOrigen; // instanciamos la clase CVertice
        private CVertice NodoDestino; // instanciamos la clase CVertice
        private int var_control = 0; // la utilizaremos para determinar el estado en la pizarra:
        // 0 -> sin acción, 1 -> Dibujando arco, 2 -> Nuevo vértice
        // variables para el control de ventanas modales
        private Vertice ventanaVertice; // ventana para agregar los vértices
        private Arco ventanaArco; // ventana para agregar los arcos
        private Dijkstra algoritmoDijkstra; // instanciamos la clase Dijkstra
        private NodoDijkstra nodoDijkstra; // ventana para elegir el nodo inicial
        private FloydWarshall algoritmoFloydWarshall; //instanciamos la clase FloydWarshall
        private NodoFloydWarshall nodoFloydWarshall; //ventana para caminos por FloydWarshall

        public Simulador()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void nuevoVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoNodo = new CVertice();
            var_control = 2; // recordemos que es usado para indicar el estado en la pizarra: 0 ->
            // sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice

        }

        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 2: //Creando nuevo nodo
                    if (nuevoNodo != null)
                    {
                        int posX = e.Location.X;
                        int posY = e.Location.Y;
                        if (posX < nuevoNodo.Dimensiones.Width / 2)
                            posX = nuevoNodo.Dimensiones.Width / 2;
                        else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;
                        if (posY < nuevoNodo.Dimensiones.Height / 2)
                            posY = nuevoNodo.Dimensiones.Height / 2;
                        else if (posY > Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                            posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;
                        nuevoNodo.Posicion = new Point(posX, posY);
                        Pizarra.Refresh();
                        nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
                    }
                    break;
                case 1: // Dibujar arco
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    Pizarra.Refresh();
                    Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                    {
                        CustomEndCap = bigArrow
                    },
                        NodoOrigen.Posicion, e.Location);
                    break;
            }
        }

        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) // Si se ha presionado el botón
            // izquierdo del mouse
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                {
                    var_control = 1; // recordemos que es usado para indicar el estado en la pizarra:
                    // 0 -> sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice
                }
                if (nuevoNodo != null && NodoOrigen == null)
                {
                    ventanaVertice.Visible = false;
                    ventanaVertice.control = false;
                    grafo.AgregarVertice(nuevoNodo);
                    ventanaVertice.ShowDialog();
                    if (ventanaVertice.control)
                    {
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                        }
                        else
                        {
                            MessageBox.Show("El Nodo " + ventanaVertice.txtVertice.Text + " ya existe en el grafo ", "Error nuevo Nodo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //grafo.EliminarVertice(nuevoNodo);
                        }
                    }
                    nuevoNodo = null;
                    var_control = 0;
                    Pizarra.Refresh();
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right) // Si se ha presionado el botón
            // derecho del mouse
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                }
            }
        }

        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1: // Dibujando arco
                    ventanaArco.Visible = false;
                    ventanaArco.control = false;
                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        ventanaArco.ShowDialog();
                        if (ventanaArco.control)
                        {
                            int distancia = int.Parse(ventanaArco.txtArco.Text);
                            grafo.AgregarArco(NodoOrigen, NodoDestino, distancia);
                        }
                    }
                    var_control = 0;
                    NodoOrigen = null;
                    NodoDestino = null;
                    Pizarra.Refresh();
                    break;
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.ImprimirMatriz());
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            nodoDijkstra = new NodoDijkstra();
            nodoDijkstra.cmbNodoDijkstra.Items.AddRange(grafo.ArregloNodos());
            nodoDijkstra.ShowDialog();
            if(nodoDijkstra.control)
            {
                //MessageBox.Show(nodoDijkstra.cmbNodoDijkstra.SelectedIndex.ToString());
                string miCadena = String.Empty;
                algoritmoDijkstra = new Dijkstra(grafo, nodoDijkstra.cmbNodoDijkstra.SelectedIndex);
                MessageBox.Show(algoritmoDijkstra.CorrerDijkstra(grafo));
                miCadena = "La solucion de la ruta mas corta tomando como nodo inicial el NODO " + nodoDijkstra.cmbNodoDijkstra.Text + " es: \n";
                int nodos = 0;
                foreach (int i in algoritmoDijkstra.D)
                {
                    miCadena += "Distancia minima a nodo " + grafo.ArregloDeNodos()[nodos].ToString() + " es: " + i + "\n";
                    nodos++;
                }
                MessageBox.Show(miCadena);
            }
            algoritmoDijkstra = null;
        }

        private void btnFloydWarshall_Click(object sender, EventArgs e)
        {
            nodoFloydWarshall = new NodoFloydWarshall();
            nodoFloydWarshall.cmbNodoInicial.Items.AddRange(grafo.ArregloNodos());
            nodoFloydWarshall.cmbNodoFinal.Items.AddRange(grafo.ArregloNodos());
            nodoFloydWarshall.ShowDialog();
            if (nodoFloydWarshall.control)
            {
                int[,] matrizFloydWarshall;
                int peso = int.MaxValue;
                string miCadena = String.Empty;
                algoritmoFloydWarshall = new FloydWarshall();
                matrizFloydWarshall = algoritmoFloydWarshall.CorrerFloydWarshall(grafo.MatrizAdyacenciaFloyd(), grafo.nodos.GetLength(0) - 1);
                miCadena = "La ruta mas corta desde: " + nodoFloydWarshall.cmbNodoInicial.Text + " hasta: " + nodoFloydWarshall.cmbNodoFinal.Text + " es: \n";
                peso = matrizFloydWarshall[nodoFloydWarshall.cmbNodoInicial.SelectedIndex, nodoFloydWarshall.cmbNodoFinal.SelectedIndex];
                miCadena += peso.ToString();
                if (peso > 99999)
                    MessageBox.Show("No existe un camino que cumpla esos requisitos.");
                else
                    MessageBox.Show(miCadena);
            }
            algoritmoFloydWarshall = null;
        }
    }
}
