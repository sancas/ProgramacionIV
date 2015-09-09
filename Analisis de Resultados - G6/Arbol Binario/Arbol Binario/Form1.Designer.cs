namespace Arbol_Binario
{
    partial class frmPrincipal
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
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnDelNode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.lblRecorridos = new System.Windows.Forms.Label();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSumatorias = new System.Windows.Forms.Label();
            this.rbtnTotal = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplosDos = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplosTres = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplosCinco = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNode
            // 
            this.btnAddNode.Enabled = false;
            this.btnAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNode.Location = new System.Drawing.Point(12, 77);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(161, 36);
            this.btnAddNode.TabIndex = 0;
            this.btnAddNode.Text = "Agregar Nodo";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnDelNode
            // 
            this.btnDelNode.Enabled = false;
            this.btnDelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelNode.Location = new System.Drawing.Point(12, 119);
            this.btnDelNode.Name = "btnDelNode";
            this.btnDelNode.Size = new System.Drawing.Size(161, 36);
            this.btnDelNode.TabIndex = 1;
            this.btnDelNode.Text = "Eliminar Nodo";
            this.btnDelNode.UseVisualStyleBackColor = true;
            this.btnDelNode.Click += new System.EventHandler(this.btnDelNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.rbtnMultiplosCinco);
            this.groupBox1.Controls.Add(this.rbtnMultiplosTres);
            this.groupBox1.Controls.Add(this.rbtnMultiplosDos);
            this.groupBox1.Controls.Add(this.rbtnTotal);
            this.groupBox1.Controls.Add(this.lblSumatorias);
            this.groupBox1.Controls.Add(this.btnPreOrden);
            this.groupBox1.Controls.Add(this.lblRecorridos);
            this.groupBox1.Controls.Add(this.btnPostOrden);
            this.groupBox1.Controls.Add(this.btnInOrden);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.btnDelNode);
            this.groupBox1.Controls.Add(this.btnAddNode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 527);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Enabled = false;
            this.btnPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrden.Location = new System.Drawing.Point(12, 223);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(161, 36);
            this.btnPreOrden.TabIndex = 8;
            this.btnPreOrden.Text = "Pre-Orden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // lblRecorridos
            // 
            this.lblRecorridos.AutoSize = true;
            this.lblRecorridos.Location = new System.Drawing.Point(12, 158);
            this.lblRecorridos.Name = "lblRecorridos";
            this.lblRecorridos.Size = new System.Drawing.Size(86, 20);
            this.lblRecorridos.TabIndex = 7;
            this.lblRecorridos.Text = "Recorridos";
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Enabled = false;
            this.btnPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostOrden.Location = new System.Drawing.Point(12, 265);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(161, 36);
            this.btnPostOrden.TabIndex = 6;
            this.btnPostOrden.Text = "Post-Orden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.Enabled = false;
            this.btnInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrden.Location = new System.Drawing.Point(12, 181);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(161, 36);
            this.btnInOrden.TabIndex = 5;
            this.btnInOrden.Text = "In-Orden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(161, 26);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 22);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblSumatorias
            // 
            this.lblSumatorias.AutoSize = true;
            this.lblSumatorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatorias.Location = new System.Drawing.Point(12, 304);
            this.lblSumatorias.Name = "lblSumatorias";
            this.lblSumatorias.Size = new System.Drawing.Size(90, 20);
            this.lblSumatorias.TabIndex = 9;
            this.lblSumatorias.Text = "Sumatorias";
            // 
            // rbtnTotal
            // 
            this.rbtnTotal.AutoSize = true;
            this.rbtnTotal.Enabled = false;
            this.rbtnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTotal.Location = new System.Drawing.Point(12, 327);
            this.rbtnTotal.Name = "rbtnTotal";
            this.rbtnTotal.Size = new System.Drawing.Size(62, 24);
            this.rbtnTotal.TabIndex = 10;
            this.rbtnTotal.TabStop = true;
            this.rbtnTotal.Text = "Total";
            this.rbtnTotal.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplosDos
            // 
            this.rbtnMultiplosDos.AutoSize = true;
            this.rbtnMultiplosDos.Enabled = false;
            this.rbtnMultiplosDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiplosDos.Location = new System.Drawing.Point(12, 357);
            this.rbtnMultiplosDos.Name = "rbtnMultiplosDos";
            this.rbtnMultiplosDos.Size = new System.Drawing.Size(102, 24);
            this.rbtnMultiplosDos.TabIndex = 11;
            this.rbtnMultiplosDos.TabStop = true;
            this.rbtnMultiplosDos.Text = "Multiplos 2";
            this.rbtnMultiplosDos.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplosTres
            // 
            this.rbtnMultiplosTres.AutoSize = true;
            this.rbtnMultiplosTres.Enabled = false;
            this.rbtnMultiplosTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiplosTres.Location = new System.Drawing.Point(12, 387);
            this.rbtnMultiplosTres.Name = "rbtnMultiplosTres";
            this.rbtnMultiplosTres.Size = new System.Drawing.Size(102, 24);
            this.rbtnMultiplosTres.TabIndex = 12;
            this.rbtnMultiplosTres.TabStop = true;
            this.rbtnMultiplosTres.Text = "Multiplos 3";
            this.rbtnMultiplosTres.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplosCinco
            // 
            this.rbtnMultiplosCinco.AutoSize = true;
            this.rbtnMultiplosCinco.Enabled = false;
            this.rbtnMultiplosCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiplosCinco.Location = new System.Drawing.Point(12, 417);
            this.rbtnMultiplosCinco.Name = "rbtnMultiplosCinco";
            this.rbtnMultiplosCinco.Size = new System.Drawing.Size(102, 24);
            this.rbtnMultiplosCinco.TabIndex = 13;
            this.rbtnMultiplosCinco.TabStop = true;
            this.rbtnMultiplosCinco.Text = "Multiplos 5";
            this.rbtnMultiplosCinco.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAltura.Location = new System.Drawing.Point(3, 504);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(55, 20);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 527);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Arbol Binario";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnDelNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Label lblRecorridos;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbtnMultiplosCinco;
        private System.Windows.Forms.RadioButton rbtnMultiplosTres;
        private System.Windows.Forms.RadioButton rbtnMultiplosDos;
        private System.Windows.Forms.RadioButton rbtnTotal;
        private System.Windows.Forms.Label lblSumatorias;
    }
}

