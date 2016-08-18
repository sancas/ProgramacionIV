namespace Problema2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabInformacionPersonal = new MetroFramework.Controls.MetroTabPage();
            this.lblEdadBarCount = new MetroFramework.Controls.MetroLabel();
            this.rdbtnFemenino = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnMasculino = new MetroFramework.Controls.MetroRadioButton();
            this.edadBar = new MetroFramework.Controls.MetroTrackBar();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.txtSalarioBruto = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabDescuentosSalarios = new MetroFramework.Controls.MetroTabPage();
            this.txtSalarioLiquido = new MetroFramework.Controls.MetroTextBox();
            this.txtDescAFP = new MetroFramework.Controls.MetroTextBox();
            this.txtDescRenta = new MetroFramework.Controls.MetroTextBox();
            this.txtDescISSS = new MetroFramework.Controls.MetroTextBox();
            this.txtSalarioB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblEdad = new MetroFramework.Controls.MetroLabel();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.pictureSexo = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.nombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.apellidoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.salarioBrutoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sexoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabInformacionPersonal.SuspendLayout();
            this.tabDescuentosSalarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioBrutoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabInformacionPersonal);
            this.metroTabControl1.Controls.Add(this.tabDescuentosSalarios);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(496, 334);
            this.metroTabControl1.TabIndex = 0;
            // 
            // tabInformacionPersonal
            // 
            this.tabInformacionPersonal.Controls.Add(this.lblEdadBarCount);
            this.tabInformacionPersonal.Controls.Add(this.rdbtnFemenino);
            this.tabInformacionPersonal.Controls.Add(this.rdbtnMasculino);
            this.tabInformacionPersonal.Controls.Add(this.edadBar);
            this.tabInformacionPersonal.Controls.Add(this.btnCalcular);
            this.tabInformacionPersonal.Controls.Add(this.txtSalarioBruto);
            this.tabInformacionPersonal.Controls.Add(this.txtApellidos);
            this.tabInformacionPersonal.Controls.Add(this.txtNombres);
            this.tabInformacionPersonal.Controls.Add(this.metroLabel5);
            this.tabInformacionPersonal.Controls.Add(this.lblSexo);
            this.tabInformacionPersonal.Controls.Add(this.metroLabel3);
            this.tabInformacionPersonal.Controls.Add(this.metroLabel2);
            this.tabInformacionPersonal.Controls.Add(this.metroLabel1);
            this.tabInformacionPersonal.HorizontalScrollbarBarColor = true;
            this.tabInformacionPersonal.Location = new System.Drawing.Point(4, 35);
            this.tabInformacionPersonal.Name = "tabInformacionPersonal";
            this.tabInformacionPersonal.Size = new System.Drawing.Size(488, 295);
            this.tabInformacionPersonal.TabIndex = 0;
            this.tabInformacionPersonal.Text = "Información personal";
            this.tabInformacionPersonal.VerticalScrollbarBarColor = true;
            this.tabInformacionPersonal.Enter += new System.EventHandler(this.tabInformacionPersonal_Enter);
            // 
            // lblEdadBarCount
            // 
            this.lblEdadBarCount.AutoSize = true;
            this.lblEdadBarCount.Location = new System.Drawing.Point(229, 109);
            this.lblEdadBarCount.Name = "lblEdadBarCount";
            this.lblEdadBarCount.Size = new System.Drawing.Size(21, 19);
            this.lblEdadBarCount.TabIndex = 21;
            this.lblEdadBarCount.Text = "18";
            // 
            // rdbtnFemenino
            // 
            this.rdbtnFemenino.AutoSize = true;
            this.rdbtnFemenino.Location = new System.Drawing.Point(229, 167);
            this.rdbtnFemenino.Name = "rdbtnFemenino";
            this.rdbtnFemenino.Size = new System.Drawing.Size(76, 15);
            this.rdbtnFemenino.TabIndex = 5;
            this.rdbtnFemenino.TabStop = true;
            this.rdbtnFemenino.Text = "Femenino";
            this.rdbtnFemenino.UseVisualStyleBackColor = true;
            this.rdbtnFemenino.CheckedChanged += new System.EventHandler(this.rdbtnFemenino_CheckedChanged);
            // 
            // rdbtnMasculino
            // 
            this.rdbtnMasculino.AutoSize = true;
            this.rdbtnMasculino.Location = new System.Drawing.Point(229, 146);
            this.rdbtnMasculino.Name = "rdbtnMasculino";
            this.rdbtnMasculino.Size = new System.Drawing.Size(78, 15);
            this.rdbtnMasculino.TabIndex = 4;
            this.rdbtnMasculino.TabStop = true;
            this.rdbtnMasculino.Text = "Masculino";
            this.rdbtnMasculino.UseVisualStyleBackColor = true;
            this.rdbtnMasculino.CheckedChanged += new System.EventHandler(this.rdbtnMasculino_CheckedChanged);
            // 
            // edadBar
            // 
            this.edadBar.BackColor = System.Drawing.Color.Transparent;
            this.edadBar.Location = new System.Drawing.Point(256, 108);
            this.edadBar.Maximum = 105;
            this.edadBar.Minimum = 18;
            this.edadBar.Name = "edadBar";
            this.edadBar.Size = new System.Drawing.Size(111, 23);
            this.edadBar.TabIndex = 3;
            this.edadBar.Value = 18;
            this.edadBar.ValueChanged += new System.EventHandler(this.edadBar_ValueChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(173, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(229, 198);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.PromptText = "$";
            this.txtSalarioBruto.Size = new System.Drawing.Size(138, 23);
            this.txtSalarioBruto.TabIndex = 6;
            this.txtSalarioBruto.Text = " ";
            this.txtSalarioBruto.Validated += new System.EventHandler(this.txtSalarioBruto_Validated);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(229, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(138, 23);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Validated += new System.EventHandler(this.txtApellidos_Validated);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(229, 26);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(138, 23);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Validated += new System.EventHandler(this.txtNombres_Validated);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(89, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Salario bruto";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSexo.Location = new System.Drawing.Point(91, 148);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 25);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(91, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Edad";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(89, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Apellidos";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(89, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Nombres";
            // 
            // tabDescuentosSalarios
            // 
            this.tabDescuentosSalarios.Controls.Add(this.txtSalarioLiquido);
            this.tabDescuentosSalarios.Controls.Add(this.txtDescAFP);
            this.tabDescuentosSalarios.Controls.Add(this.txtDescRenta);
            this.tabDescuentosSalarios.Controls.Add(this.txtDescISSS);
            this.tabDescuentosSalarios.Controls.Add(this.txtSalarioB);
            this.tabDescuentosSalarios.Controls.Add(this.metroLabel9);
            this.tabDescuentosSalarios.Controls.Add(this.lblEdad);
            this.tabDescuentosSalarios.Controls.Add(this.lblApellido);
            this.tabDescuentosSalarios.Controls.Add(this.lblNombre);
            this.tabDescuentosSalarios.Controls.Add(this.pictureSexo);
            this.tabDescuentosSalarios.Controls.Add(this.metroLabel8);
            this.tabDescuentosSalarios.Controls.Add(this.metroLabel7);
            this.tabDescuentosSalarios.Controls.Add(this.metroLabel6);
            this.tabDescuentosSalarios.Controls.Add(this.metroLabel4);
            this.tabDescuentosSalarios.HorizontalScrollbarBarColor = true;
            this.tabDescuentosSalarios.Location = new System.Drawing.Point(4, 35);
            this.tabDescuentosSalarios.Name = "tabDescuentosSalarios";
            this.tabDescuentosSalarios.Size = new System.Drawing.Size(488, 295);
            this.tabDescuentosSalarios.TabIndex = 1;
            this.tabDescuentosSalarios.Text = "Descuentos del salario";
            this.tabDescuentosSalarios.VerticalScrollbarBarColor = true;
            this.tabDescuentosSalarios.Enter += new System.EventHandler(this.tabDescuentosSalarios_Enter);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(401, 252);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(75, 23);
            this.txtSalarioLiquido.TabIndex = 15;
            this.txtSalarioLiquido.Text = "$";
            // 
            // txtDescAFP
            // 
            this.txtDescAFP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescAFP.Location = new System.Drawing.Point(401, 227);
            this.txtDescAFP.Name = "txtDescAFP";
            this.txtDescAFP.ReadOnly = true;
            this.txtDescAFP.Size = new System.Drawing.Size(75, 23);
            this.txtDescAFP.TabIndex = 14;
            this.txtDescAFP.Text = "$";
            // 
            // txtDescRenta
            // 
            this.txtDescRenta.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescRenta.Location = new System.Drawing.Point(401, 202);
            this.txtDescRenta.Name = "txtDescRenta";
            this.txtDescRenta.ReadOnly = true;
            this.txtDescRenta.Size = new System.Drawing.Size(75, 23);
            this.txtDescRenta.TabIndex = 13;
            this.txtDescRenta.Text = "$";
            // 
            // txtDescISSS
            // 
            this.txtDescISSS.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescISSS.Location = new System.Drawing.Point(401, 177);
            this.txtDescISSS.Name = "txtDescISSS";
            this.txtDescISSS.ReadOnly = true;
            this.txtDescISSS.Size = new System.Drawing.Size(75, 23);
            this.txtDescISSS.TabIndex = 12;
            this.txtDescISSS.Text = "$";
            // 
            // txtSalarioB
            // 
            this.txtSalarioB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSalarioB.Location = new System.Drawing.Point(401, 152);
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.ReadOnly = true;
            this.txtSalarioB.Size = new System.Drawing.Size(75, 23);
            this.txtSalarioB.TabIndex = 11;
            this.txtSalarioB.Text = "$";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(262, 150);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 25);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Salario bruto";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEdad.Location = new System.Drawing.Point(262, 69);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 25);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblApellido.Location = new System.Drawing.Point(262, 44);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 25);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNombre.Location = new System.Drawing.Point(262, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 25);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureSexo
            // 
            this.pictureSexo.Location = new System.Drawing.Point(0, 19);
            this.pictureSexo.Name = "pictureSexo";
            this.pictureSexo.Size = new System.Drawing.Size(256, 256);
            this.pictureSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureSexo.TabIndex = 6;
            this.pictureSexo.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(262, 250);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 25);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Salario liquido";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(262, 225);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 25);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Descuento AFP";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(262, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(136, 25);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Descuento renta";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(262, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Descuento ISSS";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // nombreErrorProvider
            // 
            this.nombreErrorProvider.ContainerControl = this;
            // 
            // apellidoErrorProvider
            // 
            this.apellidoErrorProvider.ContainerControl = this;
            // 
            // salarioBrutoErrorProvider
            // 
            this.salarioBrutoErrorProvider.ContainerControl = this;
            // 
            // sexoErrorProvider
            // 
            this.sexoErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 414);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Calculadora laboral";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabInformacionPersonal.ResumeLayout(false);
            this.tabInformacionPersonal.PerformLayout();
            this.tabDescuentosSalarios.ResumeLayout(false);
            this.tabDescuentosSalarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioBrutoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabInformacionPersonal;
        private MetroFramework.Controls.MetroTabPage tabDescuentosSalarios;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblSexo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private MetroFramework.Controls.MetroTextBox txtSalarioBruto;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroTrackBar edadBar;
        private MetroFramework.Controls.MetroRadioButton rdbtnFemenino;
        private MetroFramework.Controls.MetroRadioButton rdbtnMasculino;
        private MetroFramework.Controls.MetroLabel lblEdadBarCount;
        private System.Windows.Forms.ErrorProvider nombreErrorProvider;
        private System.Windows.Forms.ErrorProvider apellidoErrorProvider;
        private System.Windows.Forms.ErrorProvider salarioBrutoErrorProvider;
        private System.Windows.Forms.ErrorProvider sexoErrorProvider;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureSexo;
        private MetroFramework.Controls.MetroTextBox txtSalarioLiquido;
        private MetroFramework.Controls.MetroTextBox txtDescAFP;
        private MetroFramework.Controls.MetroTextBox txtDescRenta;
        private MetroFramework.Controls.MetroTextBox txtDescISSS;
        private MetroFramework.Controls.MetroTextBox txtSalarioB;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblEdad;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblNombre;
    }
}

