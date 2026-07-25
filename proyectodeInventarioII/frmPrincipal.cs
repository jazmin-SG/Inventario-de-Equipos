using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form formulario in MdiChildren)
            {
                if (formulario is T)
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.Activate();
                    return;
                }
            }
            T formularioHijo = new T();
            formularioHijo.MdiParent = this;
            formularioHijo.Show();
        }
        private void cacadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEquipos>();
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleados>();
        }

        private void mnuDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDepartamentos>();
        }

        private void mnuMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMantenimientos>();
        }

        private void toolBtnEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEquipos>();
        }

        private void toolBtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleados>();
        }

        private void toolBtnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDepartamentos>();
        }

        private void toolBtnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMantenimientos>();
        }

        private void mnuAsignarEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAsignarEquipos>();
        }

        private void MnuConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConsultas>();
        }
    }
}
