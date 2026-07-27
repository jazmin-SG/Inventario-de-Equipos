namespace proyectodeInventarioII
{
    partial class frmEquipoModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtNumeroSerie = new TextBox();
            label5 = new Label();
            cmbTipoEquipo = new ComboBox();
            label6 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            dtpFechaCompra = new DateTimePicker();
            label8 = new Label();
            nudAnioGarantia = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAnioGarantia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(159, 11);
            txtCodigo.Margin = new Padding(4, 4, 4, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(155, 31);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 3;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 4;
            label4.Text = "Numero de serie";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(159, 52);
            txtMarca.Margin = new Padding(4, 4, 4, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(155, 31);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(159, 95);
            txtModelo.Margin = new Padding(4, 4, 4, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(155, 31);
            txtModelo.TabIndex = 6;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(161, 138);
            txtNumeroSerie.Margin = new Padding(4, 4, 4, 4);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(155, 31);
            txtNumeroSerie.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 8;
            label5.Text = "Tipo de equipo";
            // 
            // cmbTipoEquipo
            // 
            cmbTipoEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEquipo.FormattingEnabled = true;
            cmbTipoEquipo.Items.AddRange(new object[] { "Computadora de escritorio", "Laptop", "Monitor", "Servidor", "Otro" });
            cmbTipoEquipo.Location = new Point(159, 179);
            cmbTipoEquipo.Margin = new Padding(4, 4, 4, 4);
            cmbTipoEquipo.Name = "cmbTipoEquipo";
            cmbTipoEquipo.Size = new Size(188, 33);
            cmbTipoEquipo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 221);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "En uso", "En reparación", "Dado de baja" });
            cmbEstado.Location = new Point(159, 221);
            cmbEstado.Margin = new Padding(4, 4, 4, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(188, 33);
            cmbEstado.TabIndex = 11;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-5, 264);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 12;
            label7.Text = "Fecha de compra";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(159, 264);
            dtpFechaCompra.Margin = new Padding(4, 4, 4, 4);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(312, 31);
            dtpFechaCompra.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 305);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 14;
            label8.Text = "Año de Garantia";
            // 
            // nudAnioGarantia
            // 
            nudAnioGarantia.Location = new Point(161, 305);
            nudAnioGarantia.Margin = new Padding(4, 4, 4, 4);
            nudAnioGarantia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAnioGarantia.Name = "nudAnioGarantia";
            nudAnioGarantia.Size = new Size(188, 31);
            nudAnioGarantia.TabIndex = 15;
            nudAnioGarantia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(31, 359);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 36);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(292, 359);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 36);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmEquipoModal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 415);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudAnioGarantia);
            Controls.Add(label8);
            Controls.Add(dtpFechaCompra);
            Controls.Add(label7);
            Controls.Add(cmbEstado);
            Controls.Add(label6);
            Controls.Add(cmbTipoEquipo);
            Controls.Add(label5);
            Controls.Add(txtNumeroSerie);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEquipoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Equipo";
            Load += frmEquipoModal_Load;
            ((System.ComponentModel.ISupportInitialize)nudAnioGarantia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtNumeroSerie;
        private Label label5;
        private ComboBox cmbTipoEquipo;
        private Label label6;
        private ComboBox cmbEstado;
        private Label label7;
        private DateTimePicker dtpFechaCompra;
        private Label label8;
        private NumericUpDown nudAnioGarantia;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}