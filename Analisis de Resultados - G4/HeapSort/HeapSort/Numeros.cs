﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HeapSort
{
    public class Numeros
    {
        private int longitud;
        private int[] arreglo = new int[1];
        private Button[] arreglo_botones = new Button[1];
        private Button[] arreglo_botonesArbol = new Button[1];
        private Label[] arreglo_labels = new Label[1];
        public Numeros()
        {
            int a = 0;
            arreglo[0] = a;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 20;
            arreglo_botones[0].Height = 20;
            arreglo_botones[0].BackColor = Color.GreenYellow;
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
            Array.Resize<Button>(ref arreglo_botonesArbol, longitud + 1);
            arreglo[longitud] = dato;
            arreglo_botones[longitud] = new Button();
            arreglo_botones[longitud].Width = 40;
            arreglo_botones[longitud].Height = 40;
            arreglo_botones[longitud].BackColor = Color.GreenYellow;
            if (letra)
                arreglo_botones[longitud].Text = Char.ConvertFromUtf32(dato).ToString();
            else
                arreglo_botones[longitud].Text = dato.ToString();
            arreglo_botonesArbol = arreglo_botones;
            Calcular_Longitud();
        }
        public Button[] Arreglo_Botones()
        {
            return arreglo_botones;
        }
        public Button[] Arreglo_BotonesArbol()
        {
            return arreglo_botonesArbol;
        }
        public void limpiar_Datos()
        {
            Array.Resize<int>(ref arreglo, 1);
            Array.Resize<Button>(ref arreglo_botones, 1);
            arreglo[0] = 0;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 20;
            arreglo_botones[0].Height = 20;
            arreglo_botones[0].BackColor = Color.GreenYellow;
            arreglo_botones[0].Text = "0";
            Calcular_Longitud();
        }
    }
}
