namespace CapaPresentacion.Administracion
{
    partial class FrmCategorias
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
            this.pnlBarraCliente = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblBarraCliente = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpbCategoriaNombre = new System.Windows.Forms.GroupBox();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBarraCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbCategoriaNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraCliente
            // 
            this.pnlBarraCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.pnlBarraCliente.Controls.Add(this.btnSalir);
            this.pnlBarraCliente.Controls.Add(this.lblBarraCliente);
            this.pnlBarraCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraCliente.Name = "pnlBarraCliente";
            this.pnlBarraCliente.Size = new System.Drawing.Size(714, 35);
            this.pnlBarraCliente.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.multiply_32px;
            this.btnSalir.Location = new System.Drawing.Point(12, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 22);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 12;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblBarraCliente
            // 
            this.lblBarraCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarraCliente.AutoSize = true;
            this.lblBarraCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraCliente.ForeColor = System.Drawing.Color.White;
            this.lblBarraCliente.Location = new System.Drawing.Point(288, 8);
            this.lblBarraCliente.Name = "lblBarraCliente";
            this.lblBarraCliente.Size = new System.Drawing.Size(115, 20);
            this.lblBarraCliente.TabIndex = 5;
            this.lblBarraCliente.Text = "CATEGORÍAS";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pnlFormulario.Controls.Add(this.panel1);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 35);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(714, 283);
            this.pnlFormulario.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.gpbCategoriaNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(398, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 283);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Referencia categoría:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 29);
            this.comboBox1.TabIndex = 12;
            // 
            // gpbCategoriaNombre
            // 
            this.gpbCategoriaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCategoriaNombre.Controls.Add(this.txtCategoriaNombre);
            this.gpbCategoriaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbCategoriaNombre.Location = new System.Drawing.Point(23, 94);
            this.gpbCategoriaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.gpbCategoriaNombre.Name = "gpbCategoriaNombre";
            this.gpbCategoriaNombre.Padding = new System.Windows.Forms.Padding(4);
            this.gpbCategoriaNombre.Size = new System.Drawing.Size(244, 48);
            this.gpbCategoriaNombre.TabIndex = 11;
            this.gpbCategoriaNombre.TabStop = false;
            this.gpbCategoriaNombre.Text = "Nombre categoría";
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtCategoriaNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoriaNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategoriaNombre.ForeColor = System.Drawing.Color.White;
            this.txtCategoriaNombre.Location = new System.Drawing.Point(4, 20);
            this.txtCategoriaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(236, 16);
            this.txtCategoriaNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "REGISTRO CATEGORÍA";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 607);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlBarraCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(714, 561);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCategorias";
            this.pnlBarraCliente.ResumeLayout(false);
            this.pnlBarraCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbCategoriaNombre.ResumeLayout(false);
            this.gpbCategoriaNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraCliente;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblBarraCliente;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gpbCategoriaNombre;
        private System.Windows.Forms.TextBox txtCategoriaNombre;
        private System.Windows.Forms.Label label2;
    }
}