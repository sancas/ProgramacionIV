using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        private Cola miCola = null; //miCola que alamcenara la cola con la cual trabajar
        private Nodo Aux; //Nodo Auxiliar para enviar cuando se necesite a la cola
        private static int cantBotones = 0; //Almacena la cantidad de botones con los que estoy trabajando
        private Prioridades ventanaPrioridades; //Instancia del formulario Prioridades
        private Button[] Botones = new Button[cantBotones]; //Botoenes que simularan mi cola

        public Form1()
        {
            InitializeComponent();
            ventanaPrioridades = new Prioridades();
        }

        //Metodo para multidimensionar una matriz
        private Array ResizeArray(Object[] arr, int newSize)
        {
            Object[] temp = new Object[newSize];
            for (int x = 0; x < arr.GetLongLength(0); x++)
            {
                 temp[x] = arr[x];
            }
            return temp;
        }

        //Metodo para eliminar los botones
        private void BorrarBotones()
        {
            for (int x = 0; x < cantBotones; x++)
            {
                this.Controls.Remove(Botones[x]);
            }
        }

        private void newCola_Click(object sender, EventArgs e)
        {
            if (miCola == null)
            {
                miCola = new Cola();
                ventanaPrioridades.ShowDialog();
            }
            else
            {
                DialogResult DR = MessageBox.Show("Esta seguro que desea borrar la cola actual y crear una nueva?",
                    "Confirme porfavor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DR == DialogResult.Yes) //Si respondio Si
                {
                    BorrarBotones();
                    cantBotones = 0;
                    miCola = new Cola();
                }
            }
        }

        private void newNode_Click(object sender, EventArgs e)
        {
            Aux = new Nodo();
        }
    }
}
