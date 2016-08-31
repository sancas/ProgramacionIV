using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class Materias
    {
        public string nombreMateria;
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double promedio { get; set; }

        public Materias(string nombreMateria = "Matematica")
        {
            this.nombreMateria = nombreMateria;
        }
        
        public void IngresarNotas(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalcularPromedio()
        {
            this.promedio = (nota1 * 0.30) + (nota2 * 0.35) + (nota3 * 0.35);
            return Math.Round(promedio, 2);
        }
    }
}
