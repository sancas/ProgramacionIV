using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class Alumnos
    {
        public string carnet { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int edad { get; set; }
        public List<Materias> Materias { get; set; }

        public Alumnos()
        {
            this.Materias = new List<Materias>();
        }

        public void AgregarMateria(string nombreMateria)
        {
            this.Materias.Add(new Materias(nombreMateria));
        }

        public Alumnos(string carnet, string nombres, string primerApellido, string segundoApellido, int edad, string[] nombreMaterias)
        {
            AgregarAlumno(carnet, nombres, primerApellido, segundoApellido, edad);
            this.Materias = new List<Materias>();
            foreach (string nombreMateria in nombreMaterias)
            {
                Materias.Add(new Materias(nombreMateria));
            }
        }

        public void AgregarAlumno(string carnet, string nombres, string primerApellido, string segundoApellido, int edad)
        {
            this.carnet = carnet;
            this.nombres = nombres;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.edad = edad;
        }

        public void AgregarNotas(double nota1, double nota2, double nota3, string nombreMateria = "Matematica")
        {
            this.Materias.Find(v => v.nombreMateria == nombreMateria).IngresarNotas(nota1, nota2, nota3);
        }

        public double CalcularPromedio(string nombreMateria = "Matematica")
        {
            return this.Materias.Find(v => v.nombreMateria == nombreMateria).CalcularPromedio();
        }
    }
}
