namespace HeapForm
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbTipoValor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalElementos = new MetroFramework.Controls.MetroTextBox();
            this.btnOrdenar = new MetroFramework.Controls.MetroButton();
            this.arregloDesordenado = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.arregloOrdenado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(93, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipo valor:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // cmbTipoValor
            // 
            this.cmbTipoValor.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cmbTipoValor, 10);
            this.cmbTipoValor.ItemHeight = 23;
            this.cmbTipoValor.Items.AddRange(new object[] {
            "Numeros",
            "Letras"});
            this.cmbTipoValor.Location = new System.Drawing.Point(306, 85);
            this.cmbTipoValor.Name = "cmbTipoValor";
            this.cmbTipoValor.PromptText = "Seleccionar";
            this.cmbTipoValor.Size = new System.Drawing.Size(121, 29);
            this.cmbTipoValor.TabIndex = 2;
            this.cmbTipoValor.UseSelectable = true;
            this.cmbTipoValor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoValor_SelectedIndexChanged);
            this.cmbTipoValor.Validated += new System.EventHandler(this.cmbTipoValor_Validated);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(93, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Total elementos:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtTotalElementos
            // 
            // 
            // 
            // 
            this.txtTotalElementos.CustomButton.Image = null;
            this.txtTotalElementos.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtTotalElementos.CustomButton.Name = "";
            this.txtTotalElementos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTotalElementos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalElementos.CustomButton.TabIndex = 1;
            this.txtTotalElementos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalElementos.CustomButton.UseSelectable = true;
            this.txtTotalElementos.CustomButton.Visible = false;
            this.txtTotalElementos.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtTotalElementos, 10);
            this.txtTotalElementos.Lines = new string[0];
            this.txtTotalElementos.Location = new System.Drawing.Point(306, 134);
            this.txtTotalElementos.MaxLength = 32767;
            this.txtTotalElementos.Name = "txtTotalElementos";
            this.txtTotalElementos.PasswordChar = '\0';
            this.txtTotalElementos.PromptText = "#";
            this.txtTotalElementos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalElementos.SelectedText = "";
            this.txtTotalElementos.SelectionLength = 0;
            this.txtTotalElementos.SelectionStart = 0;
            this.txtTotalElementos.ShortcutsEnabled = true;
            this.txtTotalElementos.Size = new System.Drawing.Size(121, 29);
            this.txtTotalElementos.TabIndex = 3;
            this.txtTotalElementos.UseSelectable = true;
            this.txtTotalElementos.UseStyleColors = true;
            this.txtTotalElementos.WaterMark = "#";
            this.txtTotalElementos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalElementos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalElementos.Validated += new System.EventHandler(this.txtTotalElementos_Validated);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOrdenar.Highlight = true;
            this.btnOrdenar.Location = new System.Drawing.Point(210, 184);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 46);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseSelectable = true;
            this.btnOrdenar.UseStyleColors = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // arregloDesordenado
            // 
            this.arregloDesordenado.Cursor = System.Windows.Forms.Cursors.Default;
            this.arregloDesordenado.ForeColor = System.Drawing.Color.Green;
            this.arregloDesordenado.FormattingEnabled = true;
            this.arregloDesordenado.Location = new System.Drawing.Point(93, 275);
            this.arregloDesordenado.Name = "arregloDesordenado";
            this.arregloDesordenado.Size = new System.Drawing.Size(120, 147);
            this.arregloDesordenado.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(96, 247);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Desordenado";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(321, 247);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Ordenado";
            this.metroLabel4.UseStyleColors = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // arregloOrdenado
            // 
            this.arregloOrdenado.ForeColor = System.Drawing.Color.Green;
            this.arregloOrdenado.FormattingEnabled = true;
            this.arregloOrdenado.Location = new System.Drawing.Point(306, 275);
            this.arregloOrdenado.Name = "arregloOrdenado";
            this.arregloOrdenado.Size = new System.Drawing.Size(120, 147);
            this.arregloOrdenado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 445);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.arregloDesordenado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtTotalElementos);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbTipoValor);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.arregloOrdenado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "HeapSort";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox txtTotalElementos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbTipoValor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListBox arregloDesordenado;
        private MetroFramework.Controls.MetroButton btnOrdenar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox arregloOrdenado;
    }
}

