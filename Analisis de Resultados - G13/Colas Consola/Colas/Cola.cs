using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            aux.info = Valor;
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

        public void Desencolar() //Desencolar saca el primer valor de la cola devuelve true si tuvo exito
        {
            if (Primero == null)
                Console.WriteLine("Cola Vacia");
            else
                Primero = Primero.siguiente;
        }

        public int DesencolarValor() //Desencolar saca el primer valor pero lo devuelve como respuesta
        {
            int Valor = 0;
            if (Primero == null)
                Console.WriteLine("Cola Vacia");
            else
            {
                Valor = Primero.info;
                Primero = Primero.siguiente;
            }
            return Valor;
        }

        public void Mostrar()
        {
            if (Primero == null)
                Console.WriteLine("Cola vacia");
            else
            {
                Nodo puntero;
                puntero = Primero;
                do
                {
                    Console.WriteLine("{0}\t", puntero.info);
                    puntero = puntero.siguiente;
                } while (puntero != null);
            }
        }
    }
}
