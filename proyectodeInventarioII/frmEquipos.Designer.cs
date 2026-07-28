namespace proyectodeInventarioII
{
    partial class frmEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipos));
            dtgEquipos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            NumeroDeserie = new DataGridViewTextBoxColumn();
            TipoDeEquipo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechaDeCompra = new DataGridViewTextBoxColumn();
            AnioDeGarantia = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoEquipo = new ToolStripButton();
            toolBtnEditarEquipo = new ToolStripButton();
            toolBtnEliminarEquipo = new ToolStripButton();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgEquipos
            // 
            dtgEquipos.AllowUserToAddRows = false;
            dtgEquipos.AllowUserToDeleteRows = false;
            dtgEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEquipos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Marca, Modelo, NumeroDeserie, TipoDeEquipo, Estado, FechaDeCompra, AnioDeGarantia });
            dtgEquipos.Location = new Point(0, 30);
            dtgEquipos.Name = "dtgEquipos";
            dtgEquipos.ReadOnly = true;
            dtgEquipos.RowHeadersWidth = 51;
            dtgEquipos.Size = new Size(1051, 197);
            dtgEquipos.TabIndex = 0;
            dtgEquipos.CellContentClick += dtgEquipos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            Modelo.Width = 125;
            // 
            // NumeroDeserie
            // 
            NumeroDeserie.HeaderText = "Numero de serie";
            NumeroDeserie.MinimumWidth = 6;
            NumeroDeserie.Name = "NumeroDeserie";
            NumeroDeserie.ReadOnly = true;
            NumeroDeserie.Width = 125;
            // 
            // TipoDeEquipo
            // 
            TipoDeEquipo.HeaderText = "Tipo de Equipo";
            TipoDeEquipo.MinimumWidth = 6;
            TipoDeEquipo.Name = "TipoDeEquipo";
            TipoDeEquipo.ReadOnly = true;
            TipoDeEquipo.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // FechaDeCompra
            // 
            FechaDeCompra.HeaderText = "Fecha de Compra";
            FechaDeCompra.MinimumWidth = 6;
            FechaDeCompra.Name = "FechaDeCompra";
            FechaDeCompra.ReadOnly = true;
            FechaDeCompra.Width = 125;
            // 
            // AnioDeGarantia
            // 
            AnioDeGarantia.HeaderText = "Año de Garantia";
            AnioDeGarantia.MinimumWidth = 6;
            AnioDeGarantia.Name = "AnioDeGarantia";
            AnioDeGarantia.ReadOnly = true;
            AnioDeGarantia.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoEquipo, toolBtnEditarEquipo, toolBtnEliminarEquipo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1066, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolBtnNuevoEquipo
            // 
            toolBtnNuevoEquipo.Image = Properties.Resources.plus;
            toolBtnNuevoEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoEquipo.Name = "toolBtnNuevoEquipo";
            toolBtnNuevoEquipo.Size = new Size(80, 24);
            toolBtnNuevoEquipo.Text = "Nuevo ";
            toolBtnNuevoEquipo.Click += toolBtnNuevoEquipo_Click;
            // 
            // toolBtnEditarEquipo
            // 
            toolBtnEditarEquipo.Image = Properties.Resources.boton_editar;
            toolBtnEditarEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnEditarEquipo.Name = "toolBtnEditarEquipo";
            toolBtnEditarEquipo.Size = new Size(72, 24);
            toolBtnEditarEquipo.Text = "Editar";
            toolBtnEditarEquipo.Click += toolBtnEditarEquipo_Click;
            // 
            // toolBtnEliminarEquipo
            // 
            toolBtnEliminarEquipo.Image = (Image)resources.GetObject("toolBtnEliminarEquipo.Image");
            toolBtnEliminarEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarEquipo.Name = "toolBtnEliminarEquipo";
            toolBtnEliminarEquipo.Size = new Size(87, 24);
            toolBtnEliminarEquipo.Text = "Eliminar";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(930, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 304);
            Controls.Add(btnSalir);
            Controls.Add(toolStrip1);
            Controls.Add(dtgEquipos);
            Name = "frmEquipos";
            Text = "Equipos";
            Load += frmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgEquipos;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoEquipo;
        private ToolStripButton toolBtnEditarEquipo;
        private ToolStripButton toolBtnEliminarEquipo;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn NumeroDeserie;
        private DataGridViewTextBoxColumn TipoDeEquipo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaDeCompra;
        private DataGridViewTextBoxColumn AnioDeGarantia;
        private Button btnSalir;
    }
}