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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabIngresoAlumnos = new MetroFramework.Controls.MetroTabPage();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.lblTrackBarEdad = new MetroFramework.Controls.MetroLabel();
            this.trackBarEdad = new MetroFramework.Controls.MetroTrackBar();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.txtSegundoApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtPrimerApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtCarnet = new MetroFramework.Controls.MetroTextBox();
            this.lblEdad = new MetroFramework.Controls.MetroLabel();
            this.lblNombres = new MetroFramework.Controls.MetroLabel();
            this.lblSegundoApellido = new MetroFramework.Controls.MetroLabel();
            this.lblPrimerApellido = new MetroFramework.Controls.MetroLabel();
            this.lblCarnet = new MetroFramework.Controls.MetroLabel();
            this.tabAlumnos = new MetroFramework.Controls.MetroTabPage();
            this.gridAlumnos = new MetroFramework.Controls.MetroGrid();
            this.gridAlumnoCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAlumnoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAlumnoPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAlumnoSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAlumnoEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIngresoNotas = new MetroFramework.Controls.MetroTabPage();
            this.btnIngresarNotas = new MetroFramework.Controls.MetroButton();
            this.txtNota3 = new MetroFramework.Controls.MetroTextBox();
            this.txtNota2 = new MetroFramework.Controls.MetroTextBox();
            this.txtNota1 = new MetroFramework.Controls.MetroTextBox();
            this.txtNotasCarnet = new MetroFramework.Controls.MetroTextBox();
            this.lblNota3 = new MetroFramework.Controls.MetroLabel();
            this.lblNota2 = new MetroFramework.Controls.MetroLabel();
            this.lblNota1 = new MetroFramework.Controls.MetroLabel();
            this.lblNotasCarnet = new MetroFramework.Controls.MetroLabel();
            this.tabNotas = new MetroFramework.Controls.MetroTabPage();
            this.gridNotas = new MetroFramework.Controls.MetroGrid();
            this.gridNotasCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNotasNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNotasNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNotasNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNotasPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListas = new MetroFramework.Controls.MetroTabPage();
            this.tileOrdenar = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblListaEdad = new MetroFramework.Controls.MetroLabel();
            this.lblListaCarnet = new MetroFramework.Controls.MetroLabel();
            this.listBoxPromedio = new System.Windows.Forms.ListBox();
            this.listBoxEdad = new System.Windows.Forms.ListBox();
            this.listBoxCarnet = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl.SuspendLayout();
            this.tabIngresoAlumnos.SuspendLayout();
            this.tabAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.tabIngresoNotas.SuspendLayout();
            this.tabNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).BeginInit();
            this.tabListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabIngresoAlumnos);
            this.tabControl.Controls.Add(this.tabAlumnos);
            this.tabControl.Controls.Add(this.tabIngresoNotas);
            this.tabControl.Controls.Add(this.tabNotas);
            this.tabControl.Controls.Add(this.tabListas);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 3;
            this.tabControl.Size = new System.Drawing.Size(764, 470);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            // 
            // tabIngresoAlumnos
            // 
            this.tabIngresoAlumnos.Controls.Add(this.btnIngresar);
            this.tabIngresoAlumnos.Controls.Add(this.lblTrackBarEdad);
            this.tabIngresoAlumnos.Controls.Add(this.trackBarEdad);
            this.tabIngresoAlumnos.Controls.Add(this.txtNombres);
            this.tabIngresoAlumnos.Controls.Add(this.txtSegundoApellido);
            this.tabIngresoAlumnos.Controls.Add(this.txtPrimerApellido);
            this.tabIngresoAlumnos.Controls.Add(this.txtCarnet);
            this.tabIngresoAlumnos.Controls.Add(this.lblEdad);
            this.tabIngresoAlumnos.Controls.Add(this.lblNombres);
            this.tabIngresoAlumnos.Controls.Add(this.lblSegundoApellido);
            this.tabIngresoAlumnos.Controls.Add(this.lblPrimerApellido);
            this.tabIngresoAlumnos.Controls.Add(this.lblCarnet);
            this.tabIngresoAlumnos.HorizontalScrollbarBarColor = true;
            this.tabIngresoAlumnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIngresoAlumnos.HorizontalScrollbarSize = 10;
            this.tabIngresoAlumnos.Location = new System.Drawing.Point(4, 38);
            this.tabIngresoAlumnos.Name = "tabIngresoAlumnos";
            this.tabIngresoAlumnos.Size = new System.Drawing.Size(756, 428);
            this.tabIngresoAlumnos.TabIndex = 0;
            this.tabIngresoAlumnos.Text = "Ingreso de Alumnos";
            this.tabIngresoAlumnos.UseStyleColors = true;
            this.tabIngresoAlumnos.VerticalScrollbarBarColor = true;
            this.tabIngresoAlumnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabIngresoAlumnos.VerticalScrollbarSize = 10;
            this.tabIngresoAlumnos.Enter += new System.EventHandler(this.tabIngresoAlumnos_Enter);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIngresar.Highlight = true;
            this.btnIngresar.Location = new System.Drawing.Point(300, 292);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(150, 46);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.UseStyleColors = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblTrackBarEdad
            // 
            this.lblTrackBarEdad.AutoSize = true;
            this.lblTrackBarEdad.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTrackBarEdad.Location = new System.Drawing.Point(405, 245);
            this.lblTrackBarEdad.Name = "lblTrackBarEdad";
            this.lblTrackBarEdad.Size = new System.Drawing.Size(27, 25);
            this.lblTrackBarEdad.TabIndex = 11;
            this.lblTrackBarEdad.Text = "18";
            this.lblTrackBarEdad.UseStyleColors = true;
            // 
            // trackBarEdad
            // 
            this.trackBarEdad.BackColor = System.Drawing.Color.Transparent;
            this.errorProvider.SetIconPadding(this.trackBarEdad, 10);
            this.trackBarEdad.Location = new System.Drawing.Point(440, 244);
            this.trackBarEdad.Maximum = 125;
            this.trackBarEdad.Name = "trackBarEdad";
            this.trackBarEdad.Size = new System.Drawing.Size(160, 29);
            this.trackBarEdad.TabIndex = 4;
            this.trackBarEdad.Text = "metroTrackBar1";
            this.trackBarEdad.Value = 18;
            this.trackBarEdad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarEdad_Scroll);
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNombres, 10);
            this.txtNombres.Lines = new string[0];
            this.txtNombres.Location = new System.Drawing.Point(407, 196);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.ShowClearButton = true;
            this.txtNombres.Size = new System.Drawing.Size(193, 29);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.UseSelectable = true;
            this.txtNombres.UseStyleColors = true;
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombres.Validated += new System.EventHandler(this.txtNombres_Validated);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtSegundoApellido.CustomButton.Image = null;
            this.txtSegundoApellido.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSegundoApellido.CustomButton.Name = "";
            this.txtSegundoApellido.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSegundoApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSegundoApellido.CustomButton.TabIndex = 1;
            this.txtSegundoApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSegundoApellido.CustomButton.UseSelectable = true;
            this.txtSegundoApellido.CustomButton.Visible = false;
            this.txtSegundoApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtSegundoApellido, 10);
            this.txtSegundoApellido.Lines = new string[0];
            this.txtSegundoApellido.Location = new System.Drawing.Point(407, 148);
            this.txtSegundoApellido.MaxLength = 32767;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PasswordChar = '\0';
            this.txtSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSegundoApellido.SelectedText = "";
            this.txtSegundoApellido.SelectionLength = 0;
            this.txtSegundoApellido.SelectionStart = 0;
            this.txtSegundoApellido.ShortcutsEnabled = true;
            this.txtSegundoApellido.ShowClearButton = true;
            this.txtSegundoApellido.Size = new System.Drawing.Size(193, 29);
            this.txtSegundoApellido.TabIndex = 2;
            this.txtSegundoApellido.UseSelectable = true;
            this.txtSegundoApellido.UseStyleColors = true;
            this.txtSegundoApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSegundoApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoApellido.Validated += new System.EventHandler(this.txtSegundoApellido_Validated);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPrimerApellido.CustomButton.Image = null;
            this.txtPrimerApellido.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtPrimerApellido.CustomButton.Name = "";
            this.txtPrimerApellido.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrimerApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrimerApellido.CustomButton.TabIndex = 1;
            this.txtPrimerApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrimerApellido.CustomButton.UseSelectable = true;
            this.txtPrimerApellido.CustomButton.Visible = false;
            this.txtPrimerApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtPrimerApellido, 10);
            this.txtPrimerApellido.Lines = new string[0];
            this.txtPrimerApellido.Location = new System.Drawing.Point(407, 100);
            this.txtPrimerApellido.MaxLength = 32767;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PasswordChar = '\0';
            this.txtPrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrimerApellido.SelectedText = "";
            this.txtPrimerApellido.SelectionLength = 0;
            this.txtPrimerApellido.SelectionStart = 0;
            this.txtPrimerApellido.ShortcutsEnabled = true;
            this.txtPrimerApellido.ShowClearButton = true;
            this.txtPrimerApellido.Size = new System.Drawing.Size(193, 29);
            this.txtPrimerApellido.TabIndex = 1;
            this.txtPrimerApellido.UseSelectable = true;
            this.txtPrimerApellido.UseStyleColors = true;
            this.txtPrimerApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrimerApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerApellido.Validated += new System.EventHandler(this.txtPrimerApellido_Validated);
            // 
            // txtCarnet
            // 
            this.txtCarnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCarnet.CustomButton.Image = null;
            this.txtCarnet.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtCarnet.CustomButton.Name = "";
            this.txtCarnet.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCarnet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCarnet.CustomButton.TabIndex = 1;
            this.txtCarnet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCarnet.CustomButton.UseSelectable = true;
            this.txtCarnet.CustomButton.Visible = false;
            this.txtCarnet.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtCarnet, 10);
            this.txtCarnet.Lines = new string[0];
            this.txtCarnet.Location = new System.Drawing.Point(407, 52);
            this.txtCarnet.MaxLength = 8;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.PasswordChar = '\0';
            this.txtCarnet.PromptText = "AA012345";
            this.txtCarnet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCarnet.SelectedText = "";
            this.txtCarnet.SelectionLength = 0;
            this.txtCarnet.SelectionStart = 0;
            this.txtCarnet.ShortcutsEnabled = true;
            this.txtCarnet.Size = new System.Drawing.Size(193, 29);
            this.txtCarnet.TabIndex = 0;
            this.txtCarnet.UseSelectable = true;
            this.txtCarnet.UseStyleColors = true;
            this.txtCarnet.WaterMark = "AA012345";
            this.txtCarnet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCarnet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarnet.Validated += new System.EventHandler(this.txtCarnet_Validated);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEdad.Location = new System.Drawing.Point(157, 248);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 25);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            this.lblEdad.UseStyleColors = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNombres.Location = new System.Drawing.Point(157, 200);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(82, 25);
            this.lblNombres.TabIndex = 9;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.UseStyleColors = true;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSegundoApellido.Location = new System.Drawing.Point(157, 152);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(147, 25);
            this.lblSegundoApellido.TabIndex = 8;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            this.lblSegundoApellido.UseStyleColors = true;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrimerApellido.Location = new System.Drawing.Point(157, 104);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(129, 25);
            this.lblPrimerApellido.TabIndex = 7;
            this.lblPrimerApellido.Text = "Primer Apellido";
            this.lblPrimerApellido.UseStyleColors = true;
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCarnet.Location = new System.Drawing.Point(157, 56);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(62, 25);
            this.lblCarnet.TabIndex = 6;
            this.lblCarnet.Text = "Carnet";
            this.lblCarnet.UseStyleColors = true;
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.gridAlumnos);
            this.tabAlumnos.HorizontalScrollbarBarColor = true;
            this.tabAlumnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAlumnos.HorizontalScrollbarSize = 10;
            this.tabAlumnos.Location = new System.Drawing.Point(4, 38);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Size = new System.Drawing.Size(756, 428);
            this.tabAlumnos.TabIndex = 1;
            this.tabAlumnos.Text = "Alumnos";
            this.tabAlumnos.UseStyleColors = true;
            this.tabAlumnos.VerticalScrollbarBarColor = true;
            this.tabAlumnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabAlumnos.VerticalScrollbarSize = 10;
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.AllowUserToAddRows = false;
            this.gridAlumnos.AllowUserToDeleteRows = false;
            this.gridAlumnos.AllowUserToResizeRows = false;
            this.gridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridAlumnoCarnet,
            this.gridAlumnoNombre,
            this.gridAlumnoPrimerApellido,
            this.gridAlumnoSegundoApellido,
            this.gridAlumnoEdad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlumnos.EnableHeadersVisualStyles = false;
            this.gridAlumnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAlumnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAlumnos.Location = new System.Drawing.Point(3, 3);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.ReadOnly = true;
            this.gridAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlumnos.Size = new System.Drawing.Size(750, 422);
            this.gridAlumnos.TabIndex = 2;
            this.gridAlumnos.UseStyleColors = true;
            // 
            // gridAlumnoCarnet
            // 
            this.gridAlumnoCarnet.HeaderText = "Carnet";
            this.gridAlumnoCarnet.Name = "gridAlumnoCarnet";
            this.gridAlumnoCarnet.ReadOnly = true;
            // 
            // gridAlumnoNombre
            // 
            this.gridAlumnoNombre.HeaderText = "Nombre";
            this.gridAlumnoNombre.Name = "gridAlumnoNombre";
            this.gridAlumnoNombre.ReadOnly = true;
            // 
            // gridAlumnoPrimerApellido
            // 
            this.gridAlumnoPrimerApellido.HeaderText = "Primer Apellido";
            this.gridAlumnoPrimerApellido.Name = "gridAlumnoPrimerApellido";
            this.gridAlumnoPrimerApellido.ReadOnly = true;
            // 
            // gridAlumnoSegundoApellido
            // 
            this.gridAlumnoSegundoApellido.HeaderText = "Segundo Apellido";
            this.gridAlumnoSegundoApellido.Name = "gridAlumnoSegundoApellido";
            this.gridAlumnoSegundoApellido.ReadOnly = true;
            // 
            // gridAlumnoEdad
            // 
            this.gridAlumnoEdad.HeaderText = "Edad";
            this.gridAlumnoEdad.Name = "gridAlumnoEdad";
            this.gridAlumnoEdad.ReadOnly = true;
            // 
            // tabIngresoNotas
            // 
            this.tabIngresoNotas.Controls.Add(this.btnIngresarNotas);
            this.tabIngresoNotas.Controls.Add(this.txtNota3);
            this.tabIngresoNotas.Controls.Add(this.txtNota2);
            this.tabIngresoNotas.Controls.Add(this.txtNota1);
            this.tabIngresoNotas.Controls.Add(this.txtNotasCarnet);
            this.tabIngresoNotas.Controls.Add(this.lblNota3);
            this.tabIngresoNotas.Controls.Add(this.lblNota2);
            this.tabIngresoNotas.Controls.Add(this.lblNota1);
            this.tabIngresoNotas.Controls.Add(this.lblNotasCarnet);
            this.tabIngresoNotas.HorizontalScrollbarBarColor = true;
            this.tabIngresoNotas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIngresoNotas.HorizontalScrollbarSize = 10;
            this.tabIngresoNotas.Location = new System.Drawing.Point(4, 38);
            this.tabIngresoNotas.Name = "tabIngresoNotas";
            this.tabIngresoNotas.Size = new System.Drawing.Size(756, 428);
            this.tabIngresoNotas.TabIndex = 2;
            this.tabIngresoNotas.Text = "Ingreso de Notas";
            this.tabIngresoNotas.UseStyleColors = true;
            this.tabIngresoNotas.VerticalScrollbarBarColor = true;
            this.tabIngresoNotas.VerticalScrollbarHighlightOnWheel = false;
            this.tabIngresoNotas.VerticalScrollbarSize = 10;
            this.tabIngresoNotas.Enter += new System.EventHandler(this.tabIngresoNotas_Enter);
            // 
            // btnIngresarNotas
            // 
            this.btnIngresarNotas.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIngresarNotas.Highlight = true;
            this.btnIngresarNotas.Location = new System.Drawing.Point(325, 320);
            this.btnIngresarNotas.Name = "btnIngresarNotas";
            this.btnIngresarNotas.Size = new System.Drawing.Size(150, 46);
            this.btnIngresarNotas.TabIndex = 4;
            this.btnIngresarNotas.Text = "Ingresar";
            this.btnIngresarNotas.UseSelectable = true;
            this.btnIngresarNotas.UseStyleColors = true;
            this.btnIngresarNotas.Click += new System.EventHandler(this.btnIngresarNotas_Click);
            // 
            // txtNota3
            // 
            // 
            // 
            // 
            this.txtNota3.CustomButton.Image = null;
            this.txtNota3.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtNota3.CustomButton.Name = "";
            this.txtNota3.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNota3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota3.CustomButton.TabIndex = 1;
            this.txtNota3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota3.CustomButton.UseSelectable = true;
            this.txtNota3.CustomButton.Visible = false;
            this.txtNota3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNota3, 10);
            this.txtNota3.Lines = new string[0];
            this.txtNota3.Location = new System.Drawing.Point(422, 249);
            this.txtNota3.MaxLength = 32767;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.PasswordChar = '\0';
            this.txtNota3.PromptText = "#";
            this.txtNota3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota3.SelectedText = "";
            this.txtNota3.SelectionLength = 0;
            this.txtNota3.SelectionStart = 0;
            this.txtNota3.ShortcutsEnabled = true;
            this.txtNota3.Size = new System.Drawing.Size(146, 29);
            this.txtNota3.TabIndex = 3;
            this.txtNota3.UseSelectable = true;
            this.txtNota3.UseStyleColors = true;
            this.txtNota3.WaterMark = "#";
            this.txtNota3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNota3.Validated += new System.EventHandler(this.txtNota3_Validated);
            // 
            // txtNota2
            // 
            // 
            // 
            // 
            this.txtNota2.CustomButton.Image = null;
            this.txtNota2.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtNota2.CustomButton.Name = "";
            this.txtNota2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNota2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota2.CustomButton.TabIndex = 1;
            this.txtNota2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota2.CustomButton.UseSelectable = true;
            this.txtNota2.CustomButton.Visible = false;
            this.txtNota2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNota2, 10);
            this.txtNota2.Lines = new string[0];
            this.txtNota2.Location = new System.Drawing.Point(422, 187);
            this.txtNota2.MaxLength = 32767;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PasswordChar = '\0';
            this.txtNota2.PromptText = "#";
            this.txtNota2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota2.SelectedText = "";
            this.txtNota2.SelectionLength = 0;
            this.txtNota2.SelectionStart = 0;
            this.txtNota2.ShortcutsEnabled = true;
            this.txtNota2.Size = new System.Drawing.Size(146, 29);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.UseSelectable = true;
            this.txtNota2.UseStyleColors = true;
            this.txtNota2.WaterMark = "#";
            this.txtNota2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNota2.Validated += new System.EventHandler(this.txtNota2_Validated);
            // 
            // txtNota1
            // 
            // 
            // 
            // 
            this.txtNota1.CustomButton.Image = null;
            this.txtNota1.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtNota1.CustomButton.Name = "";
            this.txtNota1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNota1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota1.CustomButton.TabIndex = 1;
            this.txtNota1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota1.CustomButton.UseSelectable = true;
            this.txtNota1.CustomButton.Visible = false;
            this.txtNota1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNota1, 10);
            this.txtNota1.Lines = new string[0];
            this.txtNota1.Location = new System.Drawing.Point(422, 125);
            this.txtNota1.MaxLength = 32767;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PasswordChar = '\0';
            this.txtNota1.PromptText = "#";
            this.txtNota1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota1.SelectedText = "";
            this.txtNota1.SelectionLength = 0;
            this.txtNota1.SelectionStart = 0;
            this.txtNota1.ShortcutsEnabled = true;
            this.txtNota1.Size = new System.Drawing.Size(146, 29);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.UseSelectable = true;
            this.txtNota1.UseStyleColors = true;
            this.txtNota1.WaterMark = "#";
            this.txtNota1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNota1.Validated += new System.EventHandler(this.txtNota1_Validated);
            // 
            // txtNotasCarnet
            // 
            this.txtNotasCarnet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNotasCarnet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNotasCarnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNotasCarnet.CustomButton.Image = null;
            this.txtNotasCarnet.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtNotasCarnet.CustomButton.Name = "";
            this.txtNotasCarnet.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNotasCarnet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotasCarnet.CustomButton.TabIndex = 1;
            this.txtNotasCarnet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotasCarnet.CustomButton.UseSelectable = true;
            this.txtNotasCarnet.CustomButton.Visible = false;
            this.txtNotasCarnet.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNotasCarnet, 10);
            this.txtNotasCarnet.Lines = new string[0];
            this.txtNotasCarnet.Location = new System.Drawing.Point(422, 63);
            this.txtNotasCarnet.MaxLength = 8;
            this.txtNotasCarnet.Name = "txtNotasCarnet";
            this.txtNotasCarnet.PasswordChar = '\0';
            this.txtNotasCarnet.PromptText = "AA012345";
            this.txtNotasCarnet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotasCarnet.SelectedText = "";
            this.txtNotasCarnet.SelectionLength = 0;
            this.txtNotasCarnet.SelectionStart = 0;
            this.txtNotasCarnet.ShortcutsEnabled = true;
            this.txtNotasCarnet.Size = new System.Drawing.Size(146, 29);
            this.txtNotasCarnet.TabIndex = 0;
            this.txtNotasCarnet.UseSelectable = true;
            this.txtNotasCarnet.UseStyleColors = true;
            this.txtNotasCarnet.WaterMark = "AA012345";
            this.txtNotasCarnet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotasCarnet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNotasCarnet.Leave += new System.EventHandler(this.txtNotasCarnet_Leave);
            this.txtNotasCarnet.Validated += new System.EventHandler(this.txtNotasCarnet_Validated);
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNota3.Location = new System.Drawing.Point(189, 253);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(104, 25);
            this.lblNota3.TabIndex = 8;
            this.lblNota3.Text = "Tercera nota";
            this.lblNota3.UseStyleColors = true;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNota2.Location = new System.Drawing.Point(189, 191);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(118, 25);
            this.lblNota2.TabIndex = 7;
            this.lblNota2.Text = "Segunda nota";
            this.lblNota2.UseStyleColors = true;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNota1.Location = new System.Drawing.Point(189, 129);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(110, 25);
            this.lblNota1.TabIndex = 6;
            this.lblNota1.Text = "Primera nota";
            this.lblNota1.UseStyleColors = true;
            // 
            // lblNotasCarnet
            // 
            this.lblNotasCarnet.AutoSize = true;
            this.lblNotasCarnet.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNotasCarnet.Location = new System.Drawing.Point(189, 67);
            this.lblNotasCarnet.Name = "lblNotasCarnet";
            this.lblNotasCarnet.Size = new System.Drawing.Size(62, 25);
            this.lblNotasCarnet.TabIndex = 5;
            this.lblNotasCarnet.Text = "Carnet";
            this.lblNotasCarnet.UseStyleColors = true;
            // 
            // tabNotas
            // 
            this.tabNotas.Controls.Add(this.gridNotas);
            this.tabNotas.HorizontalScrollbarBarColor = true;
            this.tabNotas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNotas.HorizontalScrollbarSize = 10;
            this.tabNotas.Location = new System.Drawing.Point(4, 38);
            this.tabNotas.Name = "tabNotas";
            this.tabNotas.Size = new System.Drawing.Size(756, 428);
            this.tabNotas.TabIndex = 3;
            this.tabNotas.Text = "Notas";
            this.tabNotas.UseStyleColors = true;
            this.tabNotas.VerticalScrollbarBarColor = true;
            this.tabNotas.VerticalScrollbarHighlightOnWheel = false;
            this.tabNotas.VerticalScrollbarSize = 10;
            // 
            // gridNotas
            // 
            this.gridNotas.AllowUserToAddRows = false;
            this.gridNotas.AllowUserToDeleteRows = false;
            this.gridNotas.AllowUserToResizeRows = false;
            this.gridNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridNotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridNotasCarnet,
            this.gridNotasNota1,
            this.gridNotasNota2,
            this.gridNotasNota3,
            this.gridNotasPromedio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNotas.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridNotas.EnableHeadersVisualStyles = false;
            this.gridNotas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridNotas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNotas.Location = new System.Drawing.Point(3, 3);
            this.gridNotas.Name = "gridNotas";
            this.gridNotas.ReadOnly = true;
            this.gridNotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotas.Size = new System.Drawing.Size(750, 422);
            this.gridNotas.TabIndex = 2;
            this.gridNotas.UseStyleColors = true;
            // 
            // gridNotasCarnet
            // 
            this.gridNotasCarnet.HeaderText = "Carnet";
            this.gridNotasCarnet.Name = "gridNotasCarnet";
            this.gridNotasCarnet.ReadOnly = true;
            // 
            // gridNotasNota1
            // 
            this.gridNotasNota1.HeaderText = "Nota 1";
            this.gridNotasNota1.Name = "gridNotasNota1";
            this.gridNotasNota1.ReadOnly = true;
            // 
            // gridNotasNota2
            // 
            this.gridNotasNota2.HeaderText = "Nota 2";
            this.gridNotasNota2.Name = "gridNotasNota2";
            this.gridNotasNota2.ReadOnly = true;
            // 
            // gridNotasNota3
            // 
            this.gridNotasNota3.HeaderText = "Nota 3";
            this.gridNotasNota3.Name = "gridNotasNota3";
            this.gridNotasNota3.ReadOnly = true;
            // 
            // gridNotasPromedio
            // 
            this.gridNotasPromedio.HeaderText = "Promedio";
            this.gridNotasPromedio.Name = "gridNotasPromedio";
            this.gridNotasPromedio.ReadOnly = true;
            // 
            // tabListas
            // 
            this.tabListas.Controls.Add(this.tileOrdenar);
            this.tabListas.Controls.Add(this.metroLabel3);
            this.tabListas.Controls.Add(this.lblListaEdad);
            this.tabListas.Controls.Add(this.lblListaCarnet);
            this.tabListas.Controls.Add(this.listBoxPromedio);
            this.tabListas.Controls.Add(this.listBoxEdad);
            this.tabListas.Controls.Add(this.listBoxCarnet);
            this.tabListas.HorizontalScrollbarBarColor = true;
            this.tabListas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabListas.HorizontalScrollbarSize = 10;
            this.tabListas.Location = new System.Drawing.Point(4, 38);
            this.tabListas.Name = "tabListas";
            this.tabListas.Size = new System.Drawing.Size(756, 428);
            this.tabListas.TabIndex = 4;
            this.tabListas.Text = "Listas";
            this.tabListas.UseStyleColors = true;
            this.tabListas.VerticalScrollbarBarColor = true;
            this.tabListas.VerticalScrollbarHighlightOnWheel = false;
            this.tabListas.VerticalScrollbarSize = 10;
            this.tabListas.Enter += new System.EventHandler(this.tabListas_Enter);
            // 
            // tileOrdenar
            // 
            this.tileOrdenar.ActiveControl = null;
            this.tileOrdenar.Location = new System.Drawing.Point(299, 364);
            this.tileOrdenar.Name = "tileOrdenar";
            this.tileOrdenar.Size = new System.Drawing.Size(158, 51);
            this.tileOrdenar.TabIndex = 0;
            this.tileOrdenar.Text = "Ordenar";
            this.tileOrdenar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileOrdenar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileOrdenar.UseSelectable = true;
            this.tileOrdenar.UseStyleColors = true;
            this.tileOrdenar.Click += new System.EventHandler(this.tileOrdenar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(585, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Promedio";
            this.metroLabel3.UseStyleColors = true;
            // 
            // lblListaEdad
            // 
            this.lblListaEdad.AutoSize = true;
            this.lblListaEdad.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblListaEdad.Location = new System.Drawing.Point(353, 17);
            this.lblListaEdad.Name = "lblListaEdad";
            this.lblListaEdad.Size = new System.Drawing.Size(50, 25);
            this.lblListaEdad.TabIndex = 5;
            this.lblListaEdad.Text = "Edad";
            this.lblListaEdad.UseStyleColors = true;
            // 
            // lblListaCarnet
            // 
            this.lblListaCarnet.AutoSize = true;
            this.lblListaCarnet.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblListaCarnet.Location = new System.Drawing.Point(97, 17);
            this.lblListaCarnet.Name = "lblListaCarnet";
            this.lblListaCarnet.Size = new System.Drawing.Size(62, 25);
            this.lblListaCarnet.TabIndex = 4;
            this.lblListaCarnet.Text = "Carnet";
            this.lblListaCarnet.UseStyleColors = true;
            // 
            // listBoxPromedio
            // 
            this.listBoxPromedio.FormattingEnabled = true;
            this.listBoxPromedio.Location = new System.Drawing.Point(549, 45);
            this.listBoxPromedio.Name = "listBoxPromedio";
            this.listBoxPromedio.Size = new System.Drawing.Size(158, 303);
            this.listBoxPromedio.TabIndex = 3;
            // 
            // listBoxEdad
            // 
            this.listBoxEdad.FormattingEnabled = true;
            this.listBoxEdad.Location = new System.Drawing.Point(299, 45);
            this.listBoxEdad.Name = "listBoxEdad";
            this.listBoxEdad.Size = new System.Drawing.Size(158, 303);
            this.listBoxEdad.TabIndex = 2;
            // 
            // listBoxCarnet
            // 
            this.listBoxCarnet.FormattingEnabled = true;
            this.listBoxCarnet.Location = new System.Drawing.Point(49, 45);
            this.listBoxCarnet.Name = "listBoxCarnet";
            this.listBoxCarnet.Size = new System.Drawing.Size(158, 303);
            this.listBoxCarnet.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 550);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Centro Escolar Republica de El Salvador";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabIngresoAlumnos.ResumeLayout(false);
            this.tabIngresoAlumnos.PerformLayout();
            this.tabAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.tabIngresoNotas.ResumeLayout(false);
            this.tabIngresoNotas.PerformLayout();
            this.tabNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).EndInit();
            this.tabListas.ResumeLayout(false);
            this.tabListas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabIngresoAlumnos;
        private MetroFramework.Controls.MetroLabel lblEdad;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroLabel lblSegundoApellido;
        private MetroFramework.Controls.MetroLabel lblPrimerApellido;
        private MetroFramework.Controls.MetroLabel lblCarnet;
        private MetroFramework.Controls.MetroTabPage tabAlumnos;
        private MetroFramework.Controls.MetroTabPage tabIngresoNotas;
        private MetroFramework.Controls.MetroTrackBar trackBarEdad;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroTextBox txtSegundoApellido;
        private MetroFramework.Controls.MetroTextBox txtPrimerApellido;
        private MetroFramework.Controls.MetroTextBox txtCarnet;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroLabel lblTrackBarEdad;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroGrid gridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private MetroFramework.Controls.MetroTextBox txtNota3;
        private MetroFramework.Controls.MetroTextBox txtNota2;
        private MetroFramework.Controls.MetroTextBox txtNota1;
        private MetroFramework.Controls.MetroTextBox txtNotasCarnet;
        private MetroFramework.Controls.MetroLabel lblNota3;
        private MetroFramework.Controls.MetroLabel lblNota2;
        private MetroFramework.Controls.MetroLabel lblNota1;
        private MetroFramework.Controls.MetroLabel lblNotasCarnet;
        private MetroFramework.Controls.MetroButton btnIngresarNotas;
        private MetroFramework.Controls.MetroTabPage tabNotas;
        private MetroFramework.Controls.MetroGrid gridNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private MetroFramework.Controls.MetroTabPage tabListas;
        private System.Windows.Forms.ListBox listBoxPromedio;
        private System.Windows.Forms.ListBox listBoxEdad;
        private System.Windows.Forms.ListBox listBoxCarnet;
        private MetroFramework.Controls.MetroTile tileOrdenar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblListaEdad;
        private MetroFramework.Controls.MetroLabel lblListaCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAlumnoCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAlumnoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAlumnoPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAlumnoSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAlumnoEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNotasCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNotasNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNotasNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNotasNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNotasPromedio;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

