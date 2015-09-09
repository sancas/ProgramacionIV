using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MetodosDeOrdenamiento
{
    public class Numeros
    {
        private int longitud = 0;
        private int[] arreglo = new int[1];
        private Button[] arreglo_botones = new Button[1];
        public Numeros(int dato)
        {
            int a = 0;
            arreglo[a] = dato;
            arreglo_botones[a] = new Button();
            arreglo_botones[a].Width = 50;
            arreglo_botones[a].Height = 50;
            arreglo_botones[a].BackColor = Color.DarkBlue;
            arreglo_botones[a].Text = dato.ToString();
            Calcular_Longitud();
        }
        public void Calcular_Longitud()
        {
            longitud = arreglo.Length;
        }
        public int Obtener_Longitud()
        {
            return longitud;
        }
        public int[] Obtener_Arreglo()
        {
            return arreglo;
        }
        public void insertar_Dato(int dato)
        {
            Array.Resize<int>(ref arreglo, longitud + 1);
            arreglo[longitud] = dato;
            Array.Resize<Button>(ref arreglo_botones, longitud + 1);
            arreglo[longitud] = dato;
            arreglo_botones[longitud] = new Button();
            arreglo_botones[longitud].Width = 50;
            arreglo_botones[longitud].Height = 50;
            arreglo_botones[longitud].BackColor = Color.DarkBlue;
            arreglo_botones[longitud].Text = dato.ToString();
            Calcular_Longitud();
        }
        public Button[] Arreglo_Botones()
        {
            return arreglo_botones;
        }
    }
}
