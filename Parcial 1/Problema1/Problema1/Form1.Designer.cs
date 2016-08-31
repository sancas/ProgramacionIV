namespace Problema1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.cmbMetodo = new MetroFramework.Controls.MetroComboBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabDatos = new MetroFramework.Controls.MetroTabPage();
            this.lblOrden = new MetroFramework.Controls.MetroLabel();
            this.toggleOrden = new MetroFramework.Controls.MetroToggle();
            this.tabListas = new MetroFramework.Controls.MetroTabPage();
            this.btnOrdenar = new MetroFramework.Controls.MetroButton();
            this.listDesordenados = new System.Windows.Forms.ListBox();
            this.listOrdenados = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.tabListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(96, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Cantidad de letras";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(94, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Metodo";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(94, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Orden";
            this.metroLabel3.UseStyleColors = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGenerar.Highlight = true;
            this.btnGenerar.Location = new System.Drawing.Point(186, 209);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 54);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.UseStyleColors = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtCantidad, 10);
            this.txtCantidad.Lines = new string[0];
            this.txtCantidad.Location = new System.Drawing.Point(255, 34);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PromptText = "#";
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(128, 29);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.UseStyleColors = true;
            this.txtCantidad.WaterMark = "#";
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cmbMetodo, 10);
            this.cmbMetodo.ItemHeight = 23;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Inserción",
            "Selección"});
            this.cmbMetodo.Location = new System.Drawing.Point(255, 82);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.PromptText = "Escoge uno";
            this.cmbMetodo.Size = new System.Drawing.Size(128, 29);
            this.cmbMetodo.TabIndex = 1;
            this.cmbMetodo.UseSelectable = true;
            this.cmbMetodo.UseStyleColors = true;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDatos);
            this.tabControl.Controls.Add(this.tabListas);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(490, 339);
            this.tabControl.TabIndex = 8;
            this.tabControl.UseSelectable = true;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.lblOrden);
            this.tabDatos.Controls.Add(this.toggleOrden);
            this.tabDatos.Controls.Add(this.cmbMetodo);
            this.tabDatos.Controls.Add(this.btnGenerar);
            this.tabDatos.Controls.Add(this.txtCantidad);
            this.tabDatos.Controls.Add(this.metroLabel1);
            this.tabDatos.Controls.Add(this.metroLabel2);
            this.tabDatos.Controls.Add(this.metroLabel3);
            this.tabDatos.HorizontalScrollbarBarColor = true;
            this.tabDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDatos.HorizontalScrollbarSize = 10;
            this.tabDatos.Location = new System.Drawing.Point(4, 38);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Size = new System.Drawing.Size(482, 297);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Ingreso de Datos";
            this.tabDatos.VerticalScrollbarBarColor = true;
            this.tabDatos.VerticalScrollbarHighlightOnWheel = false;
            this.tabDatos.VerticalScrollbarSize = 10;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(255, 134);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(34, 19);
            this.lblOrden.TabIndex = 9;
            this.lblOrden.Text = "ASC";
            // 
            // toggleOrden
            // 
            this.toggleOrden.Checked = true;
            this.toggleOrden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleOrden.DisplayStatus = false;
            this.toggleOrden.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.errorProvider.SetIconPadding(this.toggleOrden, 10);
            this.toggleOrden.Location = new System.Drawing.Point(305, 130);
            this.toggleOrden.Name = "toggleOrden";
            this.toggleOrden.Size = new System.Drawing.Size(78, 29);
            this.toggleOrden.TabIndex = 8;
            this.toggleOrden.Text = "On";
            this.toggleOrden.UseSelectable = true;
            this.toggleOrden.UseStyleColors = true;
            this.toggleOrden.CheckedChanged += new System.EventHandler(this.toggleOrden_CheckedChanged);
            // 
            // tabListas
            // 
            this.tabListas.Controls.Add(this.btnOrdenar);
            this.tabListas.Controls.Add(this.listDesordenados);
            this.tabListas.Controls.Add(this.listOrdenados);
            this.tabListas.HorizontalScrollbarBarColor = true;
            this.tabListas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabListas.HorizontalScrollbarSize = 10;
            this.tabListas.Location = new System.Drawing.Point(4, 38);
            this.tabListas.Name = "tabListas";
            this.tabListas.Size = new System.Drawing.Size(482, 297);
            this.tabListas.TabIndex = 1;
            this.tabListas.Text = "Listado";
            this.tabListas.VerticalScrollbarBarColor = true;
            this.tabListas.VerticalScrollbarHighlightOnWheel = false;
            this.tabListas.VerticalScrollbarSize = 10;
            this.tabListas.Leave += new System.EventHandler(this.tabListas_Leave);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOrdenar.Highlight = true;
            this.btnOrdenar.Location = new System.Drawing.Point(205, 125);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(80, 47);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseSelectable = true;
            this.btnOrdenar.UseStyleColors = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // listDesordenados
            // 
            this.listDesordenados.FormattingEnabled = true;
            this.listDesordenados.Location = new System.Drawing.Point(3, 3);
            this.listDesordenados.Name = "listDesordenados";
            this.listDesordenados.Size = new System.Drawing.Size(164, 290);
            this.listDesordenados.TabIndex = 3;
            // 
            // listOrdenados
            // 
            this.listOrdenados.FormattingEnabled = true;
            this.listOrdenados.Location = new System.Drawing.Point(315, 3);
            this.listOrdenados.Name = "listOrdenados";
            this.listOrdenados.Size = new System.Drawing.Size(164, 290);
            this.listOrdenados.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(530, 419);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Metodos de ordenamiento";
            this.tabControl.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabDatos.PerformLayout();
            this.tabListas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroComboBox cmbMetodo;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabDatos;
        private MetroFramework.Controls.MetroTabPage tabListas;
        private System.Windows.Forms.ListBox listOrdenados;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ListBox listDesordenados;
        private MetroFramework.Controls.MetroButton btnOrdenar;
        private MetroFramework.Controls.MetroToggle toggleOrden;
        private MetroFramework.Controls.MetroLabel lblOrden;
    }
}

