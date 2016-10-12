namespace Grafo
{
    partial class Arco
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
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.txtArco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ArcoStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArcoStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAceptar.Highlight = true;
            this.btnAceptar.Location = new System.Drawing.Point(23, 113);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.Highlight = true;
            this.btnCancelar.Location = new System.Drawing.Point(186, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtArco
            // 
            // 
            // 
            // 
            this.txtArco.CustomButton.Image = null;
            this.txtArco.CustomButton.Location = new System.Drawing.Point(71, 2);
            this.txtArco.CustomButton.Name = "";
            this.txtArco.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtArco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArco.CustomButton.TabIndex = 1;
            this.txtArco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArco.CustomButton.UseSelectable = true;
            this.txtArco.CustomButton.Visible = false;
            this.txtArco.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtArco.Lines = new string[0];
            this.txtArco.Location = new System.Drawing.Point(189, 64);
            this.txtArco.MaxLength = 32767;
            this.txtArco.Name = "txtArco";
            this.txtArco.PasswordChar = '\0';
            this.txtArco.PromptText = "#";
            this.txtArco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArco.SelectedText = "";
            this.txtArco.SelectionLength = 0;
            this.txtArco.SelectionStart = 0;
            this.txtArco.ShortcutsEnabled = true;
            this.txtArco.Size = new System.Drawing.Size(97, 28);
            this.txtArco.TabIndex = 7;
            this.txtArco.UseSelectable = true;
            this.txtArco.UseStyleColors = true;
            this.txtArco.WaterMark = "#";
            this.txtArco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArco_KeyDown);
            this.txtArco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArco_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Valor nuevo arco:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // ArcoStyleManager
            // 
            this.ArcoStyleManager.Owner = this;
            this.ArcoStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Arco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 158);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtArco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Arco";
            this.Resizable = false;
            this.Text = "Agregar nuevo arco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Arco_FormClosing);
            this.Load += new System.EventHandler(this.Arco_Load);
            this.Shown += new System.EventHandler(this.Arco_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ArcoStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager ArcoStyleManager;
        public MetroFramework.Controls.MetroTextBox txtArco;
    }
}