namespace Guia_4
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabIngresoDeDatos = new MetroFramework.Controls.MetroTabPage();
            this.cmbMetodos = new MetroFramework.Controls.MetroComboBox();
            this.txtTotalNumeros = new MetroFramework.Controls.MetroTextBox();
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabListadoDeNumeros = new MetroFramework.Controls.MetroTabPage();
            this.listNumerosOrdenados = new System.Windows.Forms.ListBox();
            this.listNumerosDesordenados = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOrdenar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabIngresoDeDatos.SuspendLayout();
            this.tabListadoDeNumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabIngresoDeDatos);
            this.tabControl.Controls.Add(this.tabListadoDeNumeros);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(526, 316);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // tabIngresoDeDatos
            // 
            this.tabIngresoDeDatos.Controls.Add(this.cmbMetodos);
            this.tabIngresoDeDatos.Controls.Add(this.txtTotalNumeros);
            this.tabIngresoDeDatos.Controls.Add(this.btnGenerar);
            this.tabIngresoDeDatos.Controls.Add(this.metroLabel2);
            this.tabIngresoDeDatos.Controls.Add(this.metroLabel1);
            this.tabIngresoDeDatos.HorizontalScrollbarBarColor = true;
            this.tabIngresoDeDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIngresoDeDatos.HorizontalScrollbarSize = 10;
            this.tabIngresoDeDatos.Location = new System.Drawing.Point(4, 38);
            this.tabIngresoDeDatos.Name = "tabIngresoDeDatos";
            this.tabIngresoDeDatos.Size = new System.Drawing.Size(518, 274);
            this.tabIngresoDeDatos.TabIndex = 0;
            this.tabIngresoDeDatos.Text = "Ingreso de datos";
            this.tabIngresoDeDatos.UseStyleColors = true;
            this.tabIngresoDeDatos.VerticalScrollbarBarColor = true;
            this.tabIngresoDeDatos.VerticalScrollbarHighlightOnWheel = false;
            this.tabIngresoDeDatos.VerticalScrollbarSize = 10;
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.ItemHeight = 23;
            this.cmbMetodos.Items.AddRange(new object[] {
            "ShellSort",
            "MergeSort"});
            this.cmbMetodos.Location = new System.Drawing.Point(292, 88);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.PromptText = "Elija una opcion";
            this.cmbMetodos.Size = new System.Drawing.Size(149, 29);
            this.cmbMetodos.TabIndex = 6;
            this.cmbMetodos.UseSelectable = true;
            this.cmbMetodos.UseStyleColors = true;
            this.cmbMetodos.SelectedIndexChanged += new System.EventHandler(this.cmbMetodos_SelectedIndexChanged);
            // 
            // txtTotalNumeros
            // 
            // 
            // 
            // 
            this.txtTotalNumeros.CustomButton.Image = null;
            this.txtTotalNumeros.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtTotalNumeros.CustomButton.Name = "";
            this.txtTotalNumeros.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTotalNumeros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalNumeros.CustomButton.TabIndex = 1;
            this.txtTotalNumeros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalNumeros.CustomButton.UseSelectable = true;
            this.txtTotalNumeros.CustomButton.Visible = false;
            this.txtTotalNumeros.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotalNumeros.Lines = new string[0];
            this.txtTotalNumeros.Location = new System.Drawing.Point(292, 43);
            this.txtTotalNumeros.MaxLength = 32767;
            this.txtTotalNumeros.Name = "txtTotalNumeros";
            this.txtTotalNumeros.PasswordChar = '\0';
            this.txtTotalNumeros.PromptText = "#";
            this.txtTotalNumeros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalNumeros.SelectedText = "";
            this.txtTotalNumeros.SelectionLength = 0;
            this.txtTotalNumeros.SelectionStart = 0;
            this.txtTotalNumeros.ShortcutsEnabled = true;
            this.txtTotalNumeros.Size = new System.Drawing.Size(149, 29);
            this.txtTotalNumeros.TabIndex = 5;
            this.txtTotalNumeros.UseSelectable = true;
            this.txtTotalNumeros.UseStyleColors = true;
            this.txtTotalNumeros.WaterMark = "#";
            this.txtTotalNumeros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalNumeros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalNumeros.Validated += new System.EventHandler(this.txtTotalNumeros_Validated);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGenerar.Highlight = true;
            this.btnGenerar.Location = new System.Drawing.Point(187, 166);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(134, 54);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.UseStyleColors = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(72, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(192, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Metodo de ordamiento:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(72, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Total de numeros:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // tabListadoDeNumeros
            // 
            this.tabListadoDeNumeros.Controls.Add(this.btnOrdenar);
            this.tabListadoDeNumeros.Controls.Add(this.listNumerosOrdenados);
            this.tabListadoDeNumeros.Controls.Add(this.listNumerosDesordenados);
            this.tabListadoDeNumeros.HorizontalScrollbarBarColor = true;
            this.tabListadoDeNumeros.HorizontalScrollbarHighlightOnWheel = false;
            this.tabListadoDeNumeros.HorizontalScrollbarSize = 10;
            this.tabListadoDeNumeros.Location = new System.Drawing.Point(4, 38);
            this.tabListadoDeNumeros.Name = "tabListadoDeNumeros";
            this.tabListadoDeNumeros.Size = new System.Drawing.Size(518, 274);
            this.tabListadoDeNumeros.TabIndex = 1;
            this.tabListadoDeNumeros.Text = "Listado de numeros";
            this.tabListadoDeNumeros.UseStyleColors = true;
            this.tabListadoDeNumeros.VerticalScrollbarBarColor = true;
            this.tabListadoDeNumeros.VerticalScrollbarHighlightOnWheel = false;
            this.tabListadoDeNumeros.VerticalScrollbarSize = 10;
            this.tabListadoDeNumeros.Leave += new System.EventHandler(this.tabListadoDeNumeros_Leave);
            // 
            // listNumerosOrdenados
            // 
            this.listNumerosOrdenados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNumerosOrdenados.ForeColor = System.Drawing.Color.Magenta;
            this.listNumerosOrdenados.FormattingEnabled = true;
            this.listNumerosOrdenados.ItemHeight = 18;
            this.listNumerosOrdenados.Location = new System.Drawing.Point(349, 15);
            this.listNumerosOrdenados.Name = "listNumerosOrdenados";
            this.listNumerosOrdenados.Size = new System.Drawing.Size(169, 256);
            this.listNumerosOrdenados.TabIndex = 5;
            // 
            // listNumerosDesordenados
            // 
            this.listNumerosDesordenados.BackColor = System.Drawing.SystemColors.Window;
            this.listNumerosDesordenados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNumerosDesordenados.ForeColor = System.Drawing.Color.Magenta;
            this.listNumerosDesordenados.FormattingEnabled = true;
            this.listNumerosDesordenados.ItemHeight = 18;
            this.listNumerosDesordenados.Location = new System.Drawing.Point(0, 15);
            this.listNumerosDesordenados.Name = "listNumerosDesordenados";
            this.listNumerosDesordenados.Size = new System.Drawing.Size(169, 256);
            this.listNumerosDesordenados.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOrdenar.Highlight = true;
            this.btnOrdenar.Location = new System.Drawing.Point(210, 88);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(98, 37);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseSelectable = true;
            this.btnOrdenar.UseStyleColors = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 396);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Metodos de ordenamiento";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabIngresoDeDatos.ResumeLayout(false);
            this.tabIngresoDeDatos.PerformLayout();
            this.tabListadoDeNumeros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabIngresoDeDatos;
        private MetroFramework.Controls.MetroTabPage tabListadoDeNumeros;
        private MetroFramework.Controls.MetroComboBox cmbMetodos;
        private MetroFramework.Controls.MetroTextBox txtTotalNumeros;
        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox listNumerosOrdenados;
        private System.Windows.Forms.ListBox listNumerosDesordenados;
        private MetroFramework.Controls.MetroButton btnOrdenar;
    }
}

