using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void dtgEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolBtnNuevoEquipo_Click(object sender, EventArgs e)
        {
            using (var modal = new frmEquipoModal())
            {
                modal.ShowDialog(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
