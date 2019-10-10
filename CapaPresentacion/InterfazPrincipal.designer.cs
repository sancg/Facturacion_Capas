namespace CapaPresentacion
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlSubMenuAyuda = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pnlSubMenuSeguridad = new System.Windows.Forms.Panel();
            this.btnSeguridadSubMenu = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.pnlSubMenuFacturacion = new System.Windows.Forms.Panel();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.pnlSubMenuAdmon = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAdmon = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblCargoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlContenedorPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuAyuda.SuspendLayout();
            this.pnlSubMenuSeguridad.SuspendLayout();
            this.pnlSubMenuFacturacion.SuspendLayout();
            this.pnlSubMenuAdmon.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.pnlMenuLateral.Controls.Add(this.btnSalir);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAyuda);
            this.pnlMenuLateral.Controls.Add(this.btnAyuda);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuSeguridad);
            this.pnlMenuLateral.Controls.Add(this.btnSeguridad);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuFacturacion);
            this.pnlMenuLateral.Controls.Add(this.btnFacturacion);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAdmon);
            this.pnlMenuLateral.Controls.Add(this.btnAdmon);
            this.pnlMenuLateral.Controls.Add(this.pnlUsuario);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 646);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.exit_32px;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 675);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(233, 45);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pnlSubMenuAyuda
            // 
            this.pnlSubMenuAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.pnlSubMenuAyuda.Controls.Add(this.button1);
            this.pnlSubMenuAyuda.Controls.Add(this.btnAcerca);
            this.pnlSubMenuAyuda.Controls.Add(this.btnInfo);
            this.pnlSubMenuAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAyuda.Location = new System.Drawing.Point(0, 597);
            this.pnlSubMenuAyuda.Name = "pnlSubMenuAyuda";
            this.pnlSubMenuAyuda.Size = new System.Drawing.Size(233, 78);
            this.pnlSubMenuAyuda.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Ayuda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAcerca
            // 
            this.btnAcerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAcerca.Image = global::CapaPresentacion.Properties.Resources.good_quality_16px;
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(0, 40);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAcerca.Size = new System.Drawing.Size(233, 40);
            this.btnAcerca.TabIndex = 13;
            this.btnAcerca.Text = "  Acerca de";
            this.btnAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.BtnAcerca_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnInfo.Image = global::CapaPresentacion.Properties.Resources.information_16px;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(233, 40);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "  Información";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAyuda.Image = global::CapaPresentacion.Properties.Resources.trust_32px;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 552);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(233, 45);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "   Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // pnlSubMenuSeguridad
            // 
            this.pnlSubMenuSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.pnlSubMenuSeguridad.Controls.Add(this.btnSeguridadSubMenu);
            this.pnlSubMenuSeguridad.Controls.Add(this.btnRoles);
            this.pnlSubMenuSeguridad.Controls.Add(this.btnEmpleados);
            this.pnlSubMenuSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSeguridad.Location = new System.Drawing.Point(0, 434);
            this.pnlSubMenuSeguridad.Name = "pnlSubMenuSeguridad";
            this.pnlSubMenuSeguridad.Size = new System.Drawing.Size(233, 118);
            this.pnlSubMenuSeguridad.TabIndex = 5;
            // 
            // btnSeguridadSubMenu
            // 
            this.btnSeguridadSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridadSubMenu.FlatAppearance.BorderSize = 0;
            this.btnSeguridadSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridadSubMenu.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSeguridadSubMenu.Image = global::CapaPresentacion.Properties.Resources.businessman_16px;
            this.btnSeguridadSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridadSubMenu.Location = new System.Drawing.Point(0, 80);
            this.btnSeguridadSubMenu.Name = "btnSeguridadSubMenu";
            this.btnSeguridadSubMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSeguridadSubMenu.Size = new System.Drawing.Size(233, 40);
            this.btnSeguridadSubMenu.TabIndex = 10;
            this.btnSeguridadSubMenu.Text = "  Seguridad";
            this.btnSeguridadSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridadSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridadSubMenu.UseVisualStyleBackColor = true;
            this.btnSeguridadSubMenu.Click += new System.EventHandler(this.BtnSeguridadSubMenu_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnRoles.Image = global::CapaPresentacion.Properties.Resources.mind_map_16px;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 40);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(233, 40);
            this.btnRoles.TabIndex = 9;
            this.btnRoles.Text = "  Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnEmpleados.Image = global::CapaPresentacion.Properties.Resources.employee_card_16px;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(233, 40);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.Text = "  Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSeguridad.Image = global::CapaPresentacion.Properties.Resources.settings_32px;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 389);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(233, 45);
            this.btnSeguridad.TabIndex = 7;
            this.btnSeguridad.Text = "   Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.BtnSeguridad_Click);
            // 
            // pnlSubMenuFacturacion
            // 
            this.pnlSubMenuFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.pnlSubMenuFacturacion.Controls.Add(this.btnFacturas);
            this.pnlSubMenuFacturacion.Controls.Add(this.btnInformes);
            this.pnlSubMenuFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuFacturacion.Location = new System.Drawing.Point(0, 307);
            this.pnlSubMenuFacturacion.Name = "pnlSubMenuFacturacion";
            this.pnlSubMenuFacturacion.Size = new System.Drawing.Size(233, 82);
            this.pnlSubMenuFacturacion.TabIndex = 3;
            // 
            // btnFacturas
            // 
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnFacturas.Image = global::CapaPresentacion.Properties.Resources.receive_cash_16px;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 40);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(233, 40);
            this.btnFacturas.TabIndex = 6;
            this.btnFacturas.Text = "  Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnInformes.Image = global::CapaPresentacion.Properties.Resources.resume_16px;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 0);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInformes.Size = new System.Drawing.Size(233, 40);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "  Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnFacturacion.Image = global::CapaPresentacion.Properties.Resources.document_32px;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 262);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(233, 45);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "   Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // pnlSubMenuAdmon
            // 
            this.pnlSubMenuAdmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.pnlSubMenuAdmon.Controls.Add(this.btnCategorias);
            this.pnlSubMenuAdmon.Controls.Add(this.btnProductos);
            this.pnlSubMenuAdmon.Controls.Add(this.btnClientes);
            this.pnlSubMenuAdmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAdmon.Location = new System.Drawing.Point(0, 141);
            this.pnlSubMenuAdmon.Name = "pnlSubMenuAdmon";
            this.pnlSubMenuAdmon.Size = new System.Drawing.Size(233, 121);
            this.pnlSubMenuAdmon.TabIndex = 1;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCategorias.Image = global::CapaPresentacion.Properties.Resources.sorting_answers_16px;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 80);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(233, 40);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "  Categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnProductos.Image = global::CapaPresentacion.Properties.Resources.product_16px;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 40);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(233, 40);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "  Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnClientes.Image = global::CapaPresentacion.Properties.Resources.handshake_16px;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnAdmon
            // 
            this.btnAdmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmon.FlatAppearance.BorderSize = 0;
            this.btnAdmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmon.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAdmon.Image = global::CapaPresentacion.Properties.Resources.binders_folder_32px;
            this.btnAdmon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmon.Location = new System.Drawing.Point(0, 96);
            this.btnAdmon.Name = "btnAdmon";
            this.btnAdmon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmon.Size = new System.Drawing.Size(233, 45);
            this.btnAdmon.TabIndex = 1;
            this.btnAdmon.Text = "   Administración";
            this.btnAdmon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmon.UseVisualStyleBackColor = true;
            this.btnAdmon.Click += new System.EventHandler(this.BtnAdmon_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pnlUsuario.Controls.Add(this.lblCargoEmpleado);
            this.pnlUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(233, 96);
            this.pnlUsuario.TabIndex = 0;
            // 
            // lblCargoEmpleado
            // 
            this.lblCargoEmpleado.AutoSize = true;
            this.lblCargoEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargoEmpleado.Location = new System.Drawing.Point(91, 31);
            this.lblCargoEmpleado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblCargoEmpleado.Name = "lblCargoEmpleado";
            this.lblCargoEmpleado.Size = new System.Drawing.Size(46, 19);
            this.lblCargoEmpleado.TabIndex = 5;
            this.lblCargoEmpleado.Text = "Cargo";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreUsuario.Location = new System.Drawing.Point(91, 9);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(137, 19);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre empleado";
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.BackColor = System.Drawing.Color.Silver;
            this.pnlContenedorPrincipal.Controls.Add(this.label1);
            this.pnlContenedorPrincipal.Controls.Add(this.pictureBox1);
            this.pnlContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(250, 0);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(714, 646);
            this.pnlContenedorPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(491, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realizado por: Santiago Cano González";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.hp_filled_500px;
            this.pictureBox1.Location = new System.Drawing.Point(256, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Interval = 30;
            this.tmrFadeIn.Tick += new System.EventHandler(this.TmrFadeIn_Tick);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 646);
            this.Controls.Add(this.pnlContenedorPrincipal);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 640);
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de facturación";
            this.Load += new System.EventHandler(this.InterfazPrincipal_Load);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuAyuda.ResumeLayout(false);
            this.pnlSubMenuSeguridad.ResumeLayout(false);
            this.pnlSubMenuFacturacion.ResumeLayout(false);
            this.pnlSubMenuAdmon.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlContenedorPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnAdmon;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlSubMenuAdmon;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlSubMenuSeguridad;
        private System.Windows.Forms.Button btnSeguridadSubMenu;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Panel pnlSubMenuFacturacion;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel pnlSubMenuAyuda;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCargoEmpleado;
    }
}