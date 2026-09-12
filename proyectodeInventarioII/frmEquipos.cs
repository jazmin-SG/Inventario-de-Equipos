using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEquipos : Form
    {
        public static Dictionary<string, (string Marca, string Modelo, string Serie, string TipoEquipo, string Estado, DateTime fechaCompra, int añoGarantia)> equipos = [];
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void dtgEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolBtnNuevoEquipo_Click(object sender, EventArgs e)
        {
            frmEquipoModal frmEq = new frmEquipoModal();
            if (frmEq.ShowDialog() == DialogResult.OK)
            {
                refrescarGrid();
            }

        }
        private void refrescarGrid()
        {
            dtgEquipos.DataSource = null;
            dtgEquipos.DataSource = equipos.Select(equipo => new
            {
                Codigo = equipo.Key,
                Marca = equipo.Value.Marca,
                Modelo = equipo.Value.Modelo,
                NumeroDeSerie = equipo.Value.Serie,
                TipoDeEquipo = equipo.Value.TipoEquipo,
                Estado = equipo.Value.Estado,
                FechaDeCompra = equipo.Value.fechaCompra.ToShortDateString(),
                AñodeGarantia = equipo.Value.añoGarantia
            }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarEquipo_Click(object sender, EventArgs e)
        {
            frmEditarEquipos frmEditEq = new frmEditarEquipos();
            frmEditEq.ShowDialog();
            refrescarGrid();
        }

        private void toolBtnEliminarEquipo_Click(object sender, EventArgs e)
        {

            if (dtgEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            string codigo = dtgEquipos.CurrentRow.Cells["Codigo"].Value.ToString();

            equipos.Remove(codigo);
            refrescarGrid();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotalEquipos.Text = equipos.Count.ToString();
        }
    }
}
