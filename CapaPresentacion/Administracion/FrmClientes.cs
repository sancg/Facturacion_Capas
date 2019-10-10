using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administracion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            txtClienteNombre.Focus();
        }

        private void BtnClienteSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text.ToLower() == "buscar cliente")
                txtBuscarCliente.Text = string.Empty;
        }

        private void TxtBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text == string.Empty)
                txtBuscarCliente.Text = "Buscar cliente";
        }
    }
}
