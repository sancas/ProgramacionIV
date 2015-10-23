using System;
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
        //public List<CVertice> nodos; // Lista de nodos del grafo
        public Object [ , ] nodos;
        private int cantNodos = 1;
        public CGrafo() // Constructor
        {
            //nodos = new List<CVertice>();
            nodos = new Object[cantNodos, cantNodos];
        }
        public CGrafo(string valor)
        {
            nodos = new Object[cantNodos, cantNodos];
            AgregarVertice(valor);
        }
        //=====================Operaciones Básicas=================================
        //Metodo para multidimensionar la matriz
        private static Array ResizeArray(Object [ , ] arr, int newSizes)
        {
            //var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            Object[,] temp = new Object[newSizes, newSizes];
            for (int x = 0; x < arr.GetLongLength(0); x++)
            {
                for (int j = 0; j < arr.GetLongLength(0); j++)
                {
                    temp[x, j] = arr[x, j];
                }
            }
            //int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            //Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }   
        //Construye un nodo a partir de su valor y lo agrega a la lista de nodos
        public CVertice AgregarVertice(string valor)
        {
            nodos = (Object[,])ResizeArray(nodos, cantNodos + 1);
            CVertice nodo = new CVertice(valor);
            nodos[cantNodos, 0] = nodo;
            for (int x = 1; x <= cantNodos; x++)
            {
                nodos[cantNodos, x] = -1;
                nodos[x, cantNodos] = -1;
            }
            nodos[0, cantNodos] = nodo;
            cantNodos++;
            return nodo;
        }
        //Agrega un nodo a la lista de nodos del grafo
        public void AgregarVertice(CVertice nuevonodo)
        {            
            nodos = (Object[,])ResizeArray(nodos, cantNodos + 1);
            nodos[cantNodos, 0] = nuevonodo;
            for (int x = 1; x <= cantNodos; x++)
            {
                nodos[cantNodos, x] = -1;
                nodos[x, cantNodos] = -1;
            }
            nodos[0, cantNodos] = nuevonodo;
            cantNodos++;
        }
        /*/Elimina un nodo de la lista de nodos del grafo
        public void EliminarVertice(CVertice nodo)
        {
            nodos.Remove(nodo);
        }
        //Busca un nodo en la lista de nodos del grafo*/
        public CVertice BuscarVertice(string valor)
        {
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice miNodo = (CVertice)nodos[0, x];
                if (miNodo != null)
                {
                    if (miNodo.Valor == valor)
                        return miNodo;
                }
            }
            return null;
            //int contador = 0;
            //foreach (CVertice nodo in nodos)
            //{
            //    if (contador == cantNodos - 1)
            //        break;
            //    if (nodo != null)
            //    {
            //        if (nodo.Valor == valor)
            //            return nodo;
            //    }
            //    contador++;
            //}
            //return null;
        }
        //Crea una arista a partir de los valores de los nodos de origen y de destino
        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen = null, vnDestino = null;

            /*/Si alguno de los nodos no existe, se activa una excepción
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo"); */
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice nodoOrigen = (CVertice)nodos[0, x];
                if (nodoOrigen != null)
                {
                    if (nodoOrigen.Valor == origen)
                    {
                        vOrigen = nodoOrigen;
                        break;
                    }
                    if (x == nodos.GetLength(0) - 1)
                    {
                        throw new Exception("El nodo " + origen + " no existe dentro del grafo");
                    }
                }
            }
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice nodoDestino = (CVertice)nodos[0, x];
                if (nodoDestino != null)
                {
                    if (nodoDestino.Valor == nDestino)
                    {
                        vnDestino = nodoDestino;
                        break;
                    }
                    if (x == nodos.GetLength(0) - 1)
                    {
                        throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
                    }
                }
            }
            //int contador = 0;
            //foreach (CVertice nodoOrigen in nodos)
            //{
            //    if (nodoOrigen != null)
            //    {
            //        if (nodoOrigen.Valor == origen)
            //        {
            //            vOrigen = nodoOrigen;
            //            break;
            //        }
            //    }
            //    if (contador == cantNodos - 1)
            //        throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            //    contador++;
            //}
            //contador = 0;
            //foreach (CVertice nodoDestino in nodos)
            //{
            //    if (nodoDestino != null)
            //    {
            //        if (nodoDestino.Valor == origen)
            //        {
            //            vnDestino = nodoDestino;
            //            break;
            //        }
            //    }
            //    if (contador == cantNodos - 1)
            //        throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
            //    contador++;
            //}
            return AgregarArco(vOrigen, vnDestino, peso);
        }
        // Crea la arista a partir de los nodos de origen y de destino
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {            
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                int index1 = 0, index2 = 0; //Variables para guardar los indices
                for (int x = 1; x < cantNodos; x++)
                {
                    if (nodos[0, x] == origen) //Si el nodo origen es igual a alguno de los nodos en la matriz
                        index1 = x; //Guardar el indice
                    if (nodos[x, 0] == nDestino) //Si el nodo destino es igual a alguno de los nodos de la matriz
                        index2 = x; //Guardar el indice
                }
                nodos[index1, index2] = peso; //Asociar el peso a esos indices de la matriz
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }
        // Método para dibujar el grafo
        public void DibujarGrafo(Graphics g)
        {
            /*/ Dibujando los arcos
            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g); */
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice miNodo = (CVertice)nodos[0, x];
                if (miNodo != null)
                {
                    miNodo.DibujarArco(g);
                }
            }
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice miNodo = (CVertice)nodos[0, x];
                if (miNodo != null)
                {
                    miNodo.DibujarVertice(g);
                }
            }
            //int contador = 0; 
            //foreach (CVertice nodo in nodos)
            //{
            //    if (nodo != null)
            //    {
            //        nodo.DibujarArco(g);
            //    }
            //    if (contador == cantNodos - 1)
            //        break;
            //    contador++;
            //}
            /* Dibujando los vértices
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g); */
            //contador = 0;
            //foreach (CVertice nodo in nodos)
            //{
            //    if (nodo != null)
            //    {
            //        nodo.DibujarVertice(g);
            //    }
            //    if (contador == cantNodos - 1)
            //        break;
            //    contador++;
            //}
        }
        // Método para detectar si se ha posicionado sobre algún nodo y lo devuelve
        public CVertice DetectarPunto(Point posicionMouse)
        {
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice miNodo = (CVertice)nodos[0, x];
                if (miNodo != null)
                {
                    if (miNodo.DetectarPunto(posicionMouse))
                    {
                        return miNodo;
                    }
                }
            }
            /*
            int contador = 0;
            foreach (CVertice nodo in nodos)
            {
                if (contador == cantNodos - 1)
                    break;
                if (nodo != null)
                {
                    if (nodo.DetectarPunto(posicionMouse))
                        return nodo;
                }
                contador++;
            } */
            return null;
        }
        /*/ Método para regresar al estado original
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                if (nodo != null)
                {
                    nodo.Color = Color.White;
                    nodo.FontColor = Color.Black;
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        arco.grosor_flecha = 1;
                        arco.color = Color.Black;
                    }
                }
            }
            DibujarGrafo(g);
        }*/
        //Metodo que regresa un string con la matriz
        public string ImprimirMatriz()
        {
            string myString = "";
            int x = 0;
            int y = 0;
            for (x = 1; x < cantNodos; x++)
            {
                for (y = 1; y < cantNodos; y++)
                {
                    myString += String.Format("\nnodos[{0} , {1}] = [{2}]", x, y, nodos[x , y]);
                }
            }
            return myString;
        }
        //Metodo que me genera la matriz de adyacencia de los nodos
        public int[,] MatrizAdyacencia()
        {
            int[,] matriz = new int[cantNodos - 1, cantNodos - 1];
            for (int x = 1; x < cantNodos; x++)
            {
                for (int y = 1; y < cantNodos; y++)
                {
                    matriz[x - 1, y - 1] = (int)nodos[x, y];
                }
            }
            return matriz;
        }
        //Metodo que me genera la matriz de adyacencia para el algoritmo de FloydWarshall
        public int[,] MatrizAdyacenciaFloyd()
        {
            int[,] matriz = new int[cantNodos - 1, cantNodos - 1];
            for (int x = 1; x < cantNodos; x++)
            {
                for (int y = 1; y < cantNodos; y++)
                {
                    if (x == y)
                        matriz[x - 1, y - 1] = 0;
                    else if ((int)nodos[x, y] != -1)
                        matriz[x - 1, y - 1] = (int)nodos[x, y];
                    else
                        matriz[x - 1, y - 1] = int.MaxValue / 2;
                }
            }
            return matriz;
        }
        //Metodo que me genera un arreglo de los valores de los nodos
        public int[] ArregloDeNodos()
        {
            int[] matriz = new int[cantNodos - 1];
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                CVertice miNodo = (CVertice)nodos[0, x];
                if (miNodo != null)
                {
                    if(miNodo.Valor != "")
                        matriz[x - 1] = int.Parse(miNodo.Valor);
                }
            }
            return matriz;
        }
        
        public object[] ArregloNodos()
        {
            object[] arreglo = new object[cantNodos - 1];
            for (int x = 1; x < nodos.GetLength(0); x++)
            {
                if (nodos[0, x] != null)
                    arreglo[x - 1] = nodos[0, x];
            }
            return arreglo;
        }
    }
}