namespace proyectodeInventarioII
{
    partial class frmMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientos));
            toolStrip1 = new ToolStrip();
            toolBtnNuevoMantenimiento = new ToolStripButton();
            toolBtnEditarMantenimiento = new ToolStripButton();
            toolBtnEliminarMantenimiento = new ToolStripButton();
            dtgMantenimientos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            TipoDeMantenimiento = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Tecnico = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoMantenimiento, toolBtnEditarMantenimiento, toolBtnEliminarMantenimiento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnNuevoMantenimiento
            // 
            toolBtnNuevoMantenimiento.Image = Properties.Resources.plus;
            toolBtnNuevoMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoMantenimiento.Name = "toolBtnNuevoMantenimiento";
            toolBtnNuevoMantenimiento.Size = new Size(76, 24);
            toolBtnNuevoMantenimiento.Text = "Nuevo";
            toolBtnNuevoMantenimiento.Click += toolBtnNuevoMantenimiento_Click;
            // 
            // toolBtnEditarMantenimiento
            // 
            toolBtnEditarMantenimiento.Image = Properties.Resources.boton_editar;
            toolBtnEditarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarMantenimiento.Name = "toolBtnEditarMantenimiento";
            toolBtnEditarMantenimiento.Size = new Size(72, 24);
            toolBtnEditarMantenimiento.Text = "Editar";
            // 
            // toolBtnEliminarMantenimiento
            // 
            toolBtnEliminarMantenimiento.Image = (Image)resources.GetObject("toolBtnEliminarMantenimiento.Image");
            toolBtnEliminarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarMantenimiento.Name = "toolBtnEliminarMantenimiento";
            toolBtnEliminarMantenimiento.Size = new Size(87, 24);
            toolBtnEliminarMantenimiento.Text = "Eliminar";
            // 
            // dtgMantenimientos
            // 
            dtgMantenimientos.AllowUserToAddRows = false;
            dtgMantenimientos.AllowUserToDeleteRows = false;
            dtgMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMantenimientos.Columns.AddRange(new DataGridViewColumn[] { Equipo, TipoDeMantenimiento, Fecha, Descripcion, Tecnico, Costo });
            dtgMantenimientos.Location = new Point(0, 39);
            dtgMantenimientos.Name = "dtgMantenimientos";
            dtgMantenimientos.ReadOnly = true;
            dtgMantenimientos.RowHeadersWidth = 51;
            dtgMantenimientos.Size = new Size(800, 188);
            dtgMantenimientos.TabIndex = 1;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.MinimumWidth = 6;
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            Equipo.Width = 125;
            // 
            // TipoDeMantenimiento
            // 
            TipoDeMantenimiento.HeaderText = "Tipo de mantenimiento";
            TipoDeMantenimiento.MinimumWidth = 6;
            TipoDeMantenimiento.Name = "TipoDeMantenimiento";
            TipoDeMantenimiento.ReadOnly = true;
            TipoDeMantenimiento.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // Tecnico
            // 
            Tecnico.HeaderText = "Tecnico Responsable";
            Tecnico.MinimumWidth = 6;
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            Tecnico.Width = 125;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 125;
            // 
            // frmMantenimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgMantenimientos);
            Controls.Add(toolStrip1);
            Name = "frmMantenimientos";
            Text = "Mantenimientos";
            Load += frmMantenimientos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoMantenimiento;
        private ToolStripButton toolBtnEditarMantenimiento;
        private ToolStripButton toolBtnEliminarMantenimiento;
        private DataGridView dtgMantenimientos;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn TipoDeMantenimiento;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Tecnico;
        private DataGridViewTextBoxColumn Costo;
    }
}