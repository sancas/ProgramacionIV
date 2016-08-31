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

namespace Problema1
{
    public partial class Form1 : MetroForm
    {
        //Arreglo de letras
        string[] v = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        int[] arreglo;

        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabListas); //Quitamos el tabLista de las tabs
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Validaciones
            string validaciones = string.Empty; //String para acumular las validaciones
            txtCantidad.Focus(); //Se hace el focus al txtCantidad
            btnGenerar.Focus(); //Focus al button
            this.Focus(); //Focus al form
            if (cmbMetodo.SelectedIndex == -1) //Si no se ha seleccionado un metodo
            {
                errorProvider.SetError(cmbMetodo, "Debe seleccionar un metodo"); //Mandar un error con errorProvider
            }
            //Mandamos todos los mensajes de error al string validaciones
            validaciones += errorProvider.GetError(txtCantidad);
            validaciones += errorProvider.GetError(cmbMetodo);
            if (validaciones == string.Empty) //Si no hubo errores
            {
                btnOrdenar.Enabled = true; //Se habilita el boton para ordenar
                arreglo = new int[int.Parse(txtCantidad.Text)]; //Creamos el arreglo con la cantidad deseada
                Random myRandom = new Random(); //Creamos un objeto tipo Random para su posterior uso
                for (int x = 0; x < arreglo.Length; x++)
                {
                    arreglo[x] = myRandom.Next(0, 25); //Guardamos el random en el arreglo
                    listDesordenados.Items.Add(v[arreglo[x]]); //Guardamos el random en la lista tambien
                }
                if (!tabControl.TabPages.Contains(tabListas)) //Si tabListas no esta agregada
                    tabControl.TabPages.Add(tabListas); //Agregarla
                tabControl.SelectTab(tabListas); //Moverse a la tabLista
            }
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbMetodo, string.Empty); //Quitar errores en cmbMetodo
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem == "Inserción") //Si se selecciono metodo insercion
            {
                MetodosOrdenamiento.InsertionSort(ref arreglo, toggleOrden.Checked); //Ordenar por insercion
            }
            else if (cmbMetodo.SelectedItem == "Selección") //Si se selecciono metodo seleccion
            {
                MetodosOrdenamiento.SelectionSort(ref arreglo, toggleOrden.Checked); //Ordenar por seleccion
            }
            for (int x = 0; x < arreglo.Length; x++)
            {
                listOrdenados.Items.Add(v[arreglo[x]]); //Se carga la lista ordenada con el arreglo ya ordenado
            }
            btnOrdenar.Enabled = false; //Se deshabilita el control
        }

        private void tabListas_Leave(object sender, EventArgs e)
        {
            //Al salir de la tab
            //Limpiar listas
            listDesordenados.Items.Clear();
            listOrdenados.Items.Clear();
            tabControl.TabPages.Remove(tabListas); //Quitar tabListas de las tab de tabControl
            //Se limpia el formulario
            txtCantidad.Clear();
            cmbMetodo.SelectedIndex = -1;
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text)) //Si el texto esta vacio o tiene solo espacios en blanco
            {
                errorProvider.SetError(txtCantidad, "Debe escribir una cantidad"); //Mostrar un error
            }
            else if (!txtCantidad.Text.IsNumber()) //Si el texto no es un numero entero positivo
            {
                errorProvider.SetError(txtCantidad, "Solo se admiten numeros enteros"); //Mostrar un error
            }
            else //Si todo esta bien
            {
                errorProvider.SetError(txtCantidad, string.Empty); //Quitar todos los errores
            }
        }

        private void toggleOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleOrden.Checked) //Si se chequea
                lblOrden.Text = "ASC"; //Cambiar el lbl por ASC
            else
                lblOrden.Text = "DESC"; //Cambiar por DESC
        }
    }
}
