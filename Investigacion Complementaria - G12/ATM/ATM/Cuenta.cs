using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Cuenta
    {
        public string Tarjeta { get; }
        public string Pin { set; get; }
        public decimal balance { set; get; }

        public Cuenta(string Tarjeta, string Pin, decimal balance)
        {
            this.Tarjeta = Tarjeta;
            this.Pin = Pin;
            this.balance = balance;
        }

        public bool cambiarPin(string nuevoPin)
        {
            if (nuevoPin != this.Pin)
            {
                this.Pin = nuevoPin;
                return true;
            }
            return false;
        }

        public bool sePuedeRetirar(decimal monto)
        {
            if (monto <= balance)
                return true;
            return false;
        }

        public void retirar(decimal monto)
        {
            if (sePuedeRetirar(monto))
                balance -= monto;
        }
    }
}
