using System;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Grafo
{
    public partial class Simulador : MetroForm
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
        private BuscarNodo ventanaBuscarNodo; //ventana para buscar un nodo
        private SaveFileDialog VentanaGuardar; //Ventana para seleccionar donde guardar el grafo
        private OpenFileDialog VentanaCargar; //Ventana para seleccionar el grafo a cargar
        private int tiempo = 1000; //Tiempo para la simulacion


        public Simulador()
        {
            InitializeComponent();
            this.StyleManager = SimuladorStyleManager;
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            ventanaBuscarNodo = new BuscarNodo();
            VentanaGuardar = new SaveFileDialog();
            VentanaCargar = new OpenFileDialog();
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
                MetroMessageBox.Show(this, ex.Message);
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
                    ventanaVertice.ShowDialog();
                    if (ventanaVertice.control)
                    {
                        grafo.AgregarVertice(nuevoNodo);
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El Nodo " + ventanaVertice.txtVertice.Text + " ya existe en el grafo ", "Error nuevo Nodo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            grafo.EliminarVertice(nuevoNodo);
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

        private void buscarNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaBuscarNodo.Visible = false;
            ventanaBuscarNodo.control = false;
            ventanaBuscarNodo.ShowDialog();
            if (ventanaBuscarNodo.control)
            {
                if (grafo.BuscarVertice(ventanaBuscarNodo.txtVertice.Text) != null)
                {
                    grafo.Colorear(grafo.BuscarVertice(ventanaBuscarNodo.txtVertice.Text));
                    Pizarra.Refresh();
                    Thread.Sleep(tiempo);
                    grafo.ReestablecerGrafo(Pizarra.CreateGraphics());
                    Pizarra.Refresh();
                }
                else
                    MetroMessageBox.Show(this, "El nodo no existe", "Error Nodo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void guardarGrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndLoad mySave = new SaveAndLoad(); //Instancia de objeto SaveAndLoad

            VentanaGuardar.InitialDirectory = "c:\\"; //Directorio inicial para el SaveDialog
            VentanaGuardar.Filter = "graph files (*.graph)|*.graph"; //Filtro de archivos
            VentanaGuardar.FilterIndex = 2; //Indice del filtr
            VentanaGuardar.RestoreDirectory = true; //Volver a abrir donde se cerro

            DialogResult result = VentanaGuardar.ShowDialog(); //Mostrar la ventana de guardado
            if (result == DialogResult.OK) // Si fue satisfactorio
            {
                string file = VentanaGuardar.FileName; //Guardamosla direccion del archivo
                mySave.WriteToBinaryFile<CGrafo>(file, grafo, false); //Guardamos un archivo .graph
                // en la direccion que cotiene un objeto tipo CGrafo en binario
            }
        }

        private void cargarGrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndLoad myLoad = new SaveAndLoad(); //Instancia de objeto SaveAndLoad

            VentanaCargar.InitialDirectory = "c:\\"; //Directorio inicial para el LoadDialog
            VentanaCargar.Filter = "graph files (*.graph)|*.graph"; //Filtro de archivos
            VentanaCargar.FilterIndex = 2; //Indice del filtro
            VentanaCargar.RestoreDirectory = true; //Volver a abrir donde se cerro

            DialogResult result = VentanaCargar.ShowDialog(); //Mostrar la ventana para cargar
            if (result == DialogResult.OK) // Si fue satisfactorio
            {
                string file;
                file = VentanaCargar.FileName; //Guardamos la direccion del archivo
                grafo = myLoad.ReadFromBinaryFile<CGrafo>(file); //Convertimos de binario a CGrafo con la clase SaveAndLoad
                if (grafo.Background != null)
                    Pizarra.BackgroundImage = grafo.Background;
                grafo.DibujarGrafo(Pizarra.CreateGraphics()); //Dibujamos el grafo cargado en el Canvas
            }
        }

        private void cargarFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndLoad myLoad = new SaveAndLoad(); //Instancia de objeto SaveAndLoad

            VentanaCargar.InitialDirectory = "c:\\"; //Directorio inicial para el LoadDialog
            VentanaCargar.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*"; //Filtro de archivos
            VentanaCargar.FilterIndex = 2; //Indice del filtro
            VentanaCargar.RestoreDirectory = true; //Volver a abrir donde se cerro

            DialogResult result = VentanaCargar.ShowDialog(); //Mostrar la ventana para cargar
            if (result == DialogResult.OK) // Si fue satisfactorio
            {
                string file;
                file = VentanaCargar.FileName; //Guardamos la direccion del archivo
                grafo.Background = (Bitmap) Image.FromFile(VentanaCargar.FileName); //Guardamos la imagen en el grafo
                Pizarra.BackgroundImage = grafo.Background; //Ponemos de fondo la imagen
            }
        }

        private void recorridoProfundidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grafo.BuscarVertice("LA") != null) //Si el grafo seleccionado se encuentra
            {
                RecorridoProfundidad(grafo.BuscarVertice("LA"));
            }
            else //Sino error
            {
                MessageBox.Show("LA no se encuentra en el grafo", "Error Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            grafo.ReestablecerGrafo(Pizarra.CreateGraphics()); //Se reestablece el grafo
            Pizarra.Refresh(); //Se refresca el canvas
        }


        /*****************************************************************************/
        /*                                 ALGORITMOS                                */
        /*****************************************************************************/
        //Recorrido en anchura
        private Queue<Label> c = new Queue<Label>();
        private void RecorridoAnchura(CVertice nodo)
        {
            CVertice temp = new CVertice();
            nodo.Visitado = true;
            Queue<CVertice> cola = new Queue<CVertice>();
            cola.Enqueue(nodo);
            grafo.Colorear(nodo);
            Pizarra.Refresh();
            Thread.Sleep(tiempo);
            while (cola.Count != 0)
            {
                temp = cola.Dequeue();
                foreach (CArco arco in temp.ListaAdyacencia)
                {
                    if (arco.nDestino.Visitado == false)
                    {
                        cola.Enqueue(arco.nDestino);
                    }
                }
                foreach (CArco arco in temp.ListaAdyacencia)
                {
                    if (arco.nDestino.Visitado == false)
                    {
                        arco.nDestino.Visitado = true;
                        grafo.Colorear(arco.nDestino);
                        Pizarra.Refresh();
                        Thread.Sleep(tiempo);
                    }
                }

            }
        }
        //recorrido en Profundidad
        private Stack<Label> Pila = new Stack<Label>();
        private void RecorridoProfundidad(CVertice nodo)
        {
            CVertice temp = new CVertice();
            Stack<CVertice> pila = new Stack<CVertice>();
            pila.Push(nodo);
            while (pila.Count != 0)
            {
                temp = pila.Pop();
                if (temp.Visitado == false)
                {
                    temp.Visitado = true;
                    grafo.Colorear(temp);
                    Pizarra.Refresh();
                    Thread.Sleep(tiempo);
                    foreach (CArco arco in temp.ListaAdyacencia)
                    {
                        pila.Push(arco.nDestino);
                    }
                }
            }
        }
    }
}
