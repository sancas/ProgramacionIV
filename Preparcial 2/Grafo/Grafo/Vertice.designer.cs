namespace Grafo
{
    partial class Vertice
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtVertice = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.VerticeStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VerticeStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Valor nuevo vertice:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtVertice
            // 
            // 
            // 
            // 
            this.txtVertice.CustomButton.Image = null;
            this.txtVertice.CustomButton.Location = new System.Drawing.Point(71, 2);
            this.txtVertice.CustomButton.Name = "";
            this.txtVertice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtVertice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVertice.CustomButton.TabIndex = 1;
            this.txtVertice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVertice.CustomButton.UseSelectable = true;
            this.txtVertice.CustomButton.Visible = false;
            this.txtVertice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtVertice.Lines = new string[0];
            this.txtVertice.Location = new System.Drawing.Point(189, 65);
            this.txtVertice.MaxLength = 32767;
            this.txtVertice.Name = "txtVertice";
            this.txtVertice.PasswordChar = '\0';
            this.txtVertice.PromptText = "#";
            this.txtVertice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVertice.SelectedText = "";
            this.txtVertice.SelectionLength = 0;
            this.txtVertice.SelectionStart = 0;
            this.txtVertice.ShortcutsEnabled = true;
            this.txtVertice.Size = new System.Drawing.Size(97, 28);
            this.txtVertice.TabIndex = 11;
            this.txtVertice.UseSelectable = true;
            this.txtVertice.UseStyleColors = true;
            this.txtVertice.WaterMark = "#";
            this.txtVertice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVertice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVertice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVertice_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.Highlight = true;
            this.btnCancelar.Location = new System.Drawing.Point(186, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAceptar.Highlight = true;
            this.btnAceptar.Location = new System.Drawing.Point(23, 114);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // VerticeStyleManager
            // 
            this.VerticeStyleManager.Owner = this;
            this.VerticeStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Vertice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 158);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtVertice);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vertice";
            this.Resizable = false;
            this.Text = "Agregar nuevo vertice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vertice_FormClosing);
            this.Load += new System.EventHandler(this.Vertice_Load);
            this.Shown += new System.EventHandler(this.Vertice_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.VerticeStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAceptar;
        public MetroFramework.Controls.MetroTextBox txtVertice;
        private MetroFramework.Components.MetroStyleManager VerticeStyleManager;

    }
}