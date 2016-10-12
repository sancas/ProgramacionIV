namespace Grafos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchNode = new System.Windows.Forms.Button();
            this.CMSCrearVertice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de grafos";
            // 
            // Pizarra
            // 
            this.Pizarra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pizarra.Location = new System.Drawing.Point(12, 60);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(695, 413);
            this.Pizarra.TabIndex = 1;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVerticeToolStripMenuItem});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(149, 26);
            // 
            // nuevoVerticeToolStripMenuItem
            // 
            this.nuevoVerticeToolStripMenuItem.Name = "nuevoVerticeToolStripMenuItem";
            this.nuevoVerticeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevoVerticeToolStripMenuItem.Text = "Nuevo Vertice";
            this.nuevoVerticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVerticeToolStripMenuItem_Click);
            // 
            // btnSearchNode
            // 
            this.btnSearchNode.Location = new System.Drawing.Point(632, 31);
            this.btnSearchNode.Name = "btnSearchNode";
            this.btnSearchNode.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNode.TabIndex = 2;
            this.btnSearchNode.Text = "Buscar nodo";
            this.btnSearchNode.UseVisualStyleBackColor = true;
            this.btnSearchNode.Click += new System.EventHandler(this.btnSearchNode_Click);
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 485);
            this.Controls.Add(this.btnSearchNode);
            this.Controls.Add(this.Pizarra);
            this.Controls.Add(this.label1);
            this.Name = "Simulador";
            this.Text = "Form1";
            this.CMSCrearVertice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVerticeToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchNode;
    }
}

