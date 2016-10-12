namespace Grafo
{
    partial class Simulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SimuladorStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CMSCrearVertice = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.nuevoVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.cargarFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoProfundidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoAnchuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SimuladorStyleManager)).BeginInit();
            this.CMSCrearVertice.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimuladorStyleManager
            // 
            this.SimuladorStyleManager.Owner = this;
            this.SimuladorStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVerticeToolStripMenuItem,
            this.buscarNodoToolStripMenuItem,
            this.cargarFondoToolStripMenuItem,
            this.guardarGrafoToolStripMenuItem,
            this.cargarGrafoToolStripMenuItem,
            this.recorridoProfundidadToolStripMenuItem,
            this.recorridoAnchuraToolStripMenuItem});
            this.CMSCrearVertice.Name = "metroContextMenu1";
            this.CMSCrearVertice.Size = new System.Drawing.Size(195, 180);
            // 
            // nuevoVerticeToolStripMenuItem
            // 
            this.nuevoVerticeToolStripMenuItem.Name = "nuevoVerticeToolStripMenuItem";
            this.nuevoVerticeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoVerticeToolStripMenuItem.Text = "Nuevo Vertice";
            this.nuevoVerticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVerticeToolStripMenuItem_Click);
            // 
            // buscarNodoToolStripMenuItem
            // 
            this.buscarNodoToolStripMenuItem.Name = "buscarNodoToolStripMenuItem";
            this.buscarNodoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarNodoToolStripMenuItem.Text = "Buscar Nodo";
            this.buscarNodoToolStripMenuItem.Click += new System.EventHandler(this.buscarNodoToolStripMenuItem_Click);
            // 
            // guardarGrafoToolStripMenuItem
            // 
            this.guardarGrafoToolStripMenuItem.Name = "guardarGrafoToolStripMenuItem";
            this.guardarGrafoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarGrafoToolStripMenuItem.Text = "Guardar Grafo";
            this.guardarGrafoToolStripMenuItem.Click += new System.EventHandler(this.guardarGrafoToolStripMenuItem_Click);
            // 
            // cargarGrafoToolStripMenuItem
            // 
            this.cargarGrafoToolStripMenuItem.Name = "cargarGrafoToolStripMenuItem";
            this.cargarGrafoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarGrafoToolStripMenuItem.Text = "Cargar Grafo";
            this.cargarGrafoToolStripMenuItem.Click += new System.EventHandler(this.cargarGrafoToolStripMenuItem_Click);
            // 
            // Pizarra
            // 
            this.Pizarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pizarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pizarra.Location = new System.Drawing.Point(20, 60);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(434, 342);
            this.Pizarra.TabIndex = 1;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // cargarFondoToolStripMenuItem
            // 
            this.cargarFondoToolStripMenuItem.Name = "cargarFondoToolStripMenuItem";
            this.cargarFondoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarFondoToolStripMenuItem.Text = "Cargar Fondo";
            this.cargarFondoToolStripMenuItem.Click += new System.EventHandler(this.cargarFondoToolStripMenuItem_Click);
            // 
            // recorridoProfundidadToolStripMenuItem
            // 
            this.recorridoProfundidadToolStripMenuItem.Name = "recorridoProfundidadToolStripMenuItem";
            this.recorridoProfundidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recorridoProfundidadToolStripMenuItem.Text = "Recorrido Profundidad";
            this.recorridoProfundidadToolStripMenuItem.Click += new System.EventHandler(this.recorridoProfundidadToolStripMenuItem_Click);
            // 
            // recorridoAnchuraToolStripMenuItem
            // 
            this.recorridoAnchuraToolStripMenuItem.Name = "recorridoAnchuraToolStripMenuItem";
            this.recorridoAnchuraToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recorridoAnchuraToolStripMenuItem.Text = "Recorrido Anchura";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 422);
            this.Controls.Add(this.Pizarra);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Simulador";
            this.Resizable = false;
            this.Text = "Simulador de Grafos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SimuladorStyleManager)).EndInit();
            this.CMSCrearVertice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager SimuladorStyleManager;
        private MetroFramework.Controls.MetroContextMenu CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVerticeToolStripMenuItem;
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.ToolStripMenuItem buscarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarGrafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarGrafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoProfundidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoAnchuraToolStripMenuItem;
    }
}

