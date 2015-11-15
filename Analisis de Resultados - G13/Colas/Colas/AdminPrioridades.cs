using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class AdminPrioridades : Form
    {
        private int cantidadDePrioridades;
        public AdminPrioridades()
        {
            InitializeComponent();
        }

        public AdminPrioridades(int cantidad)
        {
            InitializeComponent();
            this.cantidadDePrioridades = cantidad;
        }

        private void AdminPrioridades_Load(object sender, EventArgs e)
        {
            for (int x = 1; x <= cantidadDePrioridades; x++)
                listPrioridades.Items.Add(x);
        }

        private void listPrioridades_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDown.Enabled = true;
            btnUp.Enabled = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listPrioridades.SelectedItem == null || listPrioridades.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listPrioridades.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listPrioridades.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listPrioridades.SelectedItem;

            // Removing removable element
            listPrioridades.Items.Remove(selected);
            // Insert it in new position
            listPrioridades.Items.Insert(newIndex, selected);
            // Restore selection
            listPrioridades.SetSelected(newIndex, true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listPrioridades.Items.Add(++cantidadDePrioridades);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listPrioridades.Items.Remove(listPrioridades.SelectedItem);
        }
    }
}
