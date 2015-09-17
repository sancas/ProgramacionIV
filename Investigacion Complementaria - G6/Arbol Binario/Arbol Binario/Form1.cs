using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arbol_Binario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Desmarcador
        protected void desmarcarRadioButtons()
        {
            rbtnTotal.Checked = false;
            rbtnMultiplosDos.Checked = false;
            rbtnMultiplosTres.Checked = false;
            rbtnMultiplosCinco.Checked = false;
        }

        //Deshabilitadores y Habilitadores
        protected void habilitarButtons()
        {
            btnInOrden.Enabled = true;
            btnPostOrden.Enabled = true;
            btnPreOrden.Enabled = true;
        }
        protected void habilitarRadioButtons()
        {
            rbtnTotal.Enabled = true;
            rbtnMultiplosDos.Enabled = true;
            rbtnMultiplosTres.Enabled = true;
            rbtnMultiplosCinco.Enabled = true;
        }
        protected void deshabilitarButtons()
        {
            btnInOrden.Enabled = false;
            btnPostOrden.Enabled = false;
            btnPreOrden.Enabled = false;
        }
        protected void deshabilitarRadioButtons()
        {
            rbtnTotal.Enabled = false;
            rbtnMultiplosDos.Enabled = false;
            rbtnMultiplosTres.Enabled = false;
            rbtnMultiplosCinco.Enabled = false;
        }


        //Declaracion de variables a utilizar
        int Dato = 0;
        int cont = 0;
        int suma = 0, suma2 = 0, suma3 = 0, suma5 = 0;

        Arbol_Binario myTree = new Arbol_Binario(null); //Creacion del objeto Arbol
        Graphics g;                                     //Definicion del objeto grafico

        //Evento del formulario que permitira dibujar el Arbol Binario
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            myTree.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            Dato = int.Parse(txtNumero.Text);
            myTree.Insertar(Dato);
            txtNumero.Clear();
            txtNumero.Focus();

            cont++;
            suma += Dato;
            if(Dato%2 == 0)
            {
                suma2 += Dato;
            }
            if(Dato%3 == 0)
            {
                suma3 += Dato;
            }
            if(Dato%5 == 0)
            {
                suma5 += Dato;
            }

            lblAltura.Text = "Altura: " + myTree.calcularAltura(myTree.Raiz);
            lblAltura.Visible = true;
            habilitarButtons();
            habilitarRadioButtons();
            desmarcarRadioButtons();
            Refresh();
        }

        private void btnDelNode_Click(object sender, EventArgs e)
        {
            Dato = int.Parse(txtNumero.Text);
            myTree.Eliminar(Dato);
            txtNumero.Clear();
            txtNumero.Focus();

            cont--;
            suma -= Dato;
            if (Dato%2 == 0)
            {
                suma2 -= Dato;
            }
            if (Dato%3 == 0)
            {
                suma3 -= Dato;
            }
            if (Dato%5 == 0)
            {
                suma5 -= Dato;
            }

            if (cont == 0)
            {
                deshabilitarButtons();
                deshabilitarRadioButtons();
                lblAltura.Visible = false;
            }
            desmarcarRadioButtons();
            Refresh();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            Refresh();
            if (txtNumero.Text != String.Empty && txtNumero.Text != "-")
            {
                try
                {
                    int num;
                    num = Convert.ToInt32(txtNumero.Text);
                    if (num > 99 || num < -99)
                    {
                        txtNumero.BackColor = Color.Orange;
                        btnAddNode.Enabled = false;
                        btnDelNode.Enabled = false;
                        MessageBox.Show("No se admiten numeros tan grandes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (myTree.existe(num, myTree.Raiz))
                        {
                            g = this.CreateGraphics();
                            btnAddNode.Enabled = false;
                            btnDelNode.Enabled = true;
                            myTree.resaltar(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, num);
                            txtNumero.BackColor = Color.Red;
                        }
                        else
                        {
                            btnAddNode.Enabled = true;
                            btnDelNode.Enabled = false;
                            txtNumero.BackColor = Color.Green;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No se admiten numeros tan grandes 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.BackColor = Color.Orange;
                }
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                btnAddNode.Enabled = false;
                btnDelNode.Enabled = false;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            desmarcarRadioButtons();
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            desmarcarRadioButtons();
            txtNumero.Clear();
            deshabilitarButtons();
            deshabilitarRadioButtons();
            g = this.CreateGraphics();
            myTree.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, false, true, false);
            habilitarButtons();
            habilitarRadioButtons();
            this.Cursor = Cursors.Default;
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            desmarcarRadioButtons();
            txtNumero.Clear();
            deshabilitarButtons();
            deshabilitarRadioButtons();
            g = this.CreateGraphics();
            myTree.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, false, false, true);
            habilitarButtons();
            habilitarRadioButtons();
            this.Cursor = Cursors.Default;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            desmarcarRadioButtons();
            txtNumero.Clear();
            deshabilitarButtons();
            deshabilitarRadioButtons();
            g = this.CreateGraphics();
            myTree.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, true, false, false);
            habilitarButtons();
            habilitarRadioButtons();
            this.Cursor = Cursors.Default;
        }

        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            int valor = 100;
            Refresh();
            txtNumero.Clear();
            g = this.CreateGraphics();
            valor = myTree.seleccionar(g, this.Font, Brushes.White, Pens.Black, myTree.Raiz, e.Location);
            if (valor != 100)
            {
                txtNumero.Text = valor.ToString();
            }
        }

        private void rbtnTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTotal.Checked)
            {
                Refresh();
                txtNumero.Clear();
                g = this.CreateGraphics();
                myTree.sumar(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, 1);
                lblSumatoria.Visible = true;
                lblSumatoria.Text = "Suma: " + suma.ToString();
            }
            else
                lblSumatoria.Visible = false;
        }

        private void rbtnMultiplosDos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMultiplosDos.Checked)
            {
                Refresh();
                txtNumero.Clear();
                g = this.CreateGraphics();
                myTree.sumar(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, 2);
                lblSumatoria.Visible = true;
                lblSumatoria.Text = "Suma: " + suma2.ToString();
            }
            else
                lblSumatoria.Visible = false;
        }

        private void rbtnMultiplosTres_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMultiplosTres.Checked)
            {
                Refresh();
                txtNumero.Clear();
                g = this.CreateGraphics();
                myTree.sumar(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, 3);
                lblSumatoria.Visible = true;
                lblSumatoria.Text = "Suma: " + suma3.ToString();
            }
            else
                lblSumatoria.Visible = false;
        }

        private void rbtnMultiplosCinco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMultiplosCinco.Checked)
            {
                Refresh();
                txtNumero.Clear();
                g = this.CreateGraphics();
                myTree.sumar(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, myTree.Raiz, 5);
                lblSumatoria.Visible = true;
                lblSumatoria.Text = "Suma: " + suma5.ToString();
            }
            else
                lblSumatoria.Visible = false;
        }
    }
}
