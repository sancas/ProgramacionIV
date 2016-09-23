namespace MetodosDeOrdenamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.cmbMetodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rdbtnAscendente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDesordenados = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listOrdenados = new System.Windows.Forms.ListBox();
            this.txtComplejidad = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad numeros:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(116, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(88, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(210, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(291, 69);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.Items.AddRange(new object[] {
            "BubbleSort",
            "SelectionSort",
            "InsertionSort",
            "ShellSort",
            "MergeSort",
            "QuickSort",
            "HeapSort"});
            this.cmbMetodos.Location = new System.Drawing.Point(326, 31);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Metodo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(372, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnDescendente);
            this.groupBox3.Controls.Add(this.rdbtnAscendente);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 51);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de ordenamiento";
            // 
            // rdbtnDescendente
            // 
            this.rdbtnDescendente.AutoSize = true;
            this.rdbtnDescendente.Location = new System.Drawing.Point(125, 20);
            this.rdbtnDescendente.Name = "rdbtnDescendente";
            this.rdbtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdbtnDescendente.TabIndex = 1;
            this.rdbtnDescendente.Text = "Descendente";
            this.rdbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rdbtnAscendente
            // 
            this.rdbtnAscendente.AutoSize = true;
            this.rdbtnAscendente.Checked = true;
            this.rdbtnAscendente.Location = new System.Drawing.Point(6, 20);
            this.rdbtnAscendente.Name = "rdbtnAscendente";
            this.rdbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.rdbtnAscendente.TabIndex = 0;
            this.rdbtnAscendente.TabStop = true;
            this.rdbtnAscendente.Text = "Ascendente";
            this.rdbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDesordenados);
            this.groupBox1.Location = new System.Drawing.Point(15, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 177);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista desordenada";
            // 
            // listDesordenados
            // 
            this.listDesordenados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDesordenados.FormattingEnabled = true;
            this.listDesordenados.Location = new System.Drawing.Point(3, 16);
            this.listDesordenados.Name = "listDesordenados";
            this.listDesordenados.Size = new System.Drawing.Size(169, 158);
            this.listDesordenados.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listOrdenados);
            this.groupBox2.Location = new System.Drawing.Point(272, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 177);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista ordenada";
            // 
            // listOrdenados
            // 
            this.listOrdenados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOrdenados.FormattingEnabled = true;
            this.listOrdenados.Location = new System.Drawing.Point(3, 16);
            this.listOrdenados.Name = "listOrdenados";
            this.listOrdenados.Size = new System.Drawing.Size(169, 158);
            this.listOrdenados.TabIndex = 0;
            // 
            // txtComplejidad
            // 
            this.txtComplejidad.Location = new System.Drawing.Point(15, 301);
            this.txtComplejidad.Name = "txtComplejidad";
            this.txtComplejidad.ReadOnly = true;
            this.txtComplejidad.Size = new System.Drawing.Size(432, 20);
            this.txtComplejidad.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 326);
            this.Controls.Add(this.txtComplejidad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMetodos);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Metodos de ordenamientos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ComboBox cmbMetodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnDescendente;
        private System.Windows.Forms.RadioButton rdbtnAscendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listDesordenados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listOrdenados;
        private System.Windows.Forms.TextBox txtComplejidad;
    }
}

