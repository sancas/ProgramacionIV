using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Backtracking
{
    class Sudoku
    {
        //Declaracion de variable que definira el tamaño del tablero
        public static int Dimension = 9;

        public static void imprimir(int[,] tablero)
        {
            for (int i = 0; i < Dimension; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine();

                for (int j = 0; j < Dimension; j++)
                {
                    if (j % 3 == 0)
                        Console.Write(" ");

                    Console.ForegroundColor = ConsoleColor.Yellow; //cambia el color de la fuente
                    Console.Write(tablero[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static Boolean resolver(int[,] tablero)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (tablero[i, j] != 0)
                        continue;
                    else
                    {
                        /* Calcula el valor de K es consistente, entonces establece en la posicion el
                         * valor de K, y luego se hace una llamada Recursiva */
                        for (int k = 1; k <= 9; k++)
                        {
                            if (esPosibleInsertar(tablero, i, j, k))
                            {
                                /*Si el valor de K es consistente, entonces establece en la posicion el
                                 * valor de K, y luego se hace una llamada recursiva */
                                tablero[i, j] = k;
                                Boolean b = resolver(tablero);

                                if (b)
                                    return true;

                                tablero[i, j] = 0;
                            }
                        }
                        /* Cuando se termina de recorrer el tablero y no se ha retornado el valor
                         * de verdadero, entonces, el tablero no tiene solucion */
                        return false;
                    }
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Solucion encontrada: ");
            imprimir(tablero);
            return true;
        }

        /* Funcion para verificar si se añade un valor al tablerom el tablero siga siendo
         * constante, es decir, que el valor no se repita en la fila o la columna */
        public static Boolean esPosibleInsertar(int[,] tablero, int i, int j, int valor)
        {
            //Primeramente, se verifica que el valor no se encuentre en la misma fila
            for (int a = 0; a < Dimension; a++)
            {
                if (a != i && tablero[a, j] == valor)
                    return false;
            }

            //Luego, se verifica que el valor no se encuentre en la misma columna
            for (int a = 0; a < Dimension; a++)
            {
                if (a != j && tablero[i, a] == valor)
                    return false;
            }

            //Se verifica que el valor no se encuentre en la misma cuadricula
            int y = (i / 3) * 3;
            int x = (j / 3) * 3;

            for (int a = 0; a < Dimension / 3; a++)
            {
                for (int b = 0; b < Dimension / 3; b++)
                {
                    if (a != i && b != j && tablero[y + a, x + b] == valor)
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            //Generamos un tablero inicial de Sudoku
            int[,] tablero = new int[,]{
                {0,7,0, 0,0,0, 0,8,0},
                {0,5,8, 6,0,0, 0,0,1},
                {0,0,3, 1,4,0, 0,0,0},

                {9,0,6, 0,5,0, 3,0,0},
                {0,0,0, 0,0,0, 0,0,0},
                {0,0,5, 0,2,0, 1,0,7},

                {0,0,0, 0,6,5, 7,0,0},
                {3,0,0, 0,0,1, 9,2,0},
                {0,4,0, 0,0,0, 0,1,0},
            };

            Console.WriteLine("El juego a resolver es: ");
            imprimir(tablero);

            if (!resolver(tablero))
                Console.WriteLine("El sudoku no tiene solucion");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Presione una tecla para salir");
            Console.Read();
        }
    }
}
