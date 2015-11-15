namespace BinomialQueue
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unirColasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.PageControl = new System.Windows.Forms.TabControl();
            this.MenuItemSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearColaToolStripMenuItem,
            this.MenuItemSimulation,
            this.crearNodoToolStripMenuItem,
            this.extraerToolStripMenuItem,
            this.modificarClaveToolStripMenuItem,
            this.identificarToolStripMenuItem,
            this.unirColasToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearColaToolStripMenuItem
            // 
            this.crearColaToolStripMenuItem.Name = "crearColaToolStripMenuItem";
            this.crearColaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.crearColaToolStripMenuItem.Text = "Crear Cola";
            this.crearColaToolStripMenuItem.Click += new System.EventHandler(this.crearColaToolStripMenuItem_Click);
            // 
            // crearNodoToolStripMenuItem
            // 
            this.crearNodoToolStripMenuItem.Enabled = false;
            this.crearNodoToolStripMenuItem.Name = "crearNodoToolStripMenuItem";
            this.crearNodoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.crearNodoToolStripMenuItem.Text = "Crear Nodo";
            this.crearNodoToolStripMenuItem.Click += new System.EventHandler(this.crearNodoToolStripMenuItem_Click);
            // 
            // extraerToolStripMenuItem
            // 
            this.extraerToolStripMenuItem.Enabled = false;
            this.extraerToolStripMenuItem.Name = "extraerToolStripMenuItem";
            this.extraerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.extraerToolStripMenuItem.Text = "Extraer";
            this.extraerToolStripMenuItem.Click += new System.EventHandler(this.extraerToolStripMenuItem_Click);
            // 
            // modificarClaveToolStripMenuItem
            // 
            this.modificarClaveToolStripMenuItem.Enabled = false;
            this.modificarClaveToolStripMenuItem.Name = "modificarClaveToolStripMenuItem";
            this.modificarClaveToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.modificarClaveToolStripMenuItem.Text = "Modificar Clave";
            this.modificarClaveToolStripMenuItem.Click += new System.EventHandler(this.modificarClaveToolStripMenuItem_Click);
            // 
            // identificarToolStripMenuItem
            // 
            this.identificarToolStripMenuItem.Enabled = false;
            this.identificarToolStripMenuItem.Name = "identificarToolStripMenuItem";
            this.identificarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.identificarToolStripMenuItem.Text = "Identificar";
            this.identificarToolStripMenuItem.Click += new System.EventHandler(this.identificarToolStripMenuItem_Click);
            // 
            // unirColasToolStripMenuItem
            // 
            this.unirColasToolStripMenuItem.Enabled = false;
            this.unirColasToolStripMenuItem.Name = "unirColasToolStripMenuItem";
            this.unirColasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.unirColasToolStripMenuItem.Text = "Unir Colas";
            this.unirColasToolStripMenuItem.Click += new System.EventHandler(this.unirColasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Pizarra
            // 
            this.Pizarra.BackColor = System.Drawing.SystemColors.Info;
            this.Pizarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pizarra.Location = new System.Drawing.Point(277, 94);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(200, 100);
            this.Pizarra.TabIndex = 1;
            this.Pizarra.Resize += new System.EventHandler(this.Pizarra_Resize);
            // 
            // PageControl
            // 
            this.PageControl.Location = new System.Drawing.Point(25, 37);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedIndex = 0;
            this.PageControl.Size = new System.Drawing.Size(200, 157);
            this.PageControl.TabIndex = 2;
            this.PageControl.Visible = false;
            this.PageControl.SelectedIndexChanged += new System.EventHandler(this.PageControl_SelectedIndexChanged);
            // 
            // MenuItemSimulation
            // 
            this.MenuItemSimulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem,
            this.noToolStripMenuItem});
            this.MenuItemSimulation.Name = "MenuItemSimulation";
            this.MenuItemSimulation.Size = new System.Drawing.Size(78, 20);
            this.MenuItemSimulation.Text = "Simulacion";
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siToolStripMenuItem.Text = "Si";
            this.siToolStripMenuItem.Click += new System.EventHandler(this.siToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 402);
            this.Controls.Add(this.PageControl);
            this.Controls.Add(this.Pizarra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simulador de colas binomiales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unirColasToolStripMenuItem;
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.TabControl PageControl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSimulation;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
    }
}

