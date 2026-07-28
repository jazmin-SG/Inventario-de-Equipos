namespace proyectodeInventarioII
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            toolStrip1 = new ToolStrip();
            toolBtnNuevoEmpleado = new ToolStripButton();
            toolBtnEditarEmpleados = new ToolStripButton();
            toolBtnEliminarEmpleado = new ToolStripButton();
            toolBtnBuscarEmpleado = new ToolStripButton();
            dtgEmpleados = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoEmpleado, toolBtnEditarEmpleados, toolBtnEliminarEmpleado, toolBtnBuscarEmpleado });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(742, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnNuevoEmpleado
            // 
            toolBtnNuevoEmpleado.Image = (Image)resources.GetObject("toolBtnNuevoEmpleado.Image");
            toolBtnNuevoEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoEmpleado.Name = "toolBtnNuevoEmpleado";
            toolBtnNuevoEmpleado.Size = new Size(76, 24);
            toolBtnNuevoEmpleado.Text = "Nuevo";
            toolBtnNuevoEmpleado.Click += toolBtnNuevoEmpleado_Click;
            // 
            // toolBtnEditarEmpleados
            // 
            toolBtnEditarEmpleados.Image = (Image)resources.GetObject("toolBtnEditarEmpleados.Image");
            toolBtnEditarEmpleados.ImageTransparentColor = Color.Magenta;
            toolBtnEditarEmpleados.Name = "toolBtnEditarEmpleados";
            toolBtnEditarEmpleados.Size = new Size(72, 24);
            toolBtnEditarEmpleados.Text = "Editar";
            toolBtnEditarEmpleados.Click += toolBtnEditarEmpleados_Click;
            // 
            // toolBtnEliminarEmpleado
            // 
            toolBtnEliminarEmpleado.Image = (Image)resources.GetObject("toolBtnEliminarEmpleado.Image");
            toolBtnEliminarEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarEmpleado.Name = "toolBtnEliminarEmpleado";
            toolBtnEliminarEmpleado.Size = new Size(87, 24);
            toolBtnEliminarEmpleado.Text = "Eliminar";
            // 
            // toolBtnBuscarEmpleado
            // 
            toolBtnBuscarEmpleado.Image = (Image)resources.GetObject("toolBtnBuscarEmpleado.Image");
            toolBtnBuscarEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnBuscarEmpleado.Name = "toolBtnBuscarEmpleado";
            toolBtnBuscarEmpleado.Size = new Size(76, 24);
            toolBtnBuscarEmpleado.Text = "Buscar";
            // 
            // dtgEmpleados
            // 
            dtgEmpleados.AllowUserToAddRows = false;
            dtgEmpleados.AllowUserToDeleteRows = false;
            dtgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleados.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Apellido, Cargo, Departamento });
            dtgEmpleados.Location = new Point(0, 39);
            dtgEmpleados.Name = "dtgEmpleados";
            dtgEmpleados.ReadOnly = true;
            dtgEmpleados.RowHeadersWidth = 51;
            dtgEmpleados.Size = new Size(706, 160);
            dtgEmpleados.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Cargo.Width = 125;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            Departamento.Width = 125;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(612, 222);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 263);
            Controls.Add(btnSalir);
            Controls.Add(dtgEmpleados);
            Controls.Add(toolStrip1);
            Name = "frmEmpleados";
            Text = "Empleados";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoEmpleado;
        private ToolStripButton toolBtnEditarEmpleados;
        private ToolStripButton toolBtnEliminarEmpleado;
        private ToolStripButton toolBtnBuscarEmpleado;
        private DataGridView dtgEmpleados;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Departamento;
        private Button btnSalir;
    }
}