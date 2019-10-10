using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Administracion;
using CapaPresentacion.Facturacion;
using CapaPresentacion.Seguridad;
using CapaPresentacion.Ayuda;
using Common.Cache;

namespace CapaPresentacion
{
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
            CustomDesignMenu();
        }
        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            this.Opacity = 0.0;
            tmrFadeIn.Start();
        }

        private void LoadUserData() {
            lblNombreUsuario.Text = UserLoginCache.NombreEmpleado;
            lblCargoEmpleado.Text = UserLoginCache.Cargo;
        }

        //Oculta todos los paneles del menú desplegable
        private void CustomDesignMenu()
        {
            pnlSubMenuAdmon.Visible = false;
            pnlSubMenuFacturacion.Visible = false;
            pnlSubMenuSeguridad.Visible = false;
            pnlSubMenuAyuda.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlSubMenuAdmon.Visible == true)
            {
                pnlSubMenuAdmon.Visible = false;
            }
            if (pnlSubMenuFacturacion.Visible == true)
            {
                pnlSubMenuFacturacion.Visible = false;
            }
            if (pnlSubMenuSeguridad.Visible == true)
            {
                pnlSubMenuSeguridad.Visible = false;
            }
            if (pnlSubMenuAyuda.Visible == true)
            {
                pnlSubMenuAyuda.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Verificador de señaladores de posiciones
        public void RestoreColorButton(Button button)
        {
            if (button.BackColor == Color.FromArgb(231, 76, 60))
            {
                button.BackColor = Color.FromArgb(87, 75, 144);
            }
        }

        // DESPLIEGUE DE MENÚ
        // MENÚ ADMINISTRACIÓN...
        private void BtnAdmon_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuAdmon);
        }
        #region SubMenu Administraición
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClientes());
            this.btnClientes.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProductos());
            this.btnProductos.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCategorias());
            this.btnCategorias.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        #endregion

        // MENÚ FACTURACIÓN...
        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuFacturacion);
        }
        #region SubMenu Facturación
        private void BtnInformes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInformes());
            this.btnInformes.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFacturas());
            this.btnFacturas.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }
        #endregion

        // MENÚ SEGURIDAD...
        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuSeguridad);
        }
        #region SubMenu Seguridad
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEmpleados());
            this.btnEmpleados.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRoles());
            this.btnRoles.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }

        private void BtnSeguridadSubMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSeguridad());
            this.btnSeguridadSubMenu.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnAcerca);
        }
        #endregion

        // MENÚ AYUDA
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuAyuda);
        }
        #region SubMenu Ayuda
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInformacion());
            this.btnInfo.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnEmpleados);
            RestoreColorButton(btnAcerca);
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAcerca());
            this.btnAcerca.BackColor = Color.FromArgb(231, 76, 60);
            RestoreColorButton(btnClientes);
            RestoreColorButton(btnProductos);
            RestoreColorButton(btnInformes);
            RestoreColorButton(btnCategorias);
            RestoreColorButton(btnFacturas);
            RestoreColorButton(btnRoles);
            RestoreColorButton(btnSeguridadSubMenu);
            RestoreColorButton(btnInfo);
            RestoreColorButton(btnEmpleados);
        }
        #endregion

        //Verificación de formularios
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Controls.Add(childForm);
            pnlContenedorPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private int cont = 1;
        private void TmrFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            if (cont == 100)
            {
                tmrFadeIn.Stop();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que deseas cerrar sessión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

    }
}
