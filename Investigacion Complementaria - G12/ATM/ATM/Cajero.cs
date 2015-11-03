using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Cajero
    {
        private int tipoBills { get; set; } //Cantidad de billetes que hay
        private int[] valorBills = { 5, 10, 20 }; //Valores de los billetes
        private int[] cantidadBills { get; set; } //La cantidad total de billetes de cada valor que tiene el Cajero
        private int monto { get; set; } //El monto total que hay en el cajero al sumar la cantidad de billetes y sus respectivos valores
        
        public Cajero(int[] bills)
        {
            tipoBills = 3; //3 tipos de Billetes $5, $10, $20
            monto = 0;
            this.cantidadBills = new int[tipoBills];
            this.cantidadBills = bills;
            for (int x = 0; x < 3; x++)
            {
                monto += cantidadBills[x] * valorBills[x];
            }
        }

        public bool sePuedeRetirar(Cuenta miCuenta, int monto)
        {
            if (monto <= this.monto && miCuenta.sePuedeRetirar(monto))
                return true;
            return false;
        }

        public string retirar(Cuenta miCuenta, int monto)
        {
            string Cadena = String.Empty;
            if (sePuedeRetirar(miCuenta, monto))
            {
                Cambio C = new Cambio(monto, valorBills, cantidadBills);
                if (C.getVectorSeleccion() != null)
                {
                    cantidadBills = C.getVectorCantidad();
                    miCuenta.retirar(monto);
                    this.monto -= monto;
                    Cadena = "Gracias por utilizar este ATM\n";
                    Cadena += "Se entrego un total de: " + monto + "\n";
                    for (int x = 0; x < 3; x++)
                        Cadena += String.Format("Con {0} billetes de {1}\n", C.getVectorSeleccion()[x], valorBills[x]);
                }
            }
            return Cadena;
        }
    }
}