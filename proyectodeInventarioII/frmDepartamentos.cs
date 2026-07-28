using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void toolBtnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            frmDepartamentoModal frmDep = new frmDepartamentoModal();
            frmDep.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
