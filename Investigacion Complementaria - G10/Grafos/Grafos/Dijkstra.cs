using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Dijkstra
    { // Declaración de variables a utilizar
        private int rango = 0;
        private int[,] L; // matriz de adyacencia
        private int[] C; // arreglo de nodos
        public int[] D; // arreglo de distancias
        private int trango = 0;
        // Algoritmo Dijkstra
        public Dijkstra(CGrafo grafo, int indiceNodoInicial = 0)
        {
            int paramRango = grafo.nodos.GetLength(0) - 1;
            L = new int[paramRango, paramRango];
            C = new int[paramRango];
            D = new int[paramRango];
            rango = paramRango;
            for (int i = 0; i < rango; i++)
            {
                for (int j = 0; j < rango; j++)
                {
                    L[i, j] = grafo.MatrizAdyacencia()[i, j];
                }
            }
            for (int i = 0; i < rango; i++)
            {
                C[i] = grafo.ArregloDeNodos()[i];
            }
            C[indiceNodoInicial] = -1;
            for (int i = 0; i < rango; i++)
            {
                if (i != indiceNodoInicial)
                    D[i] = L[indiceNodoInicial, i];
            }
        }
        // Rutina de solución Dijkstra
        public void SolDijkstra()
        {
            int minValor = Int32.MaxValue;
            int minNodo = 0;
            for (int i = 0; i < rango; i++)
            {
                if (C[i] == -1)
                    continue;
                if (D[i] > 0 && D[i] < minValor)
                {
                    minValor = D[i];
                    minNodo = i;
                }
            }
            C[minNodo] = -1;
            for (int i = 0; i < rango; i++)
            {
                if (L[minNodo, i] < 0) // si no existe arco
                    continue;
                if (D[i] < 0) // si no hay un peso asignado
                {
                    D[i] = minValor + L[minNodo, i];
                    continue;
                }
                if ((D[minNodo] + L[minNodo, i]) < D[i])
                    D[i] = minValor + L[minNodo, i];
            }
        }
        // Función de implementación del algoritmo
        public string CorrerDijkstra(CGrafo grafo)
        {
            string miCadena = String.Empty;
            for (trango = 1; trango < rango; trango++)
            {
                SolDijkstra();
                miCadena += "Iteracion No." + trango + "\n";
                miCadena +="Matriz de distancias: \n";
                for (int i = 0; i < rango; i++)
                    miCadena += C[i] + " ";
                miCadena += "\n";
                for (int i = 0; i < rango; i++)
                    miCadena += D[i] + " ";
                miCadena += "\n";
                miCadena += "\n";
            }
            return miCadena;
        }
    }
}
