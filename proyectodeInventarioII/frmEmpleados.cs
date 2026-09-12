using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void toolBtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleadoModal frmEmp = new frmEmpleadoModal();
            frmEmp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarEmpleados_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado frmEdit = new frmEditarEmpleado();
            frmEdit.ShowDialog();
        }
    }
}
