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
            if (inor == true) //Si es recorrido en orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquiero
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se vuelve a colorear la raiz
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                }
            }
            else if (preor == true) //Si es recorrido pre orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se colorea la raiz 
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquierdo
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                }
            }
            else if (post == true) //Si es recorrido post orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquiero
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se colorea la raiz
                }
            }
        }

        //Funcion para hacer resaltar un nodo si es que existe
        public void resaltar(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
    Pen Lapiz, Nodo_Arbol Raiz, int x)
        {
            Nodo_Arbol actual = Raiz;
            Brush entorno = Brushes.Red;

            while (actual != null) //Mientras el nodo actual no sea null
            {
                if (x == actual.info) //Si el valor del nodo raiz es igual al actual
                {
                    actual.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se resalta el nodo coloreandolo
                    break;
                }
                else if (x < actual.info) actual = actual.Izquierdo;
                else if (x > actual.info) actual = actual.Derecho;
            }
        }

        //Funcion para calcular que nodo se ha tocado con el mouse y resaltarlo, regresa el valor del nodo
        public int seleccionar(Graphics grafo, Font fuente, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, Point Referencia)
        {
            Nodo_Arbol actual = Raiz;
            Brush entorno = Brushes.Red;

            while (actual != null) //Mientras el nodo actual no sea null
            {
                int diferenciaX = Referencia.X - actual.nodo.X; //Diferencia en X entre el puntero y el nodo actual
                int diferenciaY = Referencia.Y - actual.nodo.Y; //Diferencia en Y entre el puntero y el nodo actual

                if (diferenciaX > 0 && diferenciaX < 30 && diferenciaY > 0 && diferenciaY < 30) //0>x<30 y 0>y<30 Si el puntero esta a 30 px maximo del nodo
                {
                    actual.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea el nodo actual
                    return actual.info; //Se regresa el valor del nodo
                }
                else if (diferenciaX > 0) actual = actual.Derecho; //Si la diferencia en 'x' es mayor a 0 actual es el nodo derecho
                else if (diferenciaX < 0) actual = actual.Izquierdo; //Si la difrencia en 'x' es menor a 0 actual es el nodo izquierdo
            }
            return 100;
        }

        /*
         * 
         * Funciones para la sumataria de valores del arbol
         * 
         * */
        //Funcion que suma los valores del arbol con un modulo especifico
        public void sumar(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
    Pen Lapiz, Nodo_Arbol Raiz, int modulo)
        {
            Nodo_Arbol actual = Raiz;
            Brush entorno = Brushes.Red;
            frmPrincipal myForm = new frmPrincipal();

            if (Raiz != null)
            {
                sumar(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, modulo);
                if(Raiz.info%modulo == 0)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                }
                sumar(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, modulo);
            }
        }
    }
}
