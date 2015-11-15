using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace BinomialQueue
{
    class BinomialTree:ICloneable
    {
        private int valor;
        private int grado = 0;
        private int tiempo;
        public int radio;
        public bool existenodo = false;
        public bool visitado = false;
        public Rectangle rectangulo;
        public int xcentro, ycentro;
        public BinomialTree nodopadre;
        public BinomialTree nodohermano;
        public List<BinomialTree> nodohijo = new List<BinomialTree>();

        // Getters y Setters
        public int Grado
        {
            get
            {
                return nodohijo.Count;
            }
            set
            {
                grado = value;
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        //Constructores
        //Con parametros (valor)
        public BinomialTree(int valor)
        {
            this.valor = valor;
            radio = 15;
            this.tiempo = 1000;
            this.rectangulo = new Rectangle(0, 0, 2 * radio, 2 * radio);
        }
        //Por defecto
        public BinomialTree()
        {
            this.nodopadre = null;
            this.nodohermano = null;
        }

        public BinomialTree(BinomialTree nodocopia)
        {
            this.nodohermano = nodocopia.nodohermano;
            this.nodopadre = nodocopia.nodopadre;
            this.valor = nodocopia.Valor;
            this.nodohijo = nodocopia.nodohijo;
        }

        public void Simulacion(bool simulado)
        {
            if (simulado)
                this.tiempo = 1000;
            else
                this.tiempo = 0;
        }

        public void Dibujar(Graphics g, BinomialTree BT)
        {
            Pen pen = new Pen(SystemColors.ControlDark, 5);
            if (BT.nodopadre != null)//Si tiene padre, se dibuja linea hacia el padre
            {
                DibujarLineas(g, BT.nodopadre.xcentro, BT.nodopadre.ycentro, BT.xcentro, BT.ycentro);
            }
            if (BT.nodohermano != null)//Si tiene hermano, se dibuja linea entre ellos
            {
                DibujarLineas(g, BT.nodohermano.xcentro, BT.nodohermano.ycentro, BT.xcentro, BT.ycentro);
            }
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            if (visitado)
                g.FillEllipse(Brushes.White, BT.rectangulo);
            else
                g.FillEllipse(Brushes.LimeGreen, BT.rectangulo);

            g.DrawString(BT.valor.ToString(), new Font("Times New Roman", 9.0f), Brushes.Black, new Point(BT.xcentro, BT.ycentro), sf);

            foreach (BinomialTree abb in BT.nodohijo)
                abb.Dibujar(g, abb);
            pen.Dispose();
        }

        public bool Contiene(Point xy)
        {
            if (Math.Sqrt(Math.Pow(this.xcentro - xy.X, 2) + Math.Pow(this.ycentro - xy.Y, 2)) <= radio)
                return true;
            return false;
        }

        public void DibujarLineas(Graphics g, int x11, int y11, int x22, int y22)
        {
            Pen pen = new Pen(SystemColors.ControlDark, 5);
            if (x11 == x22)
            {
                g.DrawLine(pen, x11, y11 + radio, x22, y22 - radio);
            }
            else
            {
                if (y11 == y22)
                {
                    g.DrawLine(pen, x11 + radio, y11, x22 - radio, y22);
                }
                else
                {
                    int X1 = x11;
                    int X2 = x22;
                    int Y1 = y11;
                    int Y2 = y22;
                    int dx = X1 - X2;
                    int dy = Y1 - Y2;
                    float m = 0;
                    float b = 0;
                    m = (float)dy / (float)dx;
                    b = Y1 - m * X1;

                    double teta1 = Math.Atan2(Y2 - Y1, X2 - X1);//Angulo inclinacion de vo a vf
                    int x1 = (int)(X1 + (float)((Math.Cos(teta1)) * (radio)));
                    int y1 = (int)(Y1 + (float)((Math.Sin(teta1)) * (radio)));

                    double teta2 = Math.Atan2(dy, dx);//Angulo inclinacion de vf a vo
                    int x2 = (int)(X2 + (float)((Math.Cos(teta2)) * (radio)));
                    int y2 = (int)(Y2 + (float)((Math.Sin(teta2)) * (radio)));

                    int xtemp = (X1 + X2) / 2;
                    int ytemp = (int)(m * xtemp + b);
                    g.DrawLine(pen, x1, y1, x2, y2);

                }
            }
            pen.Dispose();
        }

        public void ActualizarLocalidad(int x, int y, BinomialTree raiz)
        {
            if (raiz != null)
            {
                raiz.xcentro = x + radio;
                raiz.ycentro = y + radio;
                raiz.rectangulo.Location = new Point(x, y);
                if (nodohijo.Count > 0)
                {

                    for (int a = 0; a < nodohijo.Count; a++)
                    {
                        if (a > 2)
                            nodohijo[a].ActualizarLocalidad(x + (int)Math.Pow(2, a - 3) * x + nodohijo[a - 1].rectangulo.X, y + 4 * radio, nodohijo[a]);
                        else
                            nodohijo[a].ActualizarLocalidad(x + (a * 2 * radio), y + 4 * radio, nodohijo[a]);
                    }
                }
            }
        }

        public bool ExisteNodo(int nvalor)
        {
            if (this.valor == nvalor)//Si este nodo ya posee ese valor, existe nodo
                return true;

            if (nodohijo.Count > 0)//se validan los hijos
            {
                foreach (BinomialTree nson in nodohijo)//Si existe algun hijo con ese valor, existe nodo
                    if (!nson.ExisteNodo(nvalor))
                        continue;
                    else
                        return true;
            }

            return false;
        }

        public void Ordenar(BinomialTree raiz)
        {
            if (raiz.nodohijo.Count > 1)
            {
                raiz.nodohijo.Sort(delegate (BinomialTree a1, BinomialTree a2) { return a1.Grado.CompareTo(a2.Grado); });
                foreach (BinomialTree abw in raiz.nodohijo)
                    abw.Ordenar(abw);
            }
        }


        public void AumentarClave(int valornodo, int datonuevo, Graphics g, BinomialTree ab)
        {
            if (valornodo == ab.valor)//Se ha llegado al nodo destino
            {
                ab.valor = datonuevo;
                ab.visitado = true;
                if (ab.nodopadre != null)
                    ab.nodopadre.visitado = true;
                if (ab.nodohijo.Count > 0)
                    ab.nodohijo[0].visitado = true;
                ab.Dibujar(g, ab);
                Thread.Sleep(tiempo);
                ab.visitado = false;
                if (ab.nodopadre != null)
                    ab.nodopadre.visitado = false;
                if (ab.nodohijo.Count > 0)
                    ab.nodohijo[0].visitado = false;

                if (ab.nodopadre != null && ab.nodopadre.valor < datonuevo)//Cambia hijo con padre
                {
                    ab.nodohermano = ab.nodopadre.nodohermano;
                    ab.nodopadre.nodohermano = null;
                    ab.nodopadre.nodopadre = ab;
                    ab.nodohijo.Add(ab.nodopadre);
                    ab.nodopadre = null;
                }
                ab.Dibujar(g, ab);
            }
            else
            {
                foreach (BinomialTree ahijo in ab.nodohijo)
                {
                    AumentarClave(valornodo, datonuevo, g, ahijo);
                }
            }
        }

        public void DisminuirClave(int valornodo, int datonuevo, Graphics g, BinomialTree ab)
        {
            if (valornodo == ab.valor)//Se ha llegado al nodo destino
            {
                ab.valor = datonuevo;
                ab.visitado = true;
                if (ab.nodopadre != null)
                    ab.nodopadre.visitado = true;
                if (ab.nodohijo.Count > 0)
                    ab.nodohijo[0].visitado = true;
                ab.Dibujar(g, ab);
                Thread.Sleep(tiempo);
                ab.visitado = false;
                if (ab.nodopadre != null)
                    ab.nodopadre.visitado = false;
                if (ab.nodohijo.Count > 0)
                    ab.nodohijo[0].visitado = false;



                if (ab.nodopadre != null && ab.nodopadre.valor > datonuevo)//Cambia hijo con padre
                {
                    ab.nodohermano = ab.nodopadre.nodohermano;
                    ab.nodopadre.nodohermano = null;
                    ab.nodopadre.nodopadre = ab;
                    ab.nodohijo.Add(ab.nodopadre);
                    ab.nodopadre = null;
                }

                ab.Dibujar(g, ab);
            }
            else
            {
                foreach (BinomialTree ahijo in ab.nodohijo)
                {
                    DisminuirClave(valornodo, datonuevo, g, ahijo);
                }
            }
        }

        public object Clone()
        {
            return new BinomialTree
            {
                valor = this.valor,
                grado = this.grado,
                radio = this.radio,
                existenodo = false,
                visitado = false,
                rectangulo = this.rectangulo,
                xcentro = this.xcentro,
                ycentro = this.ycentro,
                nodopadre = this.nodopadre,
                nodohermano = this.nodohermano,
                nodohijo = this.nodohijo
            };
        }
    }
}
