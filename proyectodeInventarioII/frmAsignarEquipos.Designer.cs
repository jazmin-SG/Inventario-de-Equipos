namespace proyectodeInventarioII
{
    partial class frmAsignarEquipos
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
            cmbEquipoAsignar = new ComboBox();
            label2 = new Label();
            cmbEmpleadoAsignar = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtObservaciones = new TextBox();
            btnAsignar = new Button();
            btnCambiar = new Button();
            btnDevolverEquipo = new Button();
            dtgHistorialDeAsignaciones = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            FechaDeAsignacion = new DataGridViewTextBoxColumn();
            FechaDeDevolucion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgHistorialDeAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Equipo";
            // 
            // cmbEquipoAsignar
            // 
            cmbEquipoAsignar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoAsignar.FormattingEnabled = true;
            cmbEquipoAsignar.Location = new Point(96, 9);
            cmbEquipoAsignar.Name = "cmbEquipoAsignar";
            cmbEquipoAsignar.Size = new Size(151, 28);
            cmbEquipoAsignar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleado";
            // 
            // cmbEmpleadoAsignar
            // 
            cmbEmpleadoAsignar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleadoAsignar.FormattingEnabled = true;
            cmbEmpleadoAsignar.Location = new Point(96, 47);
            cmbEmpleadoAsignar.Name = "cmbEmpleadoAsignar";
            cmbEmpleadoAsignar.Size = new Size(151, 28);
            cmbEmpleadoAsignar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha de asignacion";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(161, 93);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(123, 129);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(125, 34);
            txtObservaciones.TabIndex = 7;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(12, 222);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(94, 29);
            btnAsignar.TabIndex = 8;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(123, 222);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(94, 29);
            btnCambiar.TabIndex = 9;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            // 
            // btnDevolverEquipo
            // 
            btnDevolverEquipo.Location = new Point(248, 222);
            btnDevolverEquipo.Name = "btnDevolverEquipo";
            btnDevolverEquipo.Size = new Size(134, 29);
            btnDevolverEquipo.TabIndex = 10;
            btnDevolverEquipo.Text = "Devolver Equipo";
            btnDevolverEquipo.UseVisualStyleBackColor = true;
            // 
            // dtgHistorialDeAsignaciones
            // 
            dtgHistorialDeAsignaciones.AllowUserToAddRows = false;
            dtgHistorialDeAsignaciones.AllowUserToDeleteRows = false;
            dtgHistorialDeAsignaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgHistorialDeAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistorialDeAsignaciones.Columns.AddRange(new DataGridViewColumn[] { Equipo, Empleado, FechaDeAsignacion, FechaDeDevolucion, Estado, Observaciones });
            dtgHistorialDeAsignaciones.Location = new Point(0, 257);
            dtgHistorialDeAsignaciones.Name = "dtgHistorialDeAsignaciones";
            dtgHistorialDeAsignaciones.ReadOnly = true;
            dtgHistorialDeAsignaciones.RowHeadersWidth = 51;
            dtgHistorialDeAsignaciones.Size = new Size(795, 188);
            dtgHistorialDeAsignaciones.TabIndex = 11;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.MinimumWidth = 6;
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            Equipo.Width = 125;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 6;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            Empleado.Width = 125;
            // 
            // FechaDeAsignacion
            // 
            FechaDeAsignacion.HeaderText = "Fecha de Asignacion";
            FechaDeAsignacion.MinimumWidth = 6;
            FechaDeAsignacion.Name = "FechaDeAsignacion";
            FechaDeAsignacion.ReadOnly = true;
            FechaDeAsignacion.Width = 125;
            // 
            // FechaDeDevolucion
            // 
            FechaDeDevolucion.HeaderText = "Fecha de Devolucion";
            FechaDeDevolucion.MinimumWidth = 6;
            FechaDeDevolucion.Name = "FechaDeDevolucion";
            FechaDeDevolucion.ReadOnly = true;
            FechaDeDevolucion.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 6;
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Width = 125;
            // 
            // frmAsignarEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgHistorialDeAsignaciones);
            Controls.Add(btnDevolverEquipo);
            Controls.Add(btnCambiar);
            Controls.Add(btnAsignar);
            Controls.Add(txtObservaciones);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cmbEmpleadoAsignar);
            Controls.Add(label2);
            Controls.Add(cmbEquipoAsignar);
            Controls.Add(label1);
            Name = "frmAsignarEquipos";
            Text = "Asignación de Equipos";
            ((System.ComponentModel.ISupportInitialize)dtgHistorialDeAsignaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEquipoAsignar;
        private Label label2;
        private ComboBox cmbEmpleadoAsignar;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private TextBox txtObservaciones;
        private Button btnAsignar;
        private Button btnCambiar;
        private Button btnDevolverEquipo;
        private DataGridView dtgHistorialDeAsignaciones;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn FechaDeAsignacion;
        private DataGridViewTextBoxColumn FechaDeDevolucion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Observaciones;
    }
}