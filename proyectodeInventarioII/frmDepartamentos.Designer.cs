namespace proyectodeInventarioII
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            toolStrip1 = new ToolStrip();
            toolBtnNuevoDepartamento = new ToolStripButton();
            toolBtnEditarDepartamento = new ToolStripButton();
            toolBtnEliminarDepartamento = new ToolStripButton();
            dtgDepartamentos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoDepartamento, toolBtnEditarDepartamento, toolBtnEliminarDepartamento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnNuevoDepartamento
            // 
            toolBtnNuevoDepartamento.Image = (Image)resources.GetObject("toolBtnNuevoDepartamento.Image");
            toolBtnNuevoDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoDepartamento.Name = "toolBtnNuevoDepartamento";
            toolBtnNuevoDepartamento.Size = new Size(76, 24);
            toolBtnNuevoDepartamento.Tag = "";
            toolBtnNuevoDepartamento.Text = "Nuevo";
            toolBtnNuevoDepartamento.Click += toolBtnNuevoDepartamento_Click;
            // 
            // toolBtnEditarDepartamento
            // 
            toolBtnEditarDepartamento.Image = (Image)resources.GetObject("toolBtnEditarDepartamento.Image");
            toolBtnEditarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarDepartamento.Name = "toolBtnEditarDepartamento";
            toolBtnEditarDepartamento.Size = new Size(72, 24);
            toolBtnEditarDepartamento.Text = "Editar";
            // 
            // toolBtnEliminarDepartamento
            // 
            toolBtnEliminarDepartamento.Image = (Image)resources.GetObject("toolBtnEliminarDepartamento.Image");
            toolBtnEliminarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarDepartamento.Name = "toolBtnEliminarDepartamento";
            toolBtnEliminarDepartamento.Size = new Size(87, 24);
            toolBtnEliminarDepartamento.Text = "Eliminar";
            // 
            // dtgDepartamentos
            // 
            dtgDepartamentos.AllowUserToAddRows = false;
            dtgDepartamentos.AllowUserToDeleteRows = false;
            dtgDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDepartamentos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre });
            dtgDepartamentos.Dock = DockStyle.Fill;
            dtgDepartamentos.Location = new Point(0, 27);
            dtgDepartamentos.Name = "dtgDepartamentos";
            dtgDepartamentos.ReadOnly = true;
            dtgDepartamentos.RowHeadersWidth = 51;
            dtgDepartamentos.Size = new Size(800, 423);
            dtgDepartamentos.TabIndex = 1;
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
            Nombre.HeaderText = "Departamento";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // frmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgDepartamentos);
            Controls.Add(toolStrip1);
            Location = new Point(0, 39);
            Name = "frmDepartamentos";
            Text = "Departamentos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoDepartamento;
        private ToolStripButton toolBtnEditarDepartamento;
        private ToolStripButton toolBtnEliminarDepartamento;
        private DataGridView dtgDepartamentos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
    }
}