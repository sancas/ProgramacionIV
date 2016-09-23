namespace HeapSort
{
    partial class frmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnNumeros = new System.Windows.Forms.RadioButton();
            this.rdbtnLetras = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSimulacion = new System.Windows.Forms.TabControl();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControlSimulacion.SuspendLayout();
            this.tabSimulacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNumeros);
            this.groupBox1.Controls.Add(this.rdbtnLetras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 40);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija una opcion:";
            // 
            // rdbtnNumeros
            // 
            this.rdbtnNumeros.AutoSize = true;
            this.rdbtnNumeros.Location = new System.Drawing.Point(83, 17);
            this.rdbtnNumeros.Name = "rdbtnNumeros";
            this.rdbtnNumeros.Size = new System.Drawing.Size(67, 17);
            this.rdbtnNumeros.TabIndex = 9;
            this.rdbtnNumeros.TabStop = true;
            this.rdbtnNumeros.Text = "Numeros";
            this.rdbtnNumeros.UseVisualStyleBackColor = true;
            // 
            // rdbtnLetras
            // 
            this.rdbtnLetras.AutoSize = true;
            this.rdbtnLetras.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbtnLetras.Location = new System.Drawing.Point(214, 17);
            this.rdbtnLetras.Name = "rdbtnLetras";
            this.rdbtnLetras.Size = new System.Drawing.Size(54, 17);
            this.rdbtnLetras.TabIndex = 8;
            this.rdbtnLetras.TabStop = true;
            this.rdbtnLetras.Text = "Letras";
            this.rdbtnLetras.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(924, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(843, 26);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(762, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(656, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insertar numero:";
            // 
            // tabControlSimulacion
            // 
            this.tabControlSimulacion.Controls.Add(this.tabSimulacion);
            this.tabControlSimulacion.Location = new System.Drawing.Point(12, 58);
            this.tabControlSimulacion.Name = "tabControlSimulacion";
            this.tabControlSimulacion.SelectedIndex = 0;
            this.tabControlSimulacion.Size = new System.Drawing.Size(987, 577);
            this.tabControlSimulacion.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlSimulacion.TabIndex = 17;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Controls.Add(this.lblTiempo);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(979, 551);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Ver Simulacion";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            this.tabSimulacion.Paint += new System.Windows.Forms.PaintEventHandler(this.tabSimulacion_Paint);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(850, 534);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(144, 13);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "Tiempo de ejecucion: 00.00s";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 639);
            this.Controls.Add(this.tabControlSimulacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de ordenamiento HeapSort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlSimulacion.ResumeLayout(false);
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnNumeros;
        private System.Windows.Forms.RadioButton rdbtnLetras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlSimulacion;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.Label lblTiempo;

    }
}

