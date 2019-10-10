using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmUserSign : Form
    {
        public FrmUserSign()
        {
            InitializeComponent();
        }

        private void ValidacionUsuario()
        {
            if (txtUsuario.Text != string.Empty)
            {
                if (txtContrasena.Text != string.Empty)
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var loginValido = usuario.LoginUser(txtUsuario.Text, txtContrasena.Text);
                    if (loginValido == true)
                    {
                        InterfazPrincipal mainInterfaz = new InterfazPrincipal();
                        mainInterfaz.Show();
                        mainInterfaz.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Nombre de usuario o contraseña incorrectos. \n      Por favor, inténtelo de nuevo.");
                        txtContrasena.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MsgError("Por favor, ingresar contraseña.");
                }
            }
            else
            {
                MsgError("Por favor, ingresar nombre de usuario.");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnValidarUsuario_Click(object sender, EventArgs e)
        {
            ValidacionUsuario();
        }

        private void MsgError(string msg)
        {
            lblErrorMessage.Text = "      " + msg;
            lblErrorMessage.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs formClosed)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                ValidacionUsuario();
            }
        }
    }
}
