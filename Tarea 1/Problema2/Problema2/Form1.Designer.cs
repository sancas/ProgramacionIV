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
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(496, 334);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
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
            this.tabInformacionPersonal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabInformacionPersonal.HorizontalScrollbarSize = 10;
            this.tabInformacionPersonal.Location = new System.Drawing.Point(4, 38);
            this.tabInformacionPersonal.Name = "tabInformacionPersonal";
            this.tabInformacionPersonal.Size = new System.Drawing.Size(488, 292);
            this.tabInformacionPersonal.TabIndex = 0;
            this.tabInformacionPersonal.Text = "Información personal";
            this.tabInformacionPersonal.VerticalScrollbarBarColor = true;
            this.tabInformacionPersonal.VerticalScrollbarHighlightOnWheel = false;
            this.tabInformacionPersonal.VerticalScrollbarSize = 10;
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
            this.lblEdadBarCount.UseStyleColors = true;
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
            this.rdbtnFemenino.UseSelectable = true;
            this.rdbtnFemenino.UseStyleColors = true;
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
            this.rdbtnMasculino.UseSelectable = true;
            this.rdbtnMasculino.UseStyleColors = true;
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
            this.btnCalcular.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCalcular.Highlight = true;
            this.btnCalcular.Location = new System.Drawing.Point(173, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseSelectable = true;
            this.btnCalcular.UseStyleColors = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            // 
            // 
            // 
            this.txtSalarioBruto.CustomButton.Image = null;
            this.txtSalarioBruto.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtSalarioBruto.CustomButton.Name = "";
            this.txtSalarioBruto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalarioBruto.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSalarioBruto.CustomButton.TabIndex = 1;
            this.txtSalarioBruto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalarioBruto.CustomButton.UseSelectable = true;
            this.txtSalarioBruto.CustomButton.Visible = false;
            this.txtSalarioBruto.Lines = new string[] {
        " "};
            this.txtSalarioBruto.Location = new System.Drawing.Point(229, 198);
            this.txtSalarioBruto.MaxLength = 32767;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.PasswordChar = '\0';
            this.txtSalarioBruto.PromptText = "$";
            this.txtSalarioBruto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalarioBruto.SelectedText = "";
            this.txtSalarioBruto.SelectionLength = 0;
            this.txtSalarioBruto.SelectionStart = 0;
            this.txtSalarioBruto.ShortcutsEnabled = true;
            this.txtSalarioBruto.Size = new System.Drawing.Size(138, 23);
            this.txtSalarioBruto.TabIndex = 6;
            this.txtSalarioBruto.Text = " ";
            this.txtSalarioBruto.UseSelectable = true;
            this.txtSalarioBruto.UseStyleColors = true;
            this.txtSalarioBruto.WaterMark = "$";
            this.txtSalarioBruto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalarioBruto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioBruto.Validated += new System.EventHandler(this.txtSalarioBruto_Validated);
            // 
            // txtApellidos
            // 
            // 
            // 
            // 
            this.txtApellidos.CustomButton.Image = null;
            this.txtApellidos.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtApellidos.CustomButton.Name = "";
            this.txtApellidos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtApellidos.CustomButton.TabIndex = 1;
            this.txtApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidos.CustomButton.UseSelectable = true;
            this.txtApellidos.CustomButton.Visible = false;
            this.txtApellidos.Lines = new string[0];
            this.txtApellidos.Location = new System.Drawing.Point(229, 66);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(138, 23);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.UseSelectable = true;
            this.txtApellidos.UseStyleColors = true;
            this.txtApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.Validated += new System.EventHandler(this.txtApellidos_Validated);
            // 
            // txtNombres
            // 
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.Lines = new string[0];
            this.txtNombres.Location = new System.Drawing.Point(229, 26);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.Size = new System.Drawing.Size(138, 23);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.UseSelectable = true;
            this.txtNombres.UseStyleColors = true;
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel5.UseStyleColors = true;
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
            this.lblSexo.UseStyleColors = true;
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
            this.metroLabel3.UseStyleColors = true;
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
            this.metroLabel2.UseStyleColors = true;
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
            this.metroLabel1.UseStyleColors = true;
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
            this.tabDescuentosSalarios.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDescuentosSalarios.HorizontalScrollbarSize = 10;
            this.tabDescuentosSalarios.Location = new System.Drawing.Point(4, 38);
            this.tabDescuentosSalarios.Name = "tabDescuentosSalarios";
            this.tabDescuentosSalarios.Size = new System.Drawing.Size(488, 292);
            this.tabDescuentosSalarios.TabIndex = 1;
            this.tabDescuentosSalarios.Text = "Descuentos del salario";
            this.tabDescuentosSalarios.VerticalScrollbarBarColor = true;
            this.tabDescuentosSalarios.VerticalScrollbarHighlightOnWheel = false;
            this.tabDescuentosSalarios.VerticalScrollbarSize = 10;
            this.tabDescuentosSalarios.Enter += new System.EventHandler(this.tabDescuentosSalarios_Enter);
            // 
            // txtSalarioLiquido
            // 
            // 
            // 
            // 
            this.txtSalarioLiquido.CustomButton.Image = null;
            this.txtSalarioLiquido.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtSalarioLiquido.CustomButton.Name = "";
            this.txtSalarioLiquido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalarioLiquido.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSalarioLiquido.CustomButton.TabIndex = 1;
            this.txtSalarioLiquido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalarioLiquido.CustomButton.UseSelectable = true;
            this.txtSalarioLiquido.CustomButton.Visible = false;
            this.txtSalarioLiquido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSalarioLiquido.Lines = new string[] {
        "$"};
            this.txtSalarioLiquido.Location = new System.Drawing.Point(401, 252);
            this.txtSalarioLiquido.MaxLength = 32767;
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.PasswordChar = '\0';
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalarioLiquido.SelectedText = "";
            this.txtSalarioLiquido.SelectionLength = 0;
            this.txtSalarioLiquido.SelectionStart = 0;
            this.txtSalarioLiquido.ShortcutsEnabled = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(75, 23);
            this.txtSalarioLiquido.TabIndex = 15;
            this.txtSalarioLiquido.Text = "$";
            this.txtSalarioLiquido.UseSelectable = true;
            this.txtSalarioLiquido.UseStyleColors = true;
            this.txtSalarioLiquido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalarioLiquido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescAFP
            // 
            // 
            // 
            // 
            this.txtDescAFP.CustomButton.Image = null;
            this.txtDescAFP.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDescAFP.CustomButton.Name = "";
            this.txtDescAFP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescAFP.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDescAFP.CustomButton.TabIndex = 1;
            this.txtDescAFP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescAFP.CustomButton.UseSelectable = true;
            this.txtDescAFP.CustomButton.Visible = false;
            this.txtDescAFP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescAFP.Lines = new string[] {
        "$"};
            this.txtDescAFP.Location = new System.Drawing.Point(401, 227);
            this.txtDescAFP.MaxLength = 32767;
            this.txtDescAFP.Name = "txtDescAFP";
            this.txtDescAFP.PasswordChar = '\0';
            this.txtDescAFP.ReadOnly = true;
            this.txtDescAFP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescAFP.SelectedText = "";
            this.txtDescAFP.SelectionLength = 0;
            this.txtDescAFP.SelectionStart = 0;
            this.txtDescAFP.ShortcutsEnabled = true;
            this.txtDescAFP.Size = new System.Drawing.Size(75, 23);
            this.txtDescAFP.TabIndex = 14;
            this.txtDescAFP.Text = "$";
            this.txtDescAFP.UseSelectable = true;
            this.txtDescAFP.UseStyleColors = true;
            this.txtDescAFP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescAFP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescRenta
            // 
            // 
            // 
            // 
            this.txtDescRenta.CustomButton.Image = null;
            this.txtDescRenta.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDescRenta.CustomButton.Name = "";
            this.txtDescRenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescRenta.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDescRenta.CustomButton.TabIndex = 1;
            this.txtDescRenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescRenta.CustomButton.UseSelectable = true;
            this.txtDescRenta.CustomButton.Visible = false;
            this.txtDescRenta.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescRenta.Lines = new string[] {
        "$"};
            this.txtDescRenta.Location = new System.Drawing.Point(401, 202);
            this.txtDescRenta.MaxLength = 32767;
            this.txtDescRenta.Name = "txtDescRenta";
            this.txtDescRenta.PasswordChar = '\0';
            this.txtDescRenta.ReadOnly = true;
            this.txtDescRenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescRenta.SelectedText = "";
            this.txtDescRenta.SelectionLength = 0;
            this.txtDescRenta.SelectionStart = 0;
            this.txtDescRenta.ShortcutsEnabled = true;
            this.txtDescRenta.Size = new System.Drawing.Size(75, 23);
            this.txtDescRenta.TabIndex = 13;
            this.txtDescRenta.Text = "$";
            this.txtDescRenta.UseSelectable = true;
            this.txtDescRenta.UseStyleColors = true;
            this.txtDescRenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescRenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescISSS
            // 
            // 
            // 
            // 
            this.txtDescISSS.CustomButton.Image = null;
            this.txtDescISSS.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDescISSS.CustomButton.Name = "";
            this.txtDescISSS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescISSS.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDescISSS.CustomButton.TabIndex = 1;
            this.txtDescISSS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescISSS.CustomButton.UseSelectable = true;
            this.txtDescISSS.CustomButton.Visible = false;
            this.txtDescISSS.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescISSS.Lines = new string[] {
        "$"};
            this.txtDescISSS.Location = new System.Drawing.Point(401, 177);
            this.txtDescISSS.MaxLength = 32767;
            this.txtDescISSS.Name = "txtDescISSS";
            this.txtDescISSS.PasswordChar = '\0';
            this.txtDescISSS.ReadOnly = true;
            this.txtDescISSS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescISSS.SelectedText = "";
            this.txtDescISSS.SelectionLength = 0;
            this.txtDescISSS.SelectionStart = 0;
            this.txtDescISSS.ShortcutsEnabled = true;
            this.txtDescISSS.Size = new System.Drawing.Size(75, 23);
            this.txtDescISSS.TabIndex = 12;
            this.txtDescISSS.Text = "$";
            this.txtDescISSS.UseSelectable = true;
            this.txtDescISSS.UseStyleColors = true;
            this.txtDescISSS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescISSS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalarioB
            // 
            // 
            // 
            // 
            this.txtSalarioB.CustomButton.Image = null;
            this.txtSalarioB.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtSalarioB.CustomButton.Name = "";
            this.txtSalarioB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalarioB.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSalarioB.CustomButton.TabIndex = 1;
            this.txtSalarioB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalarioB.CustomButton.UseSelectable = true;
            this.txtSalarioB.CustomButton.Visible = false;
            this.txtSalarioB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSalarioB.Lines = new string[] {
        "$"};
            this.txtSalarioB.Location = new System.Drawing.Point(401, 152);
            this.txtSalarioB.MaxLength = 32767;
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.PasswordChar = '\0';
            this.txtSalarioB.ReadOnly = true;
            this.txtSalarioB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalarioB.SelectedText = "";
            this.txtSalarioB.SelectionLength = 0;
            this.txtSalarioB.SelectionStart = 0;
            this.txtSalarioB.ShortcutsEnabled = true;
            this.txtSalarioB.Size = new System.Drawing.Size(75, 23);
            this.txtSalarioB.TabIndex = 11;
            this.txtSalarioB.Text = "$";
            this.txtSalarioB.UseSelectable = true;
            this.txtSalarioB.UseStyleColors = true;
            this.txtSalarioB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalarioB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel9.UseStyleColors = true;
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
            this.lblEdad.UseStyleColors = true;
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
            this.lblApellido.UseStyleColors = true;
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
            this.lblNombre.UseStyleColors = true;
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
            this.metroLabel8.UseStyleColors = true;
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
            this.metroLabel7.UseStyleColors = true;
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
            this.metroLabel6.UseStyleColors = true;
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
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
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
            this.Style = MetroFramework.MetroColorStyle.Green;
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

