using System;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmMantenimientoModal : Form
    {
        public MantenimientoTemp? NuevoMantenimiento { get; private set; }

        public frmMantenimientoModal()
        {
            InitializeComponent();
            this.btnGuardar.Click += btnGuardar_Click;
        }

        private void frmMantenimientoModal_Load(object sender, EventArgs e)
        {
            if (cmbEquipo.Items.Count > 0)
            {
                cmbEquipo.SelectedIndex = -1;
            }

            radPreventivo.Checked = true;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox)?.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (cmbEquipo.SelectedIndex == -1 || cmbEquipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEquipo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || txtDescripcion.Text.Trim().Length < 10)
            {
                MessageBox.Show("La descripción debe contener al menos 10 caracteres explicativos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            if (radCorrectivo.Checked && (string.IsNullOrWhiteSpace(txtResponsable.Text) || txtResponsable.Text.Trim().Length < 3))
            {
                MessageBox.Show("El mantenimiento Correctivo requiere un técnico responsable válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsable.Focus();
                return;
            }

            if (dtpFecha.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha del mantenimiento no puede ser una fecha futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Focus();
                return;
            }

            if (!decimal.TryParse(txtCosto.Text.Trim(), out decimal costo) || costo <= 0 || costo > 10000)
            {
                MessageBox.Show("Ingrese un costo válido entre $0.01 y $10,000.00.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return;
            }

            NuevoMantenimiento = new MantenimientoTemp
            {
                Equipo = cmbEquipo.SelectedItem.ToString(),
                Tipo = radPreventivo.Checked ? TipoMantenimiento.Preventivo : TipoMantenimiento.Correctivo,
                Fecha = dtpFecha.Value,
                Descripcion = txtDescripcion.Text.Trim(),
                Tecnico = txtResponsable.Text.Trim(),
                Costo = costo
            };

            MessageBox.Show("Mantenimiento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    public enum TipoMantenimiento
    {
        Preventivo = 1,
        Correctivo = 2
    }

    public class MantenimientoTemp
    {
        public string? Equipo { get; set; }
        public TipoMantenimiento Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public string? Tecnico { get; set; }
        public decimal Costo { get; set; }
    }
}