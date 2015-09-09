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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.cmbMetodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rdbtnLetras = new System.Windows.Forms.RadioButton();
            this.rdbtnNumeros = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnExternFile = new System.Windows.Forms.RadioButton();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnManual = new System.Windows.Forms.RadioButton();
            this.tabSimulacionHeapsort = new System.Windows.Forms.TabControl();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rdbtnAscendente = new System.Windows.Forms.RadioButton();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSimulacionHeapsort.SuspendLayout();
            this.tabSimulacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(104, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(210, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 126);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lblTiempo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Simulacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(829, 84);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(144, 13);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "Tiempo de ejecucion: 00.00s";
            this.lblTiempo.Visible = false;
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.Items.AddRange(new object[] {
            "QuickSort",
            "MergeSort",
            "HeapSort"});
            this.cmbMetodos.Location = new System.Drawing.Point(875, 71);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodos.TabIndex = 5;
            this.cmbMetodos.SelectedIndexChanged += new System.EventHandler(this.cmbMetodos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 74);
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
            // rdbtnLetras
            // 
            this.rdbtnLetras.AutoSize = true;
            this.rdbtnLetras.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbtnLetras.Location = new System.Drawing.Point(79, 20);
            this.rdbtnLetras.Name = "rdbtnLetras";
            this.rdbtnLetras.Size = new System.Drawing.Size(54, 17);
            this.rdbtnLetras.TabIndex = 8;
            this.rdbtnLetras.Text = "Letras";
            this.rdbtnLetras.UseVisualStyleBackColor = true;
            this.rdbtnLetras.CheckedChanged += new System.EventHandler(this.rdbtnLetras_CheckedChanged);
            // 
            // rdbtnNumeros
            // 
            this.rdbtnNumeros.AutoSize = true;
            this.rdbtnNumeros.Checked = true;
            this.rdbtnNumeros.Location = new System.Drawing.Point(6, 20);
            this.rdbtnNumeros.Name = "rdbtnNumeros";
            this.rdbtnNumeros.Size = new System.Drawing.Size(67, 17);
            this.rdbtnNumeros.TabIndex = 9;
            this.rdbtnNumeros.TabStop = true;
            this.rdbtnNumeros.Text = "Numeros";
            this.rdbtnNumeros.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNumeros);
            this.groupBox1.Controls.Add(this.rdbtnLetras);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija una opcion:";
            // 
            // rdbtnExternFile
            // 
            this.rdbtnExternFile.AutoSize = true;
            this.rdbtnExternFile.Location = new System.Drawing.Point(150, 20);
            this.rdbtnExternFile.Name = "rdbtnExternFile";
            this.rdbtnExternFile.Size = new System.Drawing.Size(99, 17);
            this.rdbtnExternFile.TabIndex = 10;
            this.rdbtnExternFile.Text = "Archivo externo";
            this.rdbtnExternFile.UseVisualStyleBackColor = true;
            this.rdbtnExternFile.CheckedChanged += new System.EventHandler(this.rdbtnExternFile_CheckedChanged);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(255, 17);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(242, 20);
            this.txtArchivo.TabIndex = 11;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Enabled = false;
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(503, 15);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarArchivo.TabIndex = 12;
            this.btnSeleccionarArchivo.Text = "Seleccionar";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnManual);
            this.groupBox2.Controls.Add(this.btnSeleccionarArchivo);
            this.groupBox2.Controls.Add(this.rdbtnExternFile);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 51);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuente de datos";
            // 
            // rdbtnManual
            // 
            this.rdbtnManual.AutoSize = true;
            this.rdbtnManual.Checked = true;
            this.rdbtnManual.Location = new System.Drawing.Point(14, 20);
            this.rdbtnManual.Name = "rdbtnManual";
            this.rdbtnManual.Size = new System.Drawing.Size(130, 17);
            this.rdbtnManual.TabIndex = 11;
            this.rdbtnManual.TabStop = true;
            this.rdbtnManual.Text = "Ingresar Manualmente";
            this.rdbtnManual.UseVisualStyleBackColor = true;
            // 
            // tabSimulacionHeapsort
            // 
            this.tabSimulacionHeapsort.Controls.Add(this.tabSimulacion);
            this.tabSimulacionHeapsort.Enabled = false;
            this.tabSimulacionHeapsort.Location = new System.Drawing.Point(14, 228);
            this.tabSimulacionHeapsort.Name = "tabSimulacionHeapsort";
            this.tabSimulacionHeapsort.SelectedIndex = 0;
            this.tabSimulacionHeapsort.Size = new System.Drawing.Size(984, 351);
            this.tabSimulacionHeapsort.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSimulacionHeapsort.TabIndex = 18;
            this.tabSimulacionHeapsort.Visible = false;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Controls.Add(this.label3);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(976, 325);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "HeapSort";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            this.tabSimulacion.Paint += new System.Windows.Forms.PaintEventHandler(this.tabSimulacion_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(850, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiempo de ejecucion: 00.00s";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnDescendente);
            this.groupBox3.Controls.Add(this.rdbtnAscendente);
            this.groupBox3.Location = new System.Drawing.Point(166, 12);
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
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(453, 74);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(356, 13);
            this.lblExtraInfo.TabIndex = 20;
            this.lblExtraInfo.Text = "Haga click en agregar cuando haya terminado de configurar sus opciones";
            this.lblExtraInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 228);
            this.Controls.Add(this.lblExtraInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabSimulacionHeapsort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMetodos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Metodos de ordenamientos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSimulacionHeapsort.ResumeLayout(false);
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbMetodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rdbtnLetras;
        private System.Windows.Forms.RadioButton rdbtnNumeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.RadioButton rdbtnExternFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnManual;
        private System.Windows.Forms.TabControl tabSimulacionHeapsort;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnDescendente;
        private System.Windows.Forms.RadioButton rdbtnAscendente;
        private System.Windows.Forms.Label lblExtraInfo;
    }
}

