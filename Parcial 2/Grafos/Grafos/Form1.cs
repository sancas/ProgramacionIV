﻿using System;
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
        private Recorrido ventanaRecorrido; // ventana para seleccionar el nodo inicial del recorrido
        private bool NoDigrafo; //Booleano para identificar si se habla de un Digrafo o no

        public Simulador()
        {
            InitializeComponent();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            ventanaRecorrido = new Recorrido();

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
            nuevoNodo = new CVertice(NoDigrafo);
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
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino)) //Se procede a crear la arista
                            {
                                int distancia = int.Parse(ventanaArco.txtArco.Text);
                                NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                                if (NoDigrafo)
                                    NodoDestino.ListaAdyacencia.Find(v => v.nDestino == NodoOrigen).peso = distancia;
                            }
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
                    if (NoDigrafo)
                    {
                        Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), NodoOrigen.Posicion, e.Location);
                    }
                    else
                    {
                        Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                        {
                            CustomEndCap = bigArrow
                        },
                            NodoOrigen.Posicion, e.Location);
                    }
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
                        CMSCrearVertice.Items.Add(eliminarNodoToolStripMenuItem);
                    }
                    else
                    {
                        CMSCrearVertice.Items.Remove(eliminarNodoToolStripMenuItem);
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                }
            }
        }

        private void eliminarNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NodoOrigen != null)
                grafo.EliminarVertice(NodoOrigen);
            NodoOrigen = null;
            Pizarra.Refresh();
        }

        private void btnCrearGrafo_Click(object sender, EventArgs e)
        {
            if (btnCrearGrafo.Text == "Nuevo grafo")
            {
                rbtnDiGrafo.Enabled = true;
                rbtnGrafoNoDirigido.Enabled = true;
                btnCrearGrafo.Text = "Crear grafo";
                rbtnDiGrafo.Checked = false;
                rbtnGrafoNoDirigido.Checked = false;
                grafo = null;
                Pizarra.Visible = false;
            }
            if (rbtnDiGrafo.Checked || rbtnGrafoNoDirigido.Checked)
            {
                rbtnDiGrafo.Enabled = false;
                rbtnGrafoNoDirigido.Enabled = false;
                btnCrearGrafo.Text = "Nuevo grafo";
                if (rbtnDiGrafo.Checked)
                {
                    grafo = new CGrafo();
                    NoDigrafo = false;
                }
                else
                {
                    grafo = new CGrafo(true);
                    NoDigrafo = true;
                }
                Pizarra.Visible = true;
            }
        }

        private void eliminarAristaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
