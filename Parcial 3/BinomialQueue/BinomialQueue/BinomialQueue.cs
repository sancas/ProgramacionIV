using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BinomialQueue
{
    public class BinomialQueue
    {
        List<BinomialTree> arboles = new List<BinomialTree>();
        public bool isMin = true;
        private int Tiempo;
        public BinomialQueue()
        {
            this.Tiempo = 1000;
        }

        public void Simulacion(bool simulado)
        {
            if (simulado)
                this.Tiempo = 1000;
            else
                this.Tiempo = 0;
        }

        private void OrdenarArboles()
        {
            arboles.Sort(delegate (BinomialTree a1, BinomialTree a2) { return a1.Grado.CompareTo(a2.Grado); });
            foreach (BinomialTree abb in arboles)
                abb.Ordenar(abb);
        }

        public void ActualizarCola(Graphics g)
        {
            OrdenarArboles();
            int c;
            c = 0;
            int j;
            j = 0;

            for (int m = arboles.Count - 1; m > -1; m--)
            {
                if (arboles[m].Grado > c)
                    c = arboles[m].Grado;
            }
            Dibujar(g, 0, 0);
            Thread.Sleep(Tiempo * 2);

            BinomialTree arb1 = null;
            BinomialTree arb2 = null;

            while (j <= c)
            {
                foreach (BinomialTree a2 in arboles)
                {
                    if (a2.Grado == j)
                    {
                        if (arb1 == null)
                        {
                            arb1 = a2;
                        }
                        else
                            if (arb1 != null && arb2 == null)
                        {
                            arb2 = a2;
                            break;
                        }
                    }
                }

                if (arb1 != null && arb2 != null)
                {
                    Thread.Sleep(Tiempo / 2);
                    UnirArboles(arb1, arb2);
                    Dibujar(g, 0, 0);
                    Thread.Sleep(Tiempo / 2);

                }
                arb1 = null;
                arb2 = null;
                j++;
            }

            for (int m = arboles.Count - 1; m > -1; m--)
            {
                if (arboles[m].Grado > c)
                    c = arboles[m].Grado;
                if (m > 0)
                    arboles[m].nodohermano = arboles[m - 1];
            }


        }

        public void UnirColas(BinomialQueue cdestino, BinomialQueue c1, BinomialQueue c2, Graphics g)
        {
            foreach (BinomialTree a1 in c1.arboles)
            {
                a1.nodohermano = null;
                cdestino.arboles.Add(a1);
                cdestino.Dibujar(g, 0, 0);
                Thread.Sleep(Tiempo / 2);
            }
            foreach (BinomialTree a2 in c2.arboles)
            {
                a2.nodohermano = null;
                cdestino.arboles.Add(a2);
                cdestino.Dibujar(g, 0, 0);
                Thread.Sleep(Tiempo / 2);
            }
            cdestino.ActualizarCola(g);
        }

        private void UnirArboles(BinomialTree b1, BinomialTree b2)
        {
            if (isMin)
            {
                if (b1.Valor >= b2.Valor)
                {
                    b1.nodopadre = b2;
                    if (b1.nodohermano == b2)
                    {
                        b1.nodohermano = null;
                    }
                    else
                    {
                        b2.nodohermano = b1.nodohermano;
                        b1.nodohermano = null;
                    }
                    b2.nodohijo.Add(b1);
                    arboles.Remove(b1);
                }
                else
                {
                    b2.nodopadre = b1;
                    if (b2.nodohermano == b1)
                        b2.nodohermano = null;
                    else
                    {
                        b1.nodohermano = b2.nodohermano;
                        b2.nodohermano = null;
                    }
                    b1.nodohijo.Add(b2);
                    arboles.Remove(b2);
                }
            }
            else//es cola maximo
            {
                if (b1.Valor >= b2.Valor)
                {
                    b1.nodopadre = null;
                    b1.nodohermano = b2.nodohermano;
                    b2.nodopadre = b1;
                    b2.nodohermano = null;
                    b1.nodohijo.Add(b2);
                    arboles.Remove(b2);

                }
                else//b2 es el mayor
                {
                    b2.nodopadre = null;
                    b2.nodohermano = b1.nodohermano;
                    b1.nodopadre = b2;
                    b1.nodohermano = null;
                    b2.nodohijo.Add(b1);
                    arboles.Remove(b1);
                }
            }

        }

        public bool ExisteNodo(int nval)
        {
            foreach (BinomialTree av in arboles)
                if (av.ExisteNodo(nval))
                    return true;
            return false;
        }

        public void InsertarArbol(int nodovalor, Graphics g)
        {
            BinomialTree nuevo = new BinomialTree(nodovalor);
            arboles.Add(nuevo);
            ActualizarCola(g);
            nuevo = null;
        }

        public void Dibujar(Graphics g, int x, int y)
        {
            g.Clear(SystemColors.Info);
            if (arboles.Count > 0)
            {
                foreach (BinomialTree ab in arboles)
                {
                    ab.ActualizarLocalidad(x, y, ab);
                    if (ab.Grado > 0)
                        x += ((int)Math.Pow(2, ab.Grado - 1) + 1) * (2 * ab.radio);
                    else
                        x += 100;
                    ab.Dibujar(g, ab);
                }
            }
        }

        public void EliminarDatoHeap(Graphics g)
        {
            MostrarDatoHeap(g);
            int c;
            if (isMin)
            {
                c = int.MaxValue;
                foreach (BinomialTree ab in arboles)//se busca el minimo
                {
                    if (c > ab.Valor)
                        c = ab.Valor;
                }
            }

            else
            {
                c = 0;
                foreach (BinomialTree ab in arboles)//se busca maximo
                {
                    if (c < ab.Valor)
                        c = ab.Valor;
                }
            }
            if (c != 0 && c != int.MaxValue)
            {
                foreach (BinomialTree ab in arboles)//se pinta el nodo deseado
                {
                    if (c == ab.Valor)//se llego al nodo deseado, se modifica la cola origen
                    {
                        foreach (BinomialTree abinterno in ab.nodohijo)
                        {
                            abinterno.nodopadre = null;
                            this.arboles.Add(abinterno);
                        }
                        //Cuando ya se han agregado los hijos de dicho nodo, se elimina el nodo
                        arboles.Remove(ab);
                        ActualizarCola(g);
                        Dibujar(g, 0, 0);
                        break;
                    }
                }
            }
        }

        public void ModificarClaveHeap(int valornodo, int datonuevo, Graphics g)
        {
            if (isMin)
            {
                if (datonuevo < valornodo)
                {
                    foreach (BinomialTree bb in arboles)
                        bb.DisminuirClave(valornodo, datonuevo, g, bb);
                }
                else
                    MessageBox.Show("No se puede disminuir clave (clave nueva debe ser menor)",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else//es heap maximo
            {
                if (datonuevo > valornodo)
                {
                    foreach (BinomialTree bb in arboles)
                        bb.AumentarClave(valornodo, datonuevo, g, bb);
                }
                else
                    MessageBox.Show("No se puede aumentar clave (clave nueva debe ser mayor)",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void MostrarDatoHeap(Graphics g)
        {
            int c;
            if (isMin)
            {
                c = int.MaxValue;
                foreach (BinomialTree ab in arboles)//se busca el minimo
                {
                    if (c > ab.Valor)
                        c = ab.Valor;
                }
            }

            else
            {
                c = 0;
                foreach (BinomialTree ab in arboles)//se busca maximo
                {
                    if (c < ab.Valor)
                        c = ab.Valor;
                }
            }
            if (c != 0 && c != int.MaxValue)
            {
                foreach (BinomialTree ab in arboles)//se pinta el nodo deseado
                {
                    if (c == ab.Valor)
                    {
                        ab.visitado = true;
                        this.Dibujar(g, 0, 0);
                        Thread.Sleep(Tiempo * 2);
                        ab.visitado = false;
                        this.Dibujar(g, 0, 0);
                        break;
                    }
                }
            }
        }
    }
}
