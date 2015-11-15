using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    class Nodo
    {
        public int valor { get; set; } //Guarda el valor del nodo
        public int prioridad { get; set; } //Guarda la prioridad del nodo
        public Nodo siguiente { get; set; } //Puntero al siguiente nodo
    }
}
