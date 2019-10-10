namespace CapaPresentacion.Seguridad
{
    partial class FrmEmpleados
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
            this.pnlBarraEmpleado = new System.Windows.Forms.Panel();
            this.lblBarraEmpleado = new System.Windows.Forms.Label();
            this.pnlContenedorBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gpbEmpleadoDireccion = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoDireccion = new System.Windows.Forms.TextBox();
            this.gpbEmpleadoNombre = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.gpbEmpleadoCelular = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoCelular = new System.Windows.Forms.TextBox();
            this.gpbEmpleadoDNI = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoDNI = new System.Windows.Forms.TextBox();
            this.gpbEmpleadoEmail = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDatosEmpleado = new System.Windows.Forms.Panel();
            this.pnlRegistroLeft = new System.Windows.Forms.Panel();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteBuscar = new System.Windows.Forms.PictureBox();
            this.btnEmpleadoEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEmpleadoEditar = new System.Windows.Forms.Button();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.btnClienteSalir = new System.Windows.Forms.PictureBox();
            this.pnlBarraEmpleado.SuspendLayout();
            this.pnlContenedorBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gpbEmpleadoDireccion.SuspendLayout();
            this.gpbEmpleadoNombre.SuspendLayout();
            this.gpbEmpleadoCelular.SuspendLayout();
            this.gpbEmpleadoDNI.SuspendLayout();
            this.gpbEmpleadoEmail.SuspendLayout();
            this.pnlDatosEmpleado.SuspendLayout();
            this.pnlRegistroLeft.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraEmpleado
            // 
            this.pnlBarraEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.pnlBarraEmpleado.Controls.Add(this.btnClienteSalir);
            this.pnlBarraEmpleado.Controls.Add(this.lblBarraEmpleado);
            this.pnlBarraEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraEmpleado.Name = "pnlBarraEmpleado";
            this.pnlBarraEmpleado.Size = new System.Drawing.Size(714, 35);
            this.pnlBarraEmpleado.TabIndex = 0;
            // 
            // lblBarraEmpleado
            // 
            this.lblBarraEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarraEmpleado.AutoSize = true;
            this.lblBarraEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lblBarraEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblBarraEmpleado.Location = new System.Drawing.Point(226, 7);
            this.lblBarraEmpleado.Name = "lblBarraEmpleado";
            this.lblBarraEmpleado.Size = new System.Drawing.Size(288, 20);
            this.lblBarraEmpleado.TabIndex = 0;
            this.lblBarraEmpleado.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // pnlContenedorBusqueda
            // 
            this.pnlContenedorBusqueda.BackColor = System.Drawing.Color.Silver;
            this.pnlContenedorBusqueda.Controls.Add(this.txtBuscarEmpleado);
            this.pnlContenedorBusqueda.Controls.Add(this.btnClienteBuscar);
            this.pnlContenedorBusqueda.Controls.Add(this.dgvEmpleados);
            this.pnlContenedorBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorBusqueda.Location = new System.Drawing.Point(0, 403);
            this.pnlContenedorBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda";
            this.pnlContenedorBusqueda.Size = new System.Drawing.Size(714, 238);
            this.pnlContenedorBusqueda.TabIndex = 4;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(59, 23);
            this.txtBuscarEmpleado.MaximumSize = new System.Drawing.Size(400, 29);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(247, 22);
            this.txtBuscarEmpleado.TabIndex = 22;
            this.txtBuscarEmpleado.Text = "Buscar empleado";
            this.txtBuscarEmpleado.Enter += new System.EventHandler(this.TxtBuscarEmpleado_Enter);
            this.txtBuscarEmpleado.Leave += new System.EventHandler(this.TxtBuscarEmpleado_Leave);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(17, 58);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(8, 3, 8, 10);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(680, 161);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // gpbEmpleadoDireccion
            // 
            this.gpbEmpleadoDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmpleadoDireccion.Controls.Add(this.txtEmpleadoDireccion);
            this.gpbEmpleadoDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbEmpleadoDireccion.Location = new System.Drawing.Point(34, 177);
            this.gpbEmpleadoDireccion.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.gpbEmpleadoDireccion.Name = "gpbEmpleadoDireccion";
            this.gpbEmpleadoDireccion.Size = new System.Drawing.Size(238, 44);
            this.gpbEmpleadoDireccion.TabIndex = 13;
            this.gpbEmpleadoDireccion.TabStop = false;
            this.gpbEmpleadoDireccion.Text = "Dirección";
            // 
            // txtEmpleadoDireccion
            // 
            this.txtEmpleadoDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtEmpleadoDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleadoDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpleadoDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoDireccion.ForeColor = System.Drawing.Color.White;
            this.txtEmpleadoDireccion.Location = new System.Drawing.Point(3, 21);
            this.txtEmpleadoDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmpleadoDireccion.Name = "txtEmpleadoDireccion";
            this.txtEmpleadoDireccion.Size = new System.Drawing.Size(232, 18);
            this.txtEmpleadoDireccion.TabIndex = 0;
            // 
            // gpbEmpleadoNombre
            // 
            this.gpbEmpleadoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmpleadoNombre.Controls.Add(this.txtEmpleadoNombre);
            this.gpbEmpleadoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbEmpleadoNombre.Location = new System.Drawing.Point(34, 57);
            this.gpbEmpleadoNombre.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.gpbEmpleadoNombre.Name = "gpbEmpleadoNombre";
            this.gpbEmpleadoNombre.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gpbEmpleadoNombre.Size = new System.Drawing.Size(238, 44);
            this.gpbEmpleadoNombre.TabIndex = 10;
            this.gpbEmpleadoNombre.TabStop = false;
            this.gpbEmpleadoNombre.Text = "Nombre del empleado";
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtEmpleadoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleadoNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpleadoNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoNombre.ForeColor = System.Drawing.Color.White;
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(5, 21);
            this.txtEmpleadoNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(230, 18);
            this.txtEmpleadoNombre.TabIndex = 0;
            // 
            // gpbEmpleadoCelular
            // 
            this.gpbEmpleadoCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmpleadoCelular.Controls.Add(this.txtEmpleadoCelular);
            this.gpbEmpleadoCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbEmpleadoCelular.Location = new System.Drawing.Point(34, 237);
            this.gpbEmpleadoCelular.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.gpbEmpleadoCelular.Name = "gpbEmpleadoCelular";
            this.gpbEmpleadoCelular.Size = new System.Drawing.Size(238, 44);
            this.gpbEmpleadoCelular.TabIndex = 14;
            this.gpbEmpleadoCelular.TabStop = false;
            this.gpbEmpleadoCelular.Text = "Celular";
            // 
            // txtEmpleadoCelular
            // 
            this.txtEmpleadoCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtEmpleadoCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleadoCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpleadoCelular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoCelular.ForeColor = System.Drawing.Color.White;
            this.txtEmpleadoCelular.Location = new System.Drawing.Point(3, 21);
            this.txtEmpleadoCelular.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmpleadoCelular.Name = "txtEmpleadoCelular";
            this.txtEmpleadoCelular.Size = new System.Drawing.Size(232, 18);
            this.txtEmpleadoCelular.TabIndex = 0;
            // 
            // gpbEmpleadoDNI
            // 
            this.gpbEmpleadoDNI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmpleadoDNI.Controls.Add(this.txtEmpleadoDNI);
            this.gpbEmpleadoDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbEmpleadoDNI.Location = new System.Drawing.Point(34, 117);
            this.gpbEmpleadoDNI.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.gpbEmpleadoDNI.Name = "gpbEmpleadoDNI";
            this.gpbEmpleadoDNI.Size = new System.Drawing.Size(238, 44);
            this.gpbEmpleadoDNI.TabIndex = 12;
            this.gpbEmpleadoDNI.TabStop = false;
            this.gpbEmpleadoDNI.Text = "Documento de Identidad";
            // 
            // txtEmpleadoDNI
            // 
            this.txtEmpleadoDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtEmpleadoDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleadoDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpleadoDNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoDNI.ForeColor = System.Drawing.Color.White;
            this.txtEmpleadoDNI.Location = new System.Drawing.Point(3, 21);
            this.txtEmpleadoDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmpleadoDNI.Name = "txtEmpleadoDNI";
            this.txtEmpleadoDNI.Size = new System.Drawing.Size(232, 18);
            this.txtEmpleadoDNI.TabIndex = 0;
            // 
            // gpbEmpleadoEmail
            // 
            this.gpbEmpleadoEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmpleadoEmail.Controls.Add(this.txtEmpleadoEmail);
            this.gpbEmpleadoEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbEmpleadoEmail.Location = new System.Drawing.Point(34, 297);
            this.gpbEmpleadoEmail.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.gpbEmpleadoEmail.Name = "gpbEmpleadoEmail";
            this.gpbEmpleadoEmail.Size = new System.Drawing.Size(238, 44);
            this.gpbEmpleadoEmail.TabIndex = 15;
            this.gpbEmpleadoEmail.TabStop = false;
            this.gpbEmpleadoEmail.Text = "Correo Electrónico";
            // 
            // txtEmpleadoEmail
            // 
            this.txtEmpleadoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtEmpleadoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleadoEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpleadoEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmpleadoEmail.Location = new System.Drawing.Point(3, 21);
            this.txtEmpleadoEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmpleadoEmail.Name = "txtEmpleadoEmail";
            this.txtEmpleadoEmail.Size = new System.Drawing.Size(232, 18);
            this.txtEmpleadoEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "REGISTRO DEL EMPLEADO";
            // 
            // pnlDatosEmpleado
            // 
            this.pnlDatosEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pnlDatosEmpleado.Controls.Add(this.label6);
            this.pnlDatosEmpleado.Controls.Add(this.txtIdEmpleado);
            this.pnlDatosEmpleado.Controls.Add(this.txtDatosAdicionales);
            this.pnlDatosEmpleado.Controls.Add(this.label5);
            this.pnlDatosEmpleado.Controls.Add(this.dtpFechaRetiro);
            this.pnlDatosEmpleado.Controls.Add(this.label4);
            this.pnlDatosEmpleado.Controls.Add(this.dtpFechaIngreso);
            this.pnlDatosEmpleado.Controls.Add(this.label3);
            this.pnlDatosEmpleado.Controls.Add(this.cboRolEmpleado);
            this.pnlDatosEmpleado.Controls.Add(this.label1);
            this.pnlDatosEmpleado.Controls.Add(this.pnlButtom);
            this.pnlDatosEmpleado.Controls.Add(this.pnlRegistroLeft);
            this.pnlDatosEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosEmpleado.Location = new System.Drawing.Point(0, 35);
            this.pnlDatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDatosEmpleado.Name = "pnlDatosEmpleado";
            this.pnlDatosEmpleado.Size = new System.Drawing.Size(714, 368);
            this.pnlDatosEmpleado.TabIndex = 3;
            // 
            // pnlRegistroLeft
            // 
            this.pnlRegistroLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistroLeft.Controls.Add(this.label2);
            this.pnlRegistroLeft.Controls.Add(this.gpbEmpleadoNombre);
            this.pnlRegistroLeft.Controls.Add(this.gpbEmpleadoCelular);
            this.pnlRegistroLeft.Controls.Add(this.gpbEmpleadoDireccion);
            this.pnlRegistroLeft.Controls.Add(this.gpbEmpleadoDNI);
            this.pnlRegistroLeft.Controls.Add(this.gpbEmpleadoEmail);
            this.pnlRegistroLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroLeft.MaximumSize = new System.Drawing.Size(380, 368);
            this.pnlRegistroLeft.Name = "pnlRegistroLeft";
            this.pnlRegistroLeft.Size = new System.Drawing.Size(306, 368);
            this.pnlRegistroLeft.TabIndex = 32;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.pnlButtom.Controls.Add(this.btnEmpleadoEliminar);
            this.pnlButtom.Controls.Add(this.btnLimpiar);
            this.pnlButtom.Controls.Add(this.btnEmpleadoEditar);
            this.pnlButtom.Controls.Add(this.btnCrearEmpleado);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtom.Location = new System.Drawing.Point(590, 0);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(124, 368);
            this.pnlButtom.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(321, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "ID EMPLEADO";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIdEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtIdEmpleado.Location = new System.Drawing.Point(324, 315);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(254, 32);
            this.txtIdEmpleado.TabIndex = 53;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDatosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtDatosAdicionales.ForeColor = System.Drawing.Color.White;
            this.txtDatosAdicionales.Location = new System.Drawing.Point(324, 217);
            this.txtDatosAdicionales.MaximumSize = new System.Drawing.Size(300, 70);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(254, 70);
            this.txtDatosAdicionales.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(321, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Observaciones:";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaRetiro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetiro.Location = new System.Drawing.Point(324, 156);
            this.dtpFechaRetiro.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.dtpFechaRetiro.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRetiro.MaximumSize = new System.Drawing.Size(300, 25);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaRetiro.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(321, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fecha de retiro:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaIngreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(324, 98);
            this.dtpFechaIngreso.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaIngreso.MaximumSize = new System.Drawing.Size(300, 25);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaIngreso.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaIngreso.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(321, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha de Ingreso:";
            // 
            // cboRolEmpleado
            // 
            this.cboRolEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.cboRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRolEmpleado.ForeColor = System.Drawing.Color.White;
            this.cboRolEmpleado.FormattingEnabled = true;
            this.cboRolEmpleado.Location = new System.Drawing.Point(324, 42);
            this.cboRolEmpleado.MaximumSize = new System.Drawing.Size(300, 0);
            this.cboRolEmpleado.Name = "cboRolEmpleado";
            this.cboRolEmpleado.Size = new System.Drawing.Size(254, 25);
            this.cboRolEmpleado.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Rol del empleado:";
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteBuscar.Image = global::CapaPresentacion.Properties.Resources.search_32px;
            this.btnClienteBuscar.Location = new System.Drawing.Point(21, 18);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnClienteBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClienteBuscar.TabIndex = 21;
            this.btnClienteBuscar.TabStop = false;
            // 
            // btnEmpleadoEliminar
            // 
            this.btnEmpleadoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleadoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnEmpleadoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmpleadoEliminar.FlatAppearance.BorderSize = 0;
            this.btnEmpleadoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadoEliminar.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadoEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadoEliminar.Image = global::CapaPresentacion.Properties.Resources.trash_24px;
            this.btnEmpleadoEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadoEliminar.Location = new System.Drawing.Point(9, 311);
            this.btnEmpleadoEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpleadoEliminar.Name = "btnEmpleadoEliminar";
            this.btnEmpleadoEliminar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEmpleadoEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEmpleadoEliminar.TabIndex = 28;
            this.btnEmpleadoEliminar.Text = "    Eliminar";
            this.btnEmpleadoEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.broom_24px;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(9, 149);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(107, 36);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "     Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEmpleadoEditar
            // 
            this.btnEmpleadoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleadoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnEmpleadoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmpleadoEditar.FlatAppearance.BorderSize = 0;
            this.btnEmpleadoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadoEditar.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadoEditar.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadoEditar.Image = global::CapaPresentacion.Properties.Resources.edit_24px;
            this.btnEmpleadoEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadoEditar.Location = new System.Drawing.Point(9, 93);
            this.btnEmpleadoEditar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnEmpleadoEditar.Name = "btnEmpleadoEditar";
            this.btnEmpleadoEditar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEmpleadoEditar.Size = new System.Drawing.Size(107, 36);
            this.btnEmpleadoEditar.TabIndex = 26;
            this.btnEmpleadoEditar.Text = "   Editar";
            this.btnEmpleadoEditar.UseVisualStyleBackColor = false;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnCrearEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCrearEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCrearEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEmpleado.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnCrearEmpleado.Image = global::CapaPresentacion.Properties.Resources.save_24px;
            this.btnCrearEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearEmpleado.Location = new System.Drawing.Point(9, 37);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCrearEmpleado.Size = new System.Drawing.Size(107, 36);
            this.btnCrearEmpleado.TabIndex = 25;
            this.btnCrearEmpleado.Text = "      Guardar";
            this.btnCrearEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteSalir.Image = global::CapaPresentacion.Properties.Resources.multiply_32px;
            this.btnClienteSalir.Location = new System.Drawing.Point(12, 7);
            this.btnClienteSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(30, 22);
            this.btnClienteSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClienteSalir.TabIndex = 13;
            this.btnClienteSalir.TabStop = false;
            this.btnClienteSalir.Click += new System.EventHandler(this.BtnClienteSalir_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 641);
            this.Controls.Add(this.pnlContenedorBusqueda);
            this.Controls.Add(this.pnlDatosEmpleado);
            this.Controls.Add(this.pnlBarraEmpleado);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(714, 561);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.pnlBarraEmpleado.ResumeLayout(false);
            this.pnlBarraEmpleado.PerformLayout();
            this.pnlContenedorBusqueda.ResumeLayout(false);
            this.pnlContenedorBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gpbEmpleadoDireccion.ResumeLayout(false);
            this.gpbEmpleadoDireccion.PerformLayout();
            this.gpbEmpleadoNombre.ResumeLayout(false);
            this.gpbEmpleadoNombre.PerformLayout();
            this.gpbEmpleadoCelular.ResumeLayout(false);
            this.gpbEmpleadoCelular.PerformLayout();
            this.gpbEmpleadoDNI.ResumeLayout(false);
            this.gpbEmpleadoDNI.PerformLayout();
            this.gpbEmpleadoEmail.ResumeLayout(false);
            this.gpbEmpleadoEmail.PerformLayout();
            this.pnlDatosEmpleado.ResumeLayout(false);
            this.pnlDatosEmpleado.PerformLayout();
            this.pnlRegistroLeft.ResumeLayout(false);
            this.pnlRegistroLeft.PerformLayout();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraEmpleado;
        private System.Windows.Forms.Label lblBarraEmpleado;
        private System.Windows.Forms.PictureBox btnClienteSalir;
        private System.Windows.Forms.Panel pnlContenedorBusqueda;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gpbEmpleadoDireccion;
        private System.Windows.Forms.TextBox txtEmpleadoDireccion;
        private System.Windows.Forms.GroupBox gpbEmpleadoNombre;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.GroupBox gpbEmpleadoCelular;
        private System.Windows.Forms.TextBox txtEmpleadoCelular;
        private System.Windows.Forms.GroupBox gpbEmpleadoDNI;
        private System.Windows.Forms.TextBox txtEmpleadoDNI;
        private System.Windows.Forms.GroupBox gpbEmpleadoEmail;
        private System.Windows.Forms.TextBox txtEmpleadoEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDatosEmpleado;
        private System.Windows.Forms.PictureBox btnClienteBuscar;
        private System.Windows.Forms.Panel pnlRegistroLeft;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Button btnEmpleadoEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEmpleadoEditar;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRolEmpleado;
        private System.Windows.Forms.Label label1;
    }
}