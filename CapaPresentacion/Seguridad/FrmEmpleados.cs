﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Seguridad
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            txtEmpleadoNombre.Focus();
        }

        private void BtnClienteSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscarEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text.ToLower() == "buscar empleado")
                txtBuscarEmpleado.Text = string.Empty;
        }

        private void TxtBuscarEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text == string.Empty)
                txtBuscarEmpleado.Text = "Buscar empleado";
        }
    }
}
