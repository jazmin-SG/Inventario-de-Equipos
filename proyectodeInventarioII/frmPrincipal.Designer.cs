namespace proyectodeInventarioII
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            mnuFormularios = new ToolStripMenuItem();
            mnuEquipo = new ToolStripMenuItem();
            mnuEmpleado = new ToolStripMenuItem();
            mnuDepartamento = new ToolStripMenuItem();
            mnuMantenimiento = new ToolStripMenuItem();
            mnuOrganizar = new ToolStripMenuItem();
            mnuCascada = new ToolStripMenuItem();
            mnuVertical = new ToolStripMenuItem();
            mnuHorizontal = new ToolStripMenuItem();
            mnuCerrarTodo = new ToolStripMenuItem();
            mnuAsignarEquipos = new ToolStripMenuItem();
            MnuConsultas = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolBtnEquipos = new ToolStripButton();
            toolBtnEmpleados = new ToolStripButton();
            toolBtnDepartamentos = new ToolStripButton();
            toolBtnMantenimiento = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFormularios, mnuOrganizar, mnuAsignarEquipos, MnuConsultas, mnuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFormularios
            // 
            mnuFormularios.DropDownItems.AddRange(new ToolStripItem[] { mnuEquipo, mnuEmpleado, mnuDepartamento, mnuMantenimiento });
            mnuFormularios.Name = "mnuFormularios";
            mnuFormularios.Size = new Size(101, 24);
            mnuFormularios.Text = "Formularios";
            // 
            // mnuEquipo
            // 
            mnuEquipo.Name = "mnuEquipo";
            mnuEquipo.Size = new Size(193, 26);
            mnuEquipo.Text = "Equipo";
            mnuEquipo.Click += mnuEquipo_Click;
            // 
            // mnuEmpleado
            // 
            mnuEmpleado.Name = "mnuEmpleado";
            mnuEmpleado.Size = new Size(193, 26);
            mnuEmpleado.Text = "Empleado";
            mnuEmpleado.Click += mnuEmpleado_Click;
            // 
            // mnuDepartamento
            // 
            mnuDepartamento.Name = "mnuDepartamento";
            mnuDepartamento.Size = new Size(193, 26);
            mnuDepartamento.Text = "Departamento";
            mnuDepartamento.Click += mnuDepartamento_Click;
            // 
            // mnuMantenimiento
            // 
            mnuMantenimiento.Name = "mnuMantenimiento";
            mnuMantenimiento.Size = new Size(193, 26);
            mnuMantenimiento.Text = "Mantenimiento";
            mnuMantenimiento.Click += mnuMantenimiento_Click;
            // 
            // mnuOrganizar
            // 
            mnuOrganizar.DropDownItems.AddRange(new ToolStripItem[] { mnuCascada, mnuVertical, mnuHorizontal, mnuCerrarTodo });
            mnuOrganizar.Name = "mnuOrganizar";
            mnuOrganizar.Size = new Size(88, 24);
            mnuOrganizar.Text = "Organizar";
            // 
            // mnuCascada
            // 
            mnuCascada.Name = "mnuCascada";
            mnuCascada.Size = new Size(219, 26);
            mnuCascada.Text = "Cascada";
            mnuCascada.Click += cacadaToolStripMenuItem_Click;
            // 
            // mnuVertical
            // 
            mnuVertical.Name = "mnuVertical";
            mnuVertical.Size = new Size(219, 26);
            mnuVertical.Text = "Mosaico vertical";
            // 
            // mnuHorizontal
            // 
            mnuHorizontal.Name = "mnuHorizontal";
            mnuHorizontal.Size = new Size(219, 26);
            mnuHorizontal.Text = "Mosaico horizontal";
            // 
            // mnuCerrarTodo
            // 
            mnuCerrarTodo.Name = "mnuCerrarTodo";
            mnuCerrarTodo.Size = new Size(219, 26);
            mnuCerrarTodo.Text = "Cerrar todo";
            // 
            // mnuAsignarEquipos
            // 
            mnuAsignarEquipos.Name = "mnuAsignarEquipos";
            mnuAsignarEquipos.Size = new Size(130, 24);
            mnuAsignarEquipos.Text = "Asignar Equipos";
            mnuAsignarEquipos.Click += mnuAsignarEquipos_Click;
            // 
            // MnuConsultas
            // 
            MnuConsultas.Name = "MnuConsultas";
            MnuConsultas.Size = new Size(86, 24);
            MnuConsultas.Text = "Consultas";
            MnuConsultas.Click += MnuConsultas_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(52, 24);
            mnuSalir.Text = "Salir";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnEquipos, toolBtnEmpleados, toolBtnDepartamentos, toolBtnMantenimiento });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 103);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnEquipos
            // 
            toolBtnEquipos.AutoSize = false;
            toolBtnEquipos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBtnEquipos.Image = (Image)resources.GetObject("toolBtnEquipos.Image");
            toolBtnEquipos.ImageTransparentColor = Color.Magenta;
            toolBtnEquipos.Name = "toolBtnEquipos";
            toolBtnEquipos.Size = new Size(100, 100);
            toolBtnEquipos.Text = "Equipos";
            toolBtnEquipos.ToolTipText = "Abrir modulo de equipo";
            toolBtnEquipos.Click += toolBtnEquipos_Click;
            // 
            // toolBtnEmpleados
            // 
            toolBtnEmpleados.AutoSize = false;
            toolBtnEmpleados.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBtnEmpleados.Image = (Image)resources.GetObject("toolBtnEmpleados.Image");
            toolBtnEmpleados.ImageTransparentColor = Color.Magenta;
            toolBtnEmpleados.Name = "toolBtnEmpleados";
            toolBtnEmpleados.Size = new Size(100, 100);
            toolBtnEmpleados.Text = "Empleados";
            toolBtnEmpleados.ToolTipText = "Abrir modulo de empleos";
            toolBtnEmpleados.Click += toolBtnEmpleados_Click;
            // 
            // toolBtnDepartamentos
            // 
            toolBtnDepartamentos.AutoSize = false;
            toolBtnDepartamentos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBtnDepartamentos.Image = (Image)resources.GetObject("toolBtnDepartamentos.Image");
            toolBtnDepartamentos.ImageTransparentColor = Color.Magenta;
            toolBtnDepartamentos.Name = "toolBtnDepartamentos";
            toolBtnDepartamentos.Size = new Size(100, 100);
            toolBtnDepartamentos.Text = "Departamento";
            toolBtnDepartamentos.ToolTipText = "Abrir modulo de apartamento";
            toolBtnDepartamentos.Click += toolBtnDepartamentos_Click;
            // 
            // toolBtnMantenimiento
            // 
            toolBtnMantenimiento.AutoSize = false;
            toolBtnMantenimiento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBtnMantenimiento.Image = (Image)resources.GetObject("toolBtnMantenimiento.Image");
            toolBtnMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnMantenimiento.Name = "toolBtnMantenimiento";
            toolBtnMantenimiento.Size = new Size(100, 100);
            toolBtnMantenimiento.Text = "Mantenimiento";
            toolBtnMantenimiento.ToolTipText = "Abrir mantenimiento";
            toolBtnMantenimiento.Click += toolBtnMantenimiento_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Formulario principal";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFormularios;
        private ToolStripMenuItem mnuEquipo;
        private ToolStripMenuItem mnuEmpleado;
        private ToolStripMenuItem mnuDepartamento;
        private ToolStripMenuItem mnuMantenimiento;
        private ToolStripMenuItem mnuOrganizar;
        private ToolStripMenuItem mnuCascada;
        private ToolStripMenuItem mnuVertical;
        private ToolStripMenuItem mnuHorizontal;
        private ToolStripMenuItem mnuCerrarTodo;
        private ToolStripMenuItem mnuSalir;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnEquipos;
        private ToolStripButton toolBtnEmpleados;
        private ToolStripButton toolBtnDepartamentos;
        private ToolStripButton toolBtnMantenimiento;
        private ToolStripMenuItem mnuAsignarEquipos;
        private ToolStripMenuItem MnuConsultas;
    }
}