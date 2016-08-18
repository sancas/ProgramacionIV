namespace MetodosDeOrdenamiento
{
    partial class frmPrincipal
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
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnShellsort = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 45);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(161, 62);
            this.btnBubbleSort.TabIndex = 0;
            this.btnBubbleSort.Text = "Burbuja";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnShellsort
            // 
            this.btnShellsort.Location = new System.Drawing.Point(196, 45);
            this.btnShellsort.Name = "btnShellsort";
            this.btnShellsort.Size = new System.Drawing.Size(161, 62);
            this.btnShellsort.TabIndex = 1;
            this.btnShellsort.Text = "Shellsorter";
            this.btnShellsort.UseVisualStyleBackColor = true;
            this.btnShellsort.Click += new System.EventHandler(this.btnShellsort_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(355, 24);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Seleccione un metodo de ordenamiento:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 118);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnShellsort);
            this.Controls.Add(this.btnBubbleSort);
            this.Name = "frmPrincipal";
            this.Text = "..:: Metodos de Ordenamiento ::..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnShellsort;
        private System.Windows.Forms.Label lblBienvenida;

    }
}

