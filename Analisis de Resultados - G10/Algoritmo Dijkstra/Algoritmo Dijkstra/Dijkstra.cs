using System;
using System.Collections.Generic;
using System.Text;
namespace Algoritmo_Dijkstra
{
    class Dijkstra
    { // Declaración de variables a utilizar
        private int rango = 0;
        private int[,] L; // matriz de adyacencia
        private int[] C; // arreglo de nodos
        public int[] D; // arreglo de distancias
        private int trango = 0;
        // Algoritmo Dijkstra
        public Dijkstra(int paramRango, int[,] paramArreglo)
        {
            L = new int[paramRango, paramRango];
            C = new int[paramRango];
            D = new int[paramRango];
            rango = paramRango;
            for (int i = 0; i < rango; i++)
            {
                for (int j = 0; j < rango; j++)
                {
                    L[i, j] = paramArreglo[i, j];
                }
            }
            for (int i = 0; i < rango; i++)
            {
                C[i] = i;
            }
            C[5] = -1;
            for (int i = 0; i < rango; i++)
            {
                if(i!= 5)
                    D[i] = L[5, i];
            }
        }
        // Rutina de solución Dijkstra
        public void SolDijkstra()
        {
            int minValor = Int32.MaxValue;
            int minNodo = 5;
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
        public void CorrerDijkstra()
        {
            Console.WriteLine("Iteracion No." + 0);
            Console.WriteLine("Matriz de distancias: ");
            for (int i = 0; i < rango; i++)
                Console.Write(i + " ");
            Console.WriteLine(" ");
            for (int i = 0; i < rango; i++)
                Console.Write(D[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (trango = 1; trango < rango; trango++)
            {
                SolDijkstra();
                Console.WriteLine("Iteracion No." + trango);
                Console.WriteLine("Matriz de distancias: ");
                for (int i = 0; i < rango; i++)
                    Console.Write(i + " ");
                Console.WriteLine(" ");
                for (int i = 0; i < rango; i++)
                    Console.Write(D[i] + " ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            // Definición de la matriz de adyacencia del digrafo mostrado en la figura 1
            int[,] L = {
                {-1, 10, 18, -1, -1, -1, -1},
                {-1, -1,  6, -1,  3, -1, -1},
                {-1, -1, -1,  3, -1, 20, -1},
                {-1, -1,  2, -1, -1, -1,  2},
                {-1, -1, -1,  6, -1, -1, 10},
                { 1,  1, -1, -1, -1, -1, -1},
                {-1, -1, 10, -1, -1,  5, -1}
            };
            Dijkstra prueba = new Dijkstra((int)Math.Sqrt(L.Length), L);
            prueba.CorrerDijkstra();
            Console.WriteLine("La solucion de la ruta mas corta tomando como nodo inicial el NODO 1 es: ");
            int nodo = 1;
            foreach (int i in prueba.D)
            {
                Console.Write("Distancia minima a nodo " + nodo + " es ");
                Console.WriteLine(i);
                nodo++;
            }
            Console.WriteLine();
            Console.WriteLine("Presione la tecla Enter para salir.");
            Console.Read();
        }
    }
}