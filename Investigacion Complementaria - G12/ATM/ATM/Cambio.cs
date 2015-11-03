using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class Cambio
    {
        private int[][] matrizCambio;
        private int[] vectorMonedas;
        private int[] vectorCantidad;
        private int cantidad;
        private int[] vectorSeleccion;

        public Cambio(int cantidad, int[] monedas, int[] cantidadMonedas)
        {
            this.cantidad = cantidad;
            this.vectorMonedas = monedas;
            this.vectorCantidad = cantidadMonedas;
            matrizCambio = calcularMonedas(cantidad, monedas);
            vectorSeleccion = seleccionarMonedas(cantidad, monedas, matrizCambio);
        }

        public int[] getVectorSeleccion()
        {
            return this.vectorSeleccion;
        }

        public int[] getVectorCantidad()
        {
            return this.vectorCantidad;
        }

        private int[][] calcularMonedas(int cantidad, int[] monedas)
        {

            int[][] matrizCambio = new int[monedas.Length + 1][];
            for (int x = 0; x < matrizCambio.Length; x++)
            {
                matrizCambio[x] = new int[cantidad + 1];
            }

            for (int i = 0; i < monedas.Length; i++)
                matrizCambio[i][0] = 0;

            for (int j = 1; j <= cantidad; j++)
                matrizCambio[0][j] = 99;

            for (int i = 1; i <= monedas.Length; i++)
                for (int j = 1; j <= cantidad; j++)
                {
                    if (j < monedas[i - 1])
                    {

                        matrizCambio[i][j] = matrizCambio[i - 1][j];
                    }
                    else
                    {

                        int minimo = 0;

                        minimo = min(matrizCambio[i - 1][j], matrizCambio[i][j - monedas[i - 1]] + 1);
                        matrizCambio[i][j] = minimo;

                    }
                }

            return matrizCambio;
        }

        private int[] seleccionarMonedas(int c, int[] monedas, int[][] tabla)
        {
            int i, j;
            int[] seleccion = new int[monedas.Length];
            for (i = 0; i < monedas.Length; i++) { seleccion[i] = 0; }
            i = monedas.Length; j = c; while (j > 0)
            {
                if ((i > 1 && tabla[i][j] == tabla[i - 1][j]) || vectorCantidad[i - 1] == 0)
                {
                    i--;
                }
                else
                {
                    seleccion[i - 1]++;
                    j = j - monedas[i - 1];
                    vectorCantidad[i - 1]--;
                }
            }

            return seleccion;
        }

        private int min(int a, int b)
        {
            if (a < b)
                return a;

            else
                return b;
        }

    }
}
