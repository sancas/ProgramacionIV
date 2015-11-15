using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    class Cola
    {
        public Nodo Primero; //Primer nodo de la Cola
        public Nodo Ultimo; //Ultimo nodo de la Cola

        public Cola()
        {
            //Constructor por defecto inicializa el primer y ultimo elemento como nulos
            Primero = null;
            Ultimo = null;
        }

        public void Encolar(int Valor) //Encolar mete un valor a la cola
        {
            Nodo aux = new Nodo();
            aux.valor = Valor;
            if (Primero == null) //Si la cola esta vacia
            {
                Primero = aux;
                Ultimo = aux;
                aux.siguiente = null;
            }
            else //Si la cola no esta vacia
            {
                Ultimo.siguiente = aux;
                aux.siguiente = null;
                Ultimo = aux;
            }
        }

        public void Encolar(Nodo nuevoNodo) //Encolar ingresa el nodo a la cola
        {
        }

        public void Desencolar() //Desencolar saca el primer valor de la cola devuelve true si tuvo exito
        {
            if (Primero == null)
                MessageBox.Show("La cola actual se encuentra vacia",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                Primero = Primero.siguiente;
        }

        public int DesencolarValor() //Desencolar saca el primer valor pero lo devuelve como respuesta
        {
            int Valor = 0;
            if (Primero == null)
                MessageBox.Show("La cola actual se encuentra vacia",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                Valor = Primero.valor;
                Primero = Primero.siguiente;
            }
            return Valor;
        }

        public void Mostrar()
        {
            if (Primero == null)
                MessageBox.Show("La cola actual se encuentra vacia",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                Nodo puntero;
                string miCola = String.Empty;
                puntero = Primero;
                do
                {
                    miCola += String.Format("{0}\t", puntero.valor);
                    puntero = puntero.siguiente;
                } while (puntero != null);
                MessageBox.Show(miCola, "Datos de la cola.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
