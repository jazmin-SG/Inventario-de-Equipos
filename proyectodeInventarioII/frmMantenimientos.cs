using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmMantenimientos : Form
    {
        private List<MantenimientoTemp> listaMantenimientos = new List<MantenimientoTemp>();

        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void toolBtnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            using (frmMantenimientoModal frmMod = new frmMantenimientoModal())
            {
                if (frmMod.ShowDialog() == DialogResult.OK && frmMod.NuevoMantenimiento != null)
                {
                    listaMantenimientos.Add(frmMod.NuevoMantenimiento);

                    dtgMantenimientos.DataSource = null;
                    dtgMantenimientos.DataSource = listaMantenimientos;

                    CalcularResumenLINQ();
                }
            }
        }

        private void CalcularResumenLINQ()
        {
            if (listaMantenimientos == null || !listaMantenimientos.Any())
            {
                lblSuma.Text = "Total: $0.00";
                lblPromedio.Text = "Promedio: $0.00";
                lblFechaReciente.Text = "Último: --/--/----";
                lblTotalEquipo.Text = "Cant. por equipo: 0";
                return;
            }

            decimal suma = listaMantenimientos.Sum(m => m.Costo);
            decimal promedio = listaMantenimientos.Average(m => m.Costo);
            DateTime masReciente = listaMantenimientos.Max(m => m.Fecha);

            // Agrupa por equipo y cuenta cuántos hay de cada uno
            var conteoPorEquipo = listaMantenimientos
                .GroupBy(m => m.Equipo)
                .Select(g => $"{g.Key}: {g.Count()}");

            string desgloseEquipos = string.Join(" | ", conteoPorEquipo);

            lblSuma.Text = $"Total: {suma:C2}";
            lblPromedio.Text = $"Promedio: {promedio:C2}";
            lblFechaReciente.Text = $"Último: {masReciente:dd/MM/yyyy}";
            lblTotalEquipo.Text = $"Equipos: {desgloseEquipos}";
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            frmEditarMantenimiento frmMant = new frmEditarMantenimiento();
            frmMant.ShowDialog();
        }

        private void toolBtnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
          
        
            if (dtgMantenimientos.CurrentRow == null || dtgMantenimientos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el mantenimiento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                int indiceSeleccionado = dtgMantenimientos.CurrentRow.Index;

                if (indiceSeleccionado >= 0 && indiceSeleccionado < listaMantenimientos.Count)
                {
                    listaMantenimientos.RemoveAt(indiceSeleccionado);

                    dtgMantenimientos.DataSource = null;
                    dtgMantenimientos.DataSource = listaMantenimientos;

                    CalcularResumenLINQ();
                }
            }
        }
    }
    
}