namespace Problema3
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabRegistrarInformacion = new MetroFramework.Controls.MetroTabPage();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtCodigoProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioProducto = new MetroFramework.Controls.MetroTextBox();
            this.cmbPaisFabricacion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabInformacionRegistrada = new MetroFramework.Controls.MetroTabPage();
            this.gridProductos = new MetroFramework.Controls.MetroGrid();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInformacionOrdenada = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.listCodigos = new System.Windows.Forms.ListBox();
            this.listPrecios = new System.Windows.Forms.ListBox();
            this.metroTabControl1.SuspendLayout();
            this.tabRegistrarInformacion.SuspendLayout();
            this.tabInformacionRegistrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.tabInformacionOrdenada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabRegistrarInformacion);
            this.metroTabControl1.Controls.Add(this.tabInformacionRegistrada);
            this.metroTabControl1.Controls.Add(this.tabInformacionOrdenada);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(692, 460);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // tabRegistrarInformacion
            // 
            this.tabRegistrarInformacion.Controls.Add(this.btnGuardar);
            this.tabRegistrarInformacion.Controls.Add(this.txtCodigoProducto);
            this.tabRegistrarInformacion.Controls.Add(this.txtNombreProducto);
            this.tabRegistrarInformacion.Controls.Add(this.txtPrecioProducto);
            this.tabRegistrarInformacion.Controls.Add(this.cmbPaisFabricacion);
            this.tabRegistrarInformacion.Controls.Add(this.metroLabel4);
            this.tabRegistrarInformacion.Controls.Add(this.metroLabel3);
            this.tabRegistrarInformacion.Controls.Add(this.metroLabel2);
            this.tabRegistrarInformacion.Controls.Add(this.metroLabel1);
            this.tabRegistrarInformacion.HorizontalScrollbarBarColor = true;
            this.tabRegistrarInformacion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegistrarInformacion.HorizontalScrollbarSize = 10;
            this.errorProvider.SetIconPadding(this.tabRegistrarInformacion, 5);
            this.tabRegistrarInformacion.Location = new System.Drawing.Point(4, 38);
            this.tabRegistrarInformacion.Name = "tabRegistrarInformacion";
            this.tabRegistrarInformacion.Size = new System.Drawing.Size(684, 418);
            this.tabRegistrarInformacion.TabIndex = 0;
            this.tabRegistrarInformacion.Text = "Registrar información";
            this.tabRegistrarInformacion.VerticalScrollbarBarColor = true;
            this.tabRegistrarInformacion.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegistrarInformacion.VerticalScrollbarSize = 10;
            this.tabRegistrarInformacion.Enter += new System.EventHandler(this.tabRegistrarInformacion_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGuardar.Highlight = true;
            this.btnGuardar.Location = new System.Drawing.Point(288, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigoProducto
            // 
            // 
            // 
            // 
            this.txtCodigoProducto.CustomButton.Image = null;
            this.txtCodigoProducto.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtCodigoProducto.CustomButton.Name = "";
            this.txtCodigoProducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCodigoProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCodigoProducto.CustomButton.TabIndex = 1;
            this.txtCodigoProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCodigoProducto.CustomButton.UseSelectable = true;
            this.txtCodigoProducto.CustomButton.Visible = false;
            this.txtCodigoProducto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtCodigoProducto, 5);
            this.txtCodigoProducto.Lines = new string[0];
            this.txtCodigoProducto.Location = new System.Drawing.Point(358, 63);
            this.txtCodigoProducto.MaxLength = 3;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.PasswordChar = '\0';
            this.txtCodigoProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoProducto.SelectedText = "";
            this.txtCodigoProducto.SelectionLength = 0;
            this.txtCodigoProducto.SelectionStart = 0;
            this.txtCodigoProducto.ShortcutsEnabled = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(181, 35);
            this.txtCodigoProducto.TabIndex = 9;
            this.txtCodigoProducto.UseSelectable = true;
            this.txtCodigoProducto.UseStyleColors = true;
            this.txtCodigoProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoProducto.Validated += new System.EventHandler(this.txtCodigoProducto_Validated);
            // 
            // txtNombreProducto
            // 
            // 
            // 
            // 
            this.txtNombreProducto.CustomButton.Image = null;
            this.txtNombreProducto.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtNombreProducto.CustomButton.Name = "";
            this.txtNombreProducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtNombreProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNombreProducto.CustomButton.TabIndex = 1;
            this.txtNombreProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNombreProducto.CustomButton.UseSelectable = true;
            this.txtNombreProducto.CustomButton.Visible = false;
            this.txtNombreProducto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtNombreProducto, 5);
            this.txtNombreProducto.Lines = new string[0];
            this.txtNombreProducto.Location = new System.Drawing.Point(358, 109);
            this.txtNombreProducto.MaxLength = 0;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.ShortcutsEnabled = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(181, 35);
            this.txtNombreProducto.TabIndex = 8;
            this.txtNombreProducto.UseSelectable = true;
            this.txtNombreProducto.UseStyleColors = true;
            this.txtNombreProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProducto.Validated += new System.EventHandler(this.txtNombreProducto_Validated);
            // 
            // txtPrecioProducto
            // 
            // 
            // 
            // 
            this.txtPrecioProducto.CustomButton.Image = null;
            this.txtPrecioProducto.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPrecioProducto.CustomButton.Name = "";
            this.txtPrecioProducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPrecioProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPrecioProducto.CustomButton.TabIndex = 1;
            this.txtPrecioProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrecioProducto.CustomButton.UseSelectable = true;
            this.txtPrecioProducto.CustomButton.Visible = false;
            this.txtPrecioProducto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtPrecioProducto, 5);
            this.txtPrecioProducto.Lines = new string[0];
            this.txtPrecioProducto.Location = new System.Drawing.Point(358, 155);
            this.txtPrecioProducto.MaxLength = 0;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.PasswordChar = '\0';
            this.txtPrecioProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioProducto.SelectedText = "";
            this.txtPrecioProducto.SelectionLength = 0;
            this.txtPrecioProducto.SelectionStart = 0;
            this.txtPrecioProducto.ShortcutsEnabled = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size(181, 35);
            this.txtPrecioProducto.TabIndex = 7;
            this.txtPrecioProducto.UseSelectable = true;
            this.txtPrecioProducto.UseStyleColors = true;
            this.txtPrecioProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioProducto.Validated += new System.EventHandler(this.txtPrecioProducto_Validated);
            // 
            // cmbPaisFabricacion
            // 
            this.cmbPaisFabricacion.DisplayFocus = true;
            this.cmbPaisFabricacion.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbPaisFabricacion.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cmbPaisFabricacion, 5);
            this.cmbPaisFabricacion.ItemHeight = 29;
            this.cmbPaisFabricacion.Items.AddRange(new object[] {
            "México",
            "Guatemala",
            "Costa Rica",
            "El Salvador"});
            this.cmbPaisFabricacion.Location = new System.Drawing.Point(358, 201);
            this.cmbPaisFabricacion.Name = "cmbPaisFabricacion";
            this.cmbPaisFabricacion.PromptText = "Elija uno";
            this.cmbPaisFabricacion.Size = new System.Drawing.Size(181, 35);
            this.cmbPaisFabricacion.TabIndex = 6;
            this.cmbPaisFabricacion.UseSelectable = true;
            this.cmbPaisFabricacion.UseStyleColors = true;
            this.cmbPaisFabricacion.SelectedIndexChanged += new System.EventHandler(this.cmbPaisFabricacion_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(149, 211);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(153, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Pais de fabricación";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(149, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Precio producto";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(149, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nombre producto";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(149, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Codigo producto";
            this.metroLabel1.UseStyleColors = true;
            // 
            // tabInformacionRegistrada
            // 
            this.tabInformacionRegistrada.Controls.Add(this.gridProductos);
            this.tabInformacionRegistrada.HorizontalScrollbarBarColor = true;
            this.tabInformacionRegistrada.HorizontalScrollbarHighlightOnWheel = false;
            this.tabInformacionRegistrada.HorizontalScrollbarSize = 10;
            this.tabInformacionRegistrada.Location = new System.Drawing.Point(4, 38);
            this.tabInformacionRegistrada.Name = "tabInformacionRegistrada";
            this.tabInformacionRegistrada.Size = new System.Drawing.Size(684, 418);
            this.tabInformacionRegistrada.TabIndex = 1;
            this.tabInformacionRegistrada.Text = "Información registrada";
            this.tabInformacionRegistrada.VerticalScrollbarBarColor = true;
            this.tabInformacionRegistrada.VerticalScrollbarHighlightOnWheel = false;
            this.tabInformacionRegistrada.VerticalScrollbarSize = 10;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            this.gridProductos.AllowUserToResizeRows = false;
            this.gridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.PrecioProducto,
            this.PaisFabricacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductos.EnableHeadersVisualStyles = false;
            this.gridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductos.Location = new System.Drawing.Point(0, 3);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(684, 412);
            this.gridProductos.TabIndex = 2;
            this.gridProductos.UseStyleColors = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodigoProducto.Frozen = true;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 108;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 111;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioProducto.HeaderText = "Precio Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Width = 102;
            // 
            // PaisFabricacion
            // 
            this.PaisFabricacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaisFabricacion.HeaderText = "Pais de Fabricación";
            this.PaisFabricacion.Name = "PaisFabricacion";
            this.PaisFabricacion.ReadOnly = true;
            this.PaisFabricacion.Width = 117;
            // 
            // tabInformacionOrdenada
            // 
            this.tabInformacionOrdenada.Controls.Add(this.listPrecios);
            this.tabInformacionOrdenada.Controls.Add(this.listCodigos);
            this.tabInformacionOrdenada.Controls.Add(this.metroLabel6);
            this.tabInformacionOrdenada.Controls.Add(this.metroLabel5);
            this.tabInformacionOrdenada.HorizontalScrollbarBarColor = true;
            this.tabInformacionOrdenada.HorizontalScrollbarHighlightOnWheel = false;
            this.tabInformacionOrdenada.HorizontalScrollbarSize = 10;
            this.tabInformacionOrdenada.Location = new System.Drawing.Point(4, 38);
            this.tabInformacionOrdenada.Name = "tabInformacionOrdenada";
            this.tabInformacionOrdenada.Size = new System.Drawing.Size(684, 418);
            this.tabInformacionOrdenada.TabIndex = 2;
            this.tabInformacionOrdenada.Text = "Información ordenada";
            this.tabInformacionOrdenada.VerticalScrollbarBarColor = true;
            this.tabInformacionOrdenada.VerticalScrollbarHighlightOnWheel = false;
            this.tabInformacionOrdenada.VerticalScrollbarSize = 10;
            this.tabInformacionOrdenada.Enter += new System.EventHandler(this.tabInformacionOrdenada_Enter);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(381, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(208, 25);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Precios ordenados (DESC)";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(68, 56);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(206, 25);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Codigos ordenados (ASC)";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // listCodigos
            // 
            this.listCodigos.FormattingEnabled = true;
            this.listCodigos.Location = new System.Drawing.Point(68, 84);
            this.listCodigos.Name = "listCodigos";
            this.listCodigos.Size = new System.Drawing.Size(206, 290);
            this.listCodigos.TabIndex = 6;
            // 
            // listPrecios
            // 
            this.listPrecios.FormattingEnabled = true;
            this.listPrecios.Location = new System.Drawing.Point(381, 84);
            this.listPrecios.Name = "listPrecios";
            this.listPrecios.Size = new System.Drawing.Size(208, 290);
            this.listPrecios.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 540);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Productos de El Salvador";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.tabRegistrarInformacion.ResumeLayout(false);
            this.tabRegistrarInformacion.PerformLayout();
            this.tabInformacionRegistrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.tabInformacionOrdenada.ResumeLayout(false);
            this.tabInformacionOrdenada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabRegistrarInformacion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabInformacionRegistrada;
        private MetroFramework.Controls.MetroTabPage tabInformacionOrdenada;
        private MetroFramework.Controls.MetroTextBox txtCodigoProducto;
        private MetroFramework.Controls.MetroTextBox txtNombreProducto;
        private MetroFramework.Controls.MetroTextBox txtPrecioProducto;
        private MetroFramework.Controls.MetroComboBox cmbPaisFabricacion;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroGrid gridProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisFabricacion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListBox listCodigos;
        private System.Windows.Forms.ListBox listPrecios;
    }
}

