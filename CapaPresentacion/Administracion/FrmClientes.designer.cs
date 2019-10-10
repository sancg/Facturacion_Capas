namespace CapaPresentacion.Administracion
{
    partial class FrmClientes
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
            this.lblBarraCliente = new System.Windows.Forms.Label();
            this.gpbClienteNombre = new System.Windows.Forms.GroupBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.gpbClienteDireccion = new System.Windows.Forms.GroupBox();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.gpbClienteEmail = new System.Windows.Forms.GroupBox();
            this.txtClienteEmail = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbClienteCelular = new System.Windows.Forms.GroupBox();
            this.txtClienteCelular = new System.Windows.Forms.TextBox();
            this.gpbClienteId = new System.Windows.Forms.GroupBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnClienteBuscar = new System.Windows.Forms.PictureBox();
            this.btnClienteSalir = new System.Windows.Forms.PictureBox();
            this.pnlBarraCliente.SuspendLayout();
            this.gpbClienteNombre.SuspendLayout();
            this.pnlDatosCliente.SuspendLayout();
            this.gpbClienteDireccion.SuspendLayout();
            this.gpbClienteEmail.SuspendLayout();
            this.gpbClienteCelular.SuspendLayout();
            this.gpbClienteId.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraCliente
            // 
            this.pnlBarraCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.pnlBarraCliente.Controls.Add(this.btnClienteSalir);
            this.pnlBarraCliente.Controls.Add(this.lblBarraCliente);
            this.pnlBarraCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraCliente.Name = "pnlBarraCliente";
            this.pnlBarraCliente.Size = new System.Drawing.Size(714, 35);
            this.pnlBarraCliente.TabIndex = 0;
            // 
            // lblBarraCliente
            // 
            this.lblBarraCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarraCliente.AutoSize = true;
            this.lblBarraCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraCliente.ForeColor = System.Drawing.Color.White;
            this.lblBarraCliente.Location = new System.Drawing.Point(295, 8);
            this.lblBarraCliente.Name = "lblBarraCliente";
            this.lblBarraCliente.Size = new System.Drawing.Size(88, 20);
            this.lblBarraCliente.TabIndex = 5;
            this.lblBarraCliente.Text = "CLIENTES";
            // 
            // gpbClienteNombre
            // 
            this.gpbClienteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClienteNombre.Controls.Add(this.txtClienteNombre);
            this.gpbClienteNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbClienteNombre.Location = new System.Drawing.Point(59, 103);
            this.gpbClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClienteNombre.Name = "gpbClienteNombre";
            this.gpbClienteNombre.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClienteNombre.Size = new System.Drawing.Size(218, 51);
            this.gpbClienteNombre.TabIndex = 1;
            this.gpbClienteNombre.TabStop = false;
            this.gpbClienteNombre.Text = "Nombre del cliente";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtClienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClienteNombre.ForeColor = System.Drawing.Color.White;
            this.txtClienteNombre.Location = new System.Drawing.Point(4, 22);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(210, 18);
            this.txtClienteNombre.TabIndex = 0;
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pnlDatosCliente.Controls.Add(this.gpbClienteDireccion);
            this.pnlDatosCliente.Controls.Add(this.gpbClienteEmail);
            this.pnlDatosCliente.Controls.Add(this.label2);
            this.pnlDatosCliente.Controls.Add(this.gpbClienteCelular);
            this.pnlDatosCliente.Controls.Add(this.gpbClienteId);
            this.pnlDatosCliente.Controls.Add(this.gpbClienteNombre);
            this.pnlDatosCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatosCliente.Location = new System.Drawing.Point(0, 35);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(340, 512);
            this.pnlDatosCliente.TabIndex = 2;
            // 
            // gpbClienteDireccion
            // 
            this.gpbClienteDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClienteDireccion.Controls.Add(this.txtClienteDireccion);
            this.gpbClienteDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbClienteDireccion.Location = new System.Drawing.Point(59, 228);
            this.gpbClienteDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClienteDireccion.Name = "gpbClienteDireccion";
            this.gpbClienteDireccion.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClienteDireccion.Size = new System.Drawing.Size(218, 51);
            this.gpbClienteDireccion.TabIndex = 3;
            this.gpbClienteDireccion.TabStop = false;
            this.gpbClienteDireccion.Text = "Dirección";
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtClienteDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClienteDireccion.ForeColor = System.Drawing.Color.White;
            this.txtClienteDireccion.Location = new System.Drawing.Point(4, 22);
            this.txtClienteDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(210, 18);
            this.txtClienteDireccion.TabIndex = 0;
            // 
            // gpbClienteEmail
            // 
            this.gpbClienteEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClienteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.gpbClienteEmail.Controls.Add(this.txtClienteEmail);
            this.gpbClienteEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbClienteEmail.Location = new System.Drawing.Point(59, 346);
            this.gpbClienteEmail.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClienteEmail.Name = "gpbClienteEmail";
            this.gpbClienteEmail.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClienteEmail.Size = new System.Drawing.Size(218, 51);
            this.gpbClienteEmail.TabIndex = 5;
            this.gpbClienteEmail.TabStop = false;
            this.gpbClienteEmail.Text = "Correo Electrónico";
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtClienteEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClienteEmail.ForeColor = System.Drawing.Color.White;
            this.txtClienteEmail.Location = new System.Drawing.Point(4, 22);
            this.txtClienteEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(210, 18);
            this.txtClienteEmail.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.broom_24px;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(364, 33);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(148, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = " Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnCrearCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCrearCliente.FlatAppearance.BorderSize = 0;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.Image = global::CapaPresentacion.Properties.Resources.save_24px;
            this.btnCrearCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCliente.Location = new System.Drawing.Point(26, 33);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(18, 3, 10, 3);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCrearCliente.Size = new System.Drawing.Size(148, 34);
            this.btnCrearCliente.TabIndex = 6;
            this.btnCrearCliente.Text = "  Guardar";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "REGISTRO DEL CLIENTE";
            // 
            // gpbClienteCelular
            // 
            this.gpbClienteCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClienteCelular.Controls.Add(this.txtClienteCelular);
            this.gpbClienteCelular.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbClienteCelular.Location = new System.Drawing.Point(59, 287);
            this.gpbClienteCelular.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClienteCelular.Name = "gpbClienteCelular";
            this.gpbClienteCelular.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClienteCelular.Size = new System.Drawing.Size(218, 51);
            this.gpbClienteCelular.TabIndex = 4;
            this.gpbClienteCelular.TabStop = false;
            this.gpbClienteCelular.Text = "Celular";
            // 
            // txtClienteCelular
            // 
            this.txtClienteCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtClienteCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClienteCelular.ForeColor = System.Drawing.Color.White;
            this.txtClienteCelular.Location = new System.Drawing.Point(4, 22);
            this.txtClienteCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteCelular.Name = "txtClienteCelular";
            this.txtClienteCelular.Size = new System.Drawing.Size(210, 18);
            this.txtClienteCelular.TabIndex = 0;
            // 
            // gpbClienteId
            // 
            this.gpbClienteId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClienteId.Controls.Add(this.txtClienteId);
            this.gpbClienteId.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbClienteId.Location = new System.Drawing.Point(59, 169);
            this.gpbClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClienteId.Name = "gpbClienteId";
            this.gpbClienteId.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClienteId.Size = new System.Drawing.Size(218, 51);
            this.gpbClienteId.TabIndex = 2;
            this.gpbClienteId.TabStop = false;
            this.gpbClienteId.Text = "Documento de identidad";
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClienteId.ForeColor = System.Drawing.Color.White;
            this.txtClienteId.Location = new System.Drawing.Point(4, 22);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(210, 18);
            this.txtClienteId.TabIndex = 0;
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.Silver;
            this.pnlCentral.Controls.Add(this.txtBuscarCliente);
            this.pnlCentral.Controls.Add(this.btnClienteBuscar);
            this.pnlCentral.Controls.Add(this.dgvClientes);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(340, 35);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(374, 512);
            this.pnlCentral.TabIndex = 12;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(53, 25);
            this.txtBuscarCliente.MaximumSize = new System.Drawing.Size(350, 29);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(207, 22);
            this.txtBuscarCliente.TabIndex = 20;
            this.txtBuscarCliente.Text = "Buscar cliente";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.TxtBuscarCliente_Enter);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.TxtBuscarCliente_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.btnEliminarCliente);
            this.panel1.Controls.Add(this.btnEditarCliente);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCrearCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 99);
            this.panel1.TabIndex = 17;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Image = global::CapaPresentacion.Properties.Resources.trash_24px;
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(535, 33);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(10, 3, 18, 3);
            this.btnEliminarCliente.MaximumSize = new System.Drawing.Size(148, 35);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarCliente.Size = new System.Drawing.Size(148, 34);
            this.btnEliminarCliente.TabIndex = 10;
            this.btnEliminarCliente.Text = " Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEditarCliente.Image = global::CapaPresentacion.Properties.Resources.edit_24px;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(194, 33);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnEditarCliente.MaximumSize = new System.Drawing.Size(148, 35);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(148, 34);
            this.btnEditarCliente.TabIndex = 9;
            this.btnEditarCliente.Text = " Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 61);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(351, 432);
            this.dgvClientes.TabIndex = 16;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteBuscar.Image = global::CapaPresentacion.Properties.Resources.search_32px;
            this.btnClienteBuscar.Location = new System.Drawing.Point(15, 21);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnClienteBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClienteBuscar.TabIndex = 19;
            this.btnClienteBuscar.TabStop = false;
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteSalir.Image = global::CapaPresentacion.Properties.Resources.multiply_32px;
            this.btnClienteSalir.Location = new System.Drawing.Point(12, 7);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(30, 22);
            this.btnClienteSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClienteSalir.TabIndex = 12;
            this.btnClienteSalir.TabStop = false;
            this.btnClienteSalir.Click += new System.EventHandler(this.BtnClienteSalir_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 646);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(714, 561);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlBarraCliente.ResumeLayout(false);
            this.pnlBarraCliente.PerformLayout();
            this.gpbClienteNombre.ResumeLayout(false);
            this.gpbClienteNombre.PerformLayout();
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.gpbClienteDireccion.ResumeLayout(false);
            this.gpbClienteDireccion.PerformLayout();
            this.gpbClienteEmail.ResumeLayout(false);
            this.gpbClienteEmail.PerformLayout();
            this.gpbClienteCelular.ResumeLayout(false);
            this.gpbClienteCelular.PerformLayout();
            this.gpbClienteId.ResumeLayout(false);
            this.gpbClienteId.PerformLayout();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClienteSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraCliente;
        private System.Windows.Forms.GroupBox gpbClienteNombre;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.GroupBox gpbClienteId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.GroupBox gpbClienteCelular;
        private System.Windows.Forms.TextBox txtClienteCelular;
        private System.Windows.Forms.GroupBox gpbClienteEmail;
        private System.Windows.Forms.TextBox txtClienteEmail;
        private System.Windows.Forms.Label lblBarraCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.PictureBox btnClienteSalir;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        //private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpbClienteDireccion;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.PictureBox btnClienteBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
    }
}