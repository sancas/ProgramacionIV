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
        private int longitud;
        private int[] arreglo = new int[1];
        private Button[] arreglo_botones = new Button[1];
        public Numeros()
        {
            int a = 0;
            arreglo[0] = a;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 40;
            arreglo_botones[0].Height = 40;
            arreglo_botones[0].BackColor = Color.GreenYellow;
            arreglo_botones[0].Text = a.ToString();
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
        public void insertar_Dato(int dato, bool letra)
        {
            Array.Resize<int>(ref arreglo, longitud + 1);
            arreglo[longitud] = dato;
            Array.Resize<Button>(ref arreglo_botones, longitud + 1);
            arreglo[longitud] = dato;
            arreglo_botones[longitud] = new Button();
            arreglo_botones[longitud].Width = 50;
            arreglo_botones[longitud].Height = 50;
            arreglo_botones[longitud].BackColor = Color.GreenYellow;
            if (letra)
                arreglo_botones[longitud].Text = Char.ConvertFromUtf32(dato).ToString();
            else
                arreglo_botones[longitud].Text = dato.ToString();
            Calcular_Longitud();
        }
        public Button[] Arreglo_Botones()
        {
            return arreglo_botones;
        }
        public void limpiar_Datos()
        {
            Array.Resize<int>(ref arreglo, 1);
            Array.Resize<Button>(ref arreglo_botones, 1);
            arreglo[0] = 0;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 40;
            arreglo_botones[0].Height = 40;
            arreglo_botones[0].BackColor = Color.GreenYellow;
            arreglo_botones[0].Text = "0";
            Calcular_Longitud();
        }
    }
}
