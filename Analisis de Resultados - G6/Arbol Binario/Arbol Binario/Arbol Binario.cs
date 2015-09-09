using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        //Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        //Constructor con parametros
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }

        //Funcion para calcular altura
        public int calcularAltura(Nodo_Arbol Raiz)
        {
            int h, h_aux;
            if (Raiz == null)
                return 0;
            h = 0;
            if (Raiz.Izquierdo != null)
                h = 1 + calcularAltura(Raiz.Izquierdo);
            if (Raiz.Derecho != null)
            {
                h_aux = 1 + calcularAltura(Raiz.Derecho);
                if (h_aux > h)
                    h = h_aux;
            }
            return h;
        }

        //Funcion para agregar un nuevo nodo (valor) al Arbol Binario
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
            }
        }

        //Funcion para ver si existe un nodo en el Arbol Binario
        public bool existe(int x, Nodo_Arbol Raiz)
        {
            Nodo_Arbol actual = Raiz;

            while (actual != null)
            {
                if (x == actual.info) return true;
                else if (x < actual.info) actual = actual.Izquierdo;
                else if (x > actual.info) actual = actual.Derecho;
            }
            return false;
        }

        //Funcion para eliminar un nodo (valor) del Arbol Binario
        public void Eliminar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
            }
            else
            {
                Raiz.Eliminar(x, ref Raiz);
            }
        }

        /*
         * 
         * Funciones para el dibujo del Arbol Binario en el Formulario
         * 
         * */
        //Funcion que dibuja el Arbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush
            RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400;            //Posiciones de la raiz del arbol
            int y = 75;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y);    //Posicion de cada nodo

            Raiz.DibujarRamas(grafo, Lapiz);    //Dibuja los Enlaces entre nodos

            //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }


        public int x1 = 400;    //Posiciones iniciales de la raiz del arbol
        public int y2 = 75;

        //Funcion para colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
    Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        //Funcion para hacer resaltar un nodo si es que existe
        public void resaltar(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
    Pen Lapiz, Nodo_Arbol Raiz, int x)
        {
            Nodo_Arbol actual = Raiz;
            Brush entorno = Brushes.Red;

            while (actual != null)
            {
                if (x == actual.info)
                {
                    actual.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    break;
                }
                else if (x < actual.info) actual = actual.Izquierdo;
                else if (x > actual.info) actual = actual.Derecho;
            }
        }

        //Funcion para calcular que nodo se ha tocado con el mouse
        public int seleccionar(Graphics grafo, Font fuente, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, Point Referencia)
        {
            Nodo_Arbol actual = Raiz;
            Brush entorno = Brushes.Red;

            while (actual != null)
            {
                int diferenciaX = Referencia.X - actual.nodo.X;
                int diferenciaY = Referencia.Y - actual.nodo.Y;

                if (diferenciaX > 0 && diferenciaX < 30 && diferenciaY > 0 && diferenciaY < 30)
                {
                    actual.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    return actual.info;
                }
                else if (diferenciaX > 0) actual = actual.Derecho;
                else if (diferenciaX < 0) actual = actual.Izquierdo;
            }
            return 100;
        }
    }
}
