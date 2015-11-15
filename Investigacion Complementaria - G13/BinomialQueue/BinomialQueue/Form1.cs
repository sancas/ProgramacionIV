using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinomialQueue
{
    public partial class Form1 : Form
    {
        private int PageCounter = 1;
        private List<BinomialQueue> QueueList = new List<BinomialQueue>();
        private List<int> IntList = new List<int>();
        private NewNode NuevoNodo;
        private NewQueue NuevaCola;
        private MergeQueues UnirColas;
        private ModifiedNode ModificarNodo;
        private BinomialQueue Q1, Q2, QNew; //Q1 y Q2 Serviran para unir colas y QNew sera la nueva cola
        private Graphics G;

        public Form1()
        {
            InitializeComponent();
            NuevoNodo = new NewNode();
            NuevaCola = new NewQueue();
            UnirColas = new MergeQueues();
            ModificarNodo = new ModifiedNode();
        }

        private void HabilitarBotones(bool isMin)
        {
            this.crearNodoToolStripMenuItem.Enabled = true;
            this.unirColasToolStripMenuItem.Enabled = true;
            this.extraerToolStripMenuItem.Enabled = true;
            this.identificarToolStripMenuItem.Enabled = true;
            this.modificarClaveToolStripMenuItem.Enabled = true;
            if (isMin) //Si es minimo
            {
                this.extraerToolStripMenuItem.Text = "Extraer Minimo";
                this.identificarToolStripMenuItem.Text = "Identificar Minimo";
                this.modificarClaveToolStripMenuItem.Text = "Disminuir Clave";
            } //Si es maximo
            else
            {
                this.extraerToolStripMenuItem.Text = "Extraer Maximo";
                this.identificarToolStripMenuItem.Text = "Identificar Maximo";
                this.modificarClaveToolStripMenuItem.Text = "Aumentar Clave";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PageControl.Location = new Point(0, menuStrip1.Height);
            PageControl.Height = 20;
            PageControl.Width = this.Width;
            Pizarra.Location = new Point(0, menuStrip1.Height + PageControl.Height);
            Pizarra.Width = this.Width;
            Pizarra.Height = this.Height - menuStrip1.Height - PageControl.Height;
            Pizarra.HorizontalScroll.Enabled = true;
            Pizarra.Visible = false;
            G = Pizarra.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Pizarra_Resize(object sender, EventArgs e)
        {
            G = null;
            G = Pizarra.CreateGraphics();
            QueueList[PageControl.SelectedIndex].Dibujar(G, 0, 0);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void crearNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoNodo.ShowDialog();
            if (NuevoNodo.crear)
            {
                if (QueueList[PageControl.SelectedIndex].ExisteNodo(NuevoNodo.Value))
                    MessageBox.Show("No se puede agregar el nodo, ya existe en la cola",
                        "Error duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    QueueList[PageControl.SelectedIndex].InsertarArbol(NuevoNodo.Value, G);
            }
            QueueList[PageControl.SelectedIndex].Dibujar(G, 0, 0);
        }

        private void extraerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            QueueList[PageControl.SelectedIndex].EliminarDatoHeap(G);
            this.Cursor = Cursors.Default;
        }

        private void modificarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarNodo.ShowDialog();
            if(ModificarNodo.crear)
            {
                if (QueueList[PageControl.SelectedIndex].ExisteNodo(ModificarNodo.NumeroNodoActual))
                {
                    if (!QueueList[PageControl.SelectedIndex].ExisteNodo(ModificarNodo.NumeroNodoNuevo))
                    {
                        G = Pizarra.CreateGraphics();
                        QueueList[PageControl.SelectedIndex].ModificarClaveHeap(ModificarNodo.NumeroNodoActual, ModificarNodo.NumeroNodoNuevo, G);
                    }
                    else
                    {
                        MessageBox.Show("El valor deseado para el nuevo nodo ya existe",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("El nodo inicial no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void identificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            QueueList[PageControl.SelectedIndex].MostrarDatoHeap(G);
            this.Cursor = Cursors.Default;
        }

        private void PageControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QueueList.Count != 0)
            {
                QueueList[PageControl.SelectedIndex].Dibujar(G, 0, 0);
                HabilitarBotones(QueueList[PageControl.SelectedIndex].isMin);
            }
        }

        private void unirColasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnirColas.Refresh(QueueList);
            UnirColas.ShowDialog();

            if (UnirColas.crear)
            {
                if (QueueList[UnirColas.Queue1Index].isMin == QueueList[UnirColas.Queue2Index].isMin)
                {
                    TabPage newTab;
                    QNew = new BinomialQueue();
                    QNew.isMin = QueueList[UnirColas.Queue1Index].isMin;
                    QueueList.Add(QNew);
                    Q1 = QueueList[UnirColas.Queue1Index];
                    Q2 = QueueList[UnirColas.Queue2Index];
                    newTab = new TabPage("Cola " + PageCounter.ToString() + "(" + (UnirColas.Queue1Index + 1).ToString() + " + " + (UnirColas.Queue2Index + 1).ToString() + ")");
                    PageControl.TabPages.Add(newTab);
                    PageControl.SelectedTab = newTab;
                    PageCounter++;
                    QNew.UnirColas(QNew, QueueList[UnirColas.Queue1Index], QueueList[UnirColas.Queue2Index], G);
                }
            }
        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(BinomialQueue BQ in QueueList)
            {
                BQ.Simulacion(true);
            }
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (BinomialQueue BQ in QueueList)
            {
                BQ.Simulacion(false);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PageControl.Width = this.Width;
            Pizarra.Width = this.Width;
            Pizarra.Height = this.Height - menuStrip1.Height - PageControl.Height;
        }

        private void crearColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCola.ShowDialog();
            if (NuevaCola.crear)
            {
                TabPage newTab;
                QNew = new BinomialQueue();
                if (NuevaCola.isMin)
                {
                    newTab = new TabPage("Cola " + PageCounter.ToString() + " (Min)");
                    QNew.isMin = true;
                }
                else
                {
                    newTab = new TabPage("Cola " + PageCounter.ToString() + " (Max)");
                    QNew.isMin = false;
                }
                QueueList.Add(QNew);
                PageControl.TabPages.Add(newTab);
                PageControl.SelectedTab = newTab;
                HabilitarBotones(NuevaCola.isMin);
                PageControl.Visible = true;
                Pizarra.Visible = true;
                PageCounter++;
            }
        }
    }
}
