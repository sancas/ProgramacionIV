using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Problema2
{
    public partial class Form1 : MetroForm
    {
        bool debug = true; //True genera datos de prueba para evaluacion
        public List<Alumnos> Alumnos = new List<Alumnos>();
        public double[] promedios;
        public string[] carnets;
        public int[] edades;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabIngresoAlumnos;
            //DEBUG
            if (debug)
            {
                Alumnos.Add(new Alumnos("SA120974", "CRISTIAN ANTONIO", "SANCHEZ", "AGUILAR", 23, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("MR121244", "ROBIN ALEXANDER", "SERVELLON", "ROSALES", 21, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("PO115434", "LUCAS MODIRC", "PORTILLO", "ORTIZ", 21, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("CA105345", "SANDRA MARGARITA", "CARRANZA", "SANCHEZ", 23, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("HE245523", "NATALY ANDREA", "HERNANDEZ", "ELIOT", 19, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("HH542532", "LEONEL MESSI", "HERNANDEZ", "HERNANDEZ", 15, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("CR545413", "CRISTIANO RONALDO", "CACERES", "RUIZ", 20, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("HG545654", "SLATAN IBRAHIMOVIC", "HUEZO", "GOMEZ", 25, new string[] { "Matematica" }));
                Alumnos.Add(new Alumnos("JY546545", "RONALDINHO MARIO", "JEICS", "YOHN", 19, new string[] { "Matematica" }));
                Random miRandom = new Random();
                foreach (Alumnos Alumno in Alumnos)
                {
                    double nota1, nota2, nota3;
                    nota1 = Math.Round(miRandom.NextDouble() * 10, 2);
                    nota2 = Math.Round(miRandom.NextDouble() * 10, 2);
                    nota3 = Math.Round(miRandom.NextDouble() * 10, 2);
                    Alumno.AgregarNotas(nota1, nota2, nota3);
                    gridAlumnos.Rows.Add(Alumno.carnet, Alumno.nombres, Alumno.primerApellido, Alumno.segundoApellido, Alumno.edad);
                    gridNotas.Rows.Add(Alumno.carnet, nota1, nota2, nota3, Alumno.CalcularPromedio());
                }
            }
        }

        private void trackBarEdad_Scroll(object sender, ScrollEventArgs e)
        {
            lblTrackBarEdad.Text = trackBarEdad.Value.ToString();
        }

        private void txtCarnet_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarnet.Text))
            {
                errorProvider.SetError(txtCarnet, "Debe ingresar un carnet valido");
            }
            else if(!txtCarnet.Text.validarCarnet())
            {
                errorProvider.SetError(txtCarnet, "Debe ingresar 2 caracteres y 6 numeros");
            }
            else
            {
                errorProvider.SetError(txtCarnet, string.Empty);
            }
        }

        private void txtPrimerApellido_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                errorProvider.SetError(txtPrimerApellido, "Debe ingresar un primer apellido");
            }
            else if (!txtPrimerApellido.Text.IsLetters())
            {
                errorProvider.SetError(txtPrimerApellido, "Debe ingresar un apellido valido");
            }
            else
            {
                errorProvider.SetError(txtPrimerApellido, string.Empty);
            }
        }

        private void txtSegundoApellido_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                errorProvider.SetError(txtSegundoApellido, "Debe ingresar un segundo apellido");
            }
            else if (!txtSegundoApellido.Text.IsLetters())
            {
                errorProvider.SetError(txtSegundoApellido, "Debe ingresar un apellido valido");
            }
            else
            {
                errorProvider.SetError(txtSegundoApellido, string.Empty);
            }
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider.SetError(txtNombres, "Debe ingresar un nombre");
            }
            else if (!txtNombres.Text.IsLetters())
            {
                errorProvider.SetError(txtNombres, "Debe ingresar un nombre valido");
            }
            else
            {
                errorProvider.SetError(txtNombres, string.Empty);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            txtCarnet.Focus();
            txtPrimerApellido.Focus();
            txtSegundoApellido.Focus();
            txtNombres.Focus();
            btnIngresar.Focus();
            this.Focus();
            validaciones = errorProvider.GetError(txtCarnet);
            validaciones += errorProvider.GetError(txtPrimerApellido);
            validaciones += errorProvider.GetError(txtSegundoApellido);
            validaciones += errorProvider.GetError(txtNombres);
            if (validaciones == string.Empty)
            {
                if (!Alumnos.Exists(x => x.carnet == txtCarnet.Text))
                {
                    Alumnos.Add(new Alumnos(txtCarnet.Text, txtNombres.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, trackBarEdad.Value, new string[]{ "Matematica" }));
                    gridAlumnos.Rows.Add(txtCarnet.Text, txtNombres.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, trackBarEdad.Value.ToString());
                    tabControl.SelectedTab = tabAlumnos;
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "El carnet que desea emplear para este Alumno ya se encuentra en uso", "Error registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void tabIngresoAlumnos_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtCarnet.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtNombres.Clear();
            trackBarEdad.Value = 18;
            this.Focus();
        }

        private void tabIngresoNotas_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtCarnet.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addCarnets(DataCollection);
            txtNotasCarnet.AutoCompleteCustomSource = DataCollection;
        }

        private void addCarnets(AutoCompleteStringCollection DataCollection)
        {
            foreach (Alumnos Alumno in Alumnos)
            {
                DataCollection.Add(Alumno.carnet + " - " + Alumno.nombres );
            }
        }

        private void txtNotasCarnet_Leave(object sender, EventArgs e)
        {
            if (txtNotasCarnet.Text.Length > 8)
                txtNotasCarnet.Text = txtNotasCarnet.Text.Remove(8);
        }

        private void btnIngresarNotas_Click(object sender, EventArgs e)
        {
            string validaciones = string.Empty;
            txtNota1.Focus();
            txtNota2.Focus();
            txtNota3.Focus();
            btnIngresarNotas.Focus();
            this.Focus();
            validaciones = errorProvider.GetError(txtNota1);
            validaciones += errorProvider.GetError(txtNota2);
            validaciones += errorProvider.GetError(txtNota3);
            if (validaciones == string.Empty)
            {
                double nota1, nota2, nota3;
                nota1 = double.Parse(txtNota1.Text);
                nota2 = double.Parse(txtNota2.Text);
                nota3 = double.Parse(txtNota3.Text);
                Alumnos miAlumno = Alumnos.Find(v => v.carnet == txtNotasCarnet.Text);
                miAlumno.AgregarNotas(nota1, nota2, nota3);
                gridNotas.Rows.Add(miAlumno.carnet, nota1, nota2, nota3, miAlumno.CalcularPromedio());
                tabControl.SelectedTab = tabNotas;
            }
        }

        private void txtNota1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNota1.Text))
            {
                errorProvider.SetError(txtNota1, "Debe ingresar una nota");
            }
            else if (!txtNota1.Text.isValidNote())
            {
                errorProvider.SetError(txtNota1, "Debe ingresar una nota valida");
            }
            else
            {
                errorProvider.SetError(txtNota1, string.Empty);
            }
        }

        private void txtNota2_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNota2.Text))
            {
                errorProvider.SetError(txtNota2, "Debe ingresar una nota");
            }
            else if (!txtNota2.Text.isValidNote())
            {
                errorProvider.SetError(txtNota2, "Debe ingresar una nota valida");
            }
            else
            {
                errorProvider.SetError(txtNota2, string.Empty);
            }
        }

        private void txtNota3_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNota3.Text))
            {
                errorProvider.SetError(txtNota3, "Debe ingresar una nota");
            }
            else if (!txtNota3.Text.isValidNote())
            {
                errorProvider.SetError(txtNota3, "Debe ingresar una nota valida");
            }
            else
            {
                errorProvider.SetError(txtNota3, string.Empty);
            }
        }

        private void tileOrdenar_Click(object sender, EventArgs e)
        {
            //Ordenar arreglos
            MetodoBurbuja.BubbleSort(ref carnets);
            MetodoShellSort.ShellSort(ref edades);
            MetodoMergeSort.MergeSort(ref promedios, 0, promedios.Length - 1);

            //Limpiamos los listbox
            listBoxCarnet.Items.Clear();
            listBoxEdad.Items.Clear();
            listBoxPromedio.Items.Clear();

            //Llenar ListBoxes con datos ordenados
            for (int x = 0; x < Alumnos.Count; x++)
            {
                listBoxCarnet.Items.Add(carnets[x]);
                listBoxEdad.Items.Add(edades[x]);
                listBoxPromedio.Items.Add(promedios[x]);
            }
        }

        private void tabListas_Enter(object sender, EventArgs e)
        {
            //Limpiamos los listbox
            listBoxCarnet.Items.Clear();
            listBoxEdad.Items.Clear();
            listBoxPromedio.Items.Clear();

            carnets = new string[Alumnos.Count];
            edades = new int[Alumnos.Count];
            promedios = new double[Alumnos.Count];
            int x = 0;
            foreach (Alumnos Alumno in Alumnos)
            {
                //Llenar ListBoxes
                listBoxCarnet.Items.Add(Alumno.carnet);
                listBoxEdad.Items.Add(Alumno.edad);
                listBoxPromedio.Items.Add(Alumno.CalcularPromedio());

                //Llenar arreglos
                carnets[x] = Alumno.carnet;
                edades[x] = Alumno.edad;
                promedios[x] = Alumno.CalcularPromedio();

                //Incrementar contador
                x++;
            }
        }

        private void txtNotasCarnet_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotasCarnet.Text))
            {
                errorProvider.SetError(txtNotasCarnet, "Debe ingresar un carnet");
            }
            else
            {
                errorProvider.SetError(txtNotasCarnet, string.Empty);
            }
        }
    }
}
