using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class FloydWarshall
    {
        public const int Infinity = int.MaxValue / 2;
        public const object NIL = null;

        private int[,] CopyMatrix(int[,] m, int n)
        {
            int[,] x = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    x[i, j] = m[i, j];

            return x;
        }

        public int[,] CorrerFloydWarshall(int[,] W, int n)
        {
            int[,] D0 = CopyMatrix(W, n);
            int[,] D1 = new int[n, n];
            object[,] P0 = new object[n, n];
            object[,] P1 = new object[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || W[i, j] == Infinity)
                        P0[i, j] = NIL;

                    else if (i != j && W[i, j] < Infinity)
                        P0[i, j] = (object)i;
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        D1[i, j] = Math.Min(
                            D0[i, j], D0[i, k] + D0[k, j]);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (D0[i, j] <= D0[i, k] + D0[k, j])
                            P1[i, j] = P0[i, j];

                        else if (D0[i, j] > D0[i, k] + D0[k, j])
                            P1[i, j] = P0[k, j];
                    }
                }

                D0 = CopyMatrix(D1, n);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        P0[i, j] = P1[i, j];
            }
            return D0;
        }
    }
}
