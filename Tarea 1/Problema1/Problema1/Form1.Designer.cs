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
            this.txtPrestamo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTasa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMeses = new MetroFramework.Controls.MetroTextBox();
            this.txtCuota = new MetroFramework.Controls.MetroTextBox();
            this.tasaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mesesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.prestamoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tasaErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(150, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Prestamo adquirido";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtPrestamo
            // 
            // 
            // 
            // 
            this.txtPrestamo.CustomButton.Image = null;
            this.txtPrestamo.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtPrestamo.CustomButton.Name = "";
            this.txtPrestamo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrestamo.CustomButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtPrestamo.CustomButton.TabIndex = 1;
            this.txtPrestamo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrestamo.CustomButton.UseSelectable = true;
            this.txtPrestamo.CustomButton.Visible = false;
            this.txtPrestamo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.prestamoErrorProvider.SetIconPadding(this.txtPrestamo, 10);
            this.tasaErrorProvider.SetIconPadding(this.txtPrestamo, 10);
            this.mesesErrorProvider.SetIconPadding(this.txtPrestamo, 10);
            this.txtPrestamo.Lines = new string[0];
            this.txtPrestamo.Location = new System.Drawing.Point(350, 100);
            this.txtPrestamo.MaxLength = 32767;
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.PasswordChar = '\0';
            this.txtPrestamo.PromptText = "$";
            this.txtPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrestamo.SelectedText = "";
            this.txtPrestamo.SelectionLength = 0;
            this.txtPrestamo.SelectionStart = 0;
            this.txtPrestamo.ShortcutsEnabled = true;
            this.txtPrestamo.Size = new System.Drawing.Size(150, 25);
            this.txtPrestamo.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPrestamo.TabIndex = 1;
            this.txtPrestamo.UseSelectable = true;
            this.txtPrestamo.UseStyleColors = true;
            this.txtPrestamo.WaterMark = "$";
            this.txtPrestamo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrestamo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrestamo.Validated += new System.EventHandler(this.txtPrestamo_Validated);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(150, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tasa de interes";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtTasa
            // 
            // 
            // 
            // 
            this.txtTasa.CustomButton.Image = null;
            this.txtTasa.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtTasa.CustomButton.Name = "";
            this.txtTasa.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTasa.CustomButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtTasa.CustomButton.TabIndex = 1;
            this.txtTasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTasa.CustomButton.UseSelectable = true;
            this.txtTasa.CustomButton.Visible = false;
            this.txtTasa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.prestamoErrorProvider.SetIconPadding(this.txtTasa, 10);
            this.tasaErrorProvider.SetIconPadding(this.txtTasa, 10);
            this.mesesErrorProvider.SetIconPadding(this.txtTasa, 10);
            this.txtTasa.Lines = new string[0];
            this.txtTasa.Location = new System.Drawing.Point(350, 150);
            this.txtTasa.MaxLength = 32767;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.PasswordChar = '\0';
            this.txtTasa.PromptText = "%";
            this.txtTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTasa.SelectedText = "";
            this.txtTasa.SelectionLength = 0;
            this.txtTasa.SelectionStart = 0;
            this.txtTasa.ShortcutsEnabled = true;
            this.txtTasa.Size = new System.Drawing.Size(150, 25);
            this.txtTasa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTasa.TabIndex = 3;
            this.txtTasa.UseSelectable = true;
            this.txtTasa.UseStyleColors = true;
            this.txtTasa.WaterMark = "%";
            this.txtTasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTasa.Validated += new System.EventHandler(this.txtTasa_Validated);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(150, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(151, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Numero de meses";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtMeses
            // 
            // 
            // 
            // 
            this.txtMeses.CustomButton.Image = null;
            this.txtMeses.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtMeses.CustomButton.Name = "";
            this.txtMeses.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMeses.CustomButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtMeses.CustomButton.TabIndex = 1;
            this.txtMeses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMeses.CustomButton.UseSelectable = true;
            this.txtMeses.CustomButton.Visible = false;
            this.txtMeses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.prestamoErrorProvider.SetIconPadding(this.txtMeses, 10);
            this.tasaErrorProvider.SetIconPadding(this.txtMeses, 10);
            this.mesesErrorProvider.SetIconPadding(this.txtMeses, 10);
            this.txtMeses.Lines = new string[0];
            this.txtMeses.Location = new System.Drawing.Point(350, 200);
            this.txtMeses.MaxLength = 32767;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.PasswordChar = '\0';
            this.txtMeses.PromptText = "#";
            this.txtMeses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMeses.SelectedText = "";
            this.txtMeses.SelectionLength = 0;
            this.txtMeses.SelectionStart = 0;
            this.txtMeses.ShortcutsEnabled = true;
            this.txtMeses.Size = new System.Drawing.Size(150, 25);
            this.txtMeses.Style = MetroFramework.MetroColorStyle.Red;
            this.txtMeses.TabIndex = 5;
            this.txtMeses.UseSelectable = true;
            this.txtMeses.UseStyleColors = true;
            this.txtMeses.WaterMark = "#";
            this.txtMeses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMeses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMeses.Validated += new System.EventHandler(this.txtMeses_Validated);
            // 
            // txtCuota
            // 
            // 
            // 
            // 
            this.txtCuota.CustomButton.AccessibleName = "";
            this.txtCuota.CustomButton.Image = null;
            this.txtCuota.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.txtCuota.CustomButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtCuota.CustomButton.Name = "btnCalcular";
            this.txtCuota.CustomButton.Size = new System.Drawing.Size(100, 25);
            this.txtCuota.CustomButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtCuota.CustomButton.TabIndex = 1;
            this.txtCuota.CustomButton.Text = "Calcular";
            this.txtCuota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCuota.CustomButton.UseSelectable = true;
            this.txtCuota.CustomButton.UseStyleColors = true;
            this.txtCuota.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCuota.Lines = new string[0];
            this.txtCuota.Location = new System.Drawing.Point(209, 289);
            this.txtCuota.MaxLength = 32767;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.PasswordChar = '\0';
            this.txtCuota.PromptText = "Cuota mensual";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCuota.SelectedText = "";
            this.txtCuota.SelectionLength = 0;
            this.txtCuota.SelectionStart = 0;
            this.txtCuota.ShortcutsEnabled = true;
            this.txtCuota.ShowButton = true;
            this.txtCuota.Size = new System.Drawing.Size(243, 30);
            this.txtCuota.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCuota.TabIndex = 7;
            this.txtCuota.UseSelectable = true;
            this.txtCuota.UseStyleColors = true;
            this.txtCuota.WaterMark = "Cuota mensual";
            this.txtCuota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCuota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tasaErrorProvider
            // 
            this.tasaErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.tasaErrorProvider.ContainerControl = this;
            // 
            // mesesErrorProvider
            // 
            this.mesesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.mesesErrorProvider.ContainerControl = this;
            // 
            // prestamoErrorProvider
            // 
            this.prestamoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.prestamoErrorProvider.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Calculadora cuota mensual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasaErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrestamo;
        private MetroFramework.Controls.MetroTextBox txtTasa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMeses;
        private MetroFramework.Controls.MetroTextBox txtCuota;
        private System.Windows.Forms.ErrorProvider tasaErrorProvider;
        private System.Windows.Forms.ErrorProvider mesesErrorProvider;
        private System.Windows.Forms.ErrorProvider prestamoErrorProvider;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

