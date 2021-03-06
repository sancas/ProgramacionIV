﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Grafos
{
    class CGrafo
    {
        public List<CVertice> nodos; // Lista de nodos del grafo
        private bool NoDigrafo;
        public CGrafo() // Constructor
        {
            nodos = new List<CVertice>();
        }
        public CGrafo(bool NoDigrafo)
        {
            nodos = new List<CVertice>();
            this.NoDigrafo = true;
        }
        //=====================Operaciones Básicas=================================
        //Construye un nodo a partir de su valor y lo agrega a la lista de nodos
        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor, NoDigrafo);
            nodos.Add(nodo);
            return nodo;
        }
        //Agrega un nodo a la lista de nodos del grafo
        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }
        //Busca un nodo en la lista de nodos del grafo
        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }
        //Crea una arista a partir de los valores de los nodos de origen y de destino
        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;

            //Si alguno de los nodos no existe, se activa una excepción
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
            return AgregarArco(vOrigen, vnDestino, peso);
        }
        // Crea la arista a partir de los nodos de origen y de destino
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                if (this.NoDigrafo)
                {
                    origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                    nDestino.ListaAdyacencia.Add(new CArco(origen, peso));
                }
                else
                {
                    origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                }
                return true;
            }
            return false;
        }
        //Eliminar la arista a partir del valor del nodo origin, destino y peso
        public bool EliminarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) != null)
            {
                if (this.NoDigrafo)
                {
                    origen.ListaAdyacencia.Remove(new CArco(nDestino, peso));
                    nDestino.ListaAdyacencia.Remove(new CArco(origen, peso));
                }
                else
                {
                    origen.ListaAdyacencia.Remove(new CArco(nDestino, peso));
                }
                return true;
            }
            return false;
        }
        //Eliminar la arista a partir del valor del nodo origen, destino y peso
        public bool EliminarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;

            //Si alguno de los nodos no existe, se activa una excepción
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
            return EliminarArco(vOrigen, vnDestino, peso);
        }
        // Método para dibujar el grafo
        public void DibujarGrafo(Graphics g)
        {
            // Dibujando los arcos
            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g);

            // Dibujando los vértices
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);
        }
        // Método para detectar si se ha posicionado sobre algún nodo y lo devuelve
        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse)) return nodoActual;
            return null;
        }
        // Método para regresar al estado original
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }
        //Metodo para eliminar un nodo desde un valor string
        public void EliminarVertice(string valor)
        {
            if (BuscarVertice(valor) != null)
            {
                nodos.Remove(BuscarVertice(valor));
            }
        }
        //Metodo para eliminar un nodo desde el valor CVertice
        public void EliminarVertice(CVertice nodo)
        {
            nodos.Remove(nodo);
        }
    }
}