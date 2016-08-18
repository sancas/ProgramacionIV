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
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.tasaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mesesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.prestamoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tasaErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoErrorProvider)).BeginInit();
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
            this.txtPrestamo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrestamo.Location = new System.Drawing.Point(350, 100);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.PromptText = "$";
            this.txtPrestamo.Size = new System.Drawing.Size(150, 25);
            this.txtPrestamo.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPrestamo.TabIndex = 1;
            this.txtPrestamo.Text = " ";
            this.txtPrestamo.UseStyleColors = true;
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
            this.txtTasa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTasa.Location = new System.Drawing.Point(350, 150);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.PromptText = "%";
            this.txtTasa.Size = new System.Drawing.Size(150, 25);
            this.txtTasa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTasa.TabIndex = 3;
            this.txtTasa.Text = " ";
            this.txtTasa.UseStyleColors = true;
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
            this.txtMeses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMeses.Location = new System.Drawing.Point(350, 200);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.PromptText = "#";
            this.txtMeses.Size = new System.Drawing.Size(150, 25);
            this.txtMeses.Style = MetroFramework.MetroColorStyle.Red;
            this.txtMeses.TabIndex = 5;
            this.txtMeses.Text = " ";
            this.txtMeses.UseStyleColors = true;
            this.txtMeses.Validated += new System.EventHandler(this.txtMeses_Validated);
            // 
            // txtCuota
            // 
            this.txtCuota.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCuota.Location = new System.Drawing.Point(257, 291);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.PromptText = "Cuota mensual";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.Size = new System.Drawing.Size(135, 30);
            this.txtCuota.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCuota.TabIndex = 7;
            this.txtCuota.Text = " ";
            this.txtCuota.UseStyleColors = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Highlight = true;
            this.btnCalcular.Location = new System.Drawing.Point(287, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.Controls.Add(this.btnCalcular);
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
        private MetroFramework.Controls.MetroButton btnCalcular;
        private System.Windows.Forms.ErrorProvider tasaErrorProvider;
        private System.Windows.Forms.ErrorProvider mesesErrorProvider;
        private System.Windows.Forms.ErrorProvider prestamoErrorProvider;
    }
}

