namespace herovillano
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            toolStrip1 = new ToolStrip();
            TSBObtener = new ToolStripButton();
            TSBAgregar = new ToolStripButton();
            TSBEditar = new ToolStripButton();
            TSBEliminar = new ToolStripButton();
            DGVPersonaje = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreMateria = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPersonaje).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBObtener, TSBAgregar, TSBEditar, TSBEliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(554, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSBObtener
            // 
            TSBObtener.Image = (Image)resources.GetObject("TSBObtener.Image");
            TSBObtener.ImageTransparentColor = Color.Magenta;
            TSBObtener.Name = "TSBObtener";
            TSBObtener.Size = new Size(70, 22);
            TSBObtener.Text = "Obtener";
            TSBObtener.Click += TSBObtener_Click;
            // 
            // TSBAgregar
            // 
            TSBAgregar.Image = (Image)resources.GetObject("TSBAgregar.Image");
            TSBAgregar.ImageTransparentColor = Color.Magenta;
            TSBAgregar.Name = "TSBAgregar";
            TSBAgregar.Size = new Size(69, 22);
            TSBAgregar.Text = "Agregar";
            TSBAgregar.Click += TSBAgregar_Click;
            // 
            // TSBEditar
            // 
            TSBEditar.Image = (Image)resources.GetObject("TSBEditar.Image");
            TSBEditar.ImageTransparentColor = Color.Magenta;
            TSBEditar.Name = "TSBEditar";
            TSBEditar.Size = new Size(57, 22);
            TSBEditar.Text = "Editar";
            TSBEditar.Click += TSBEditar_Click;
            // 
            // TSBEliminar
            // 
            TSBEliminar.Image = (Image)resources.GetObject("TSBEliminar.Image");
            TSBEliminar.ImageTransparentColor = Color.Magenta;
            TSBEliminar.Name = "TSBEliminar";
            TSBEliminar.Size = new Size(70, 22);
            TSBEliminar.Text = "Eliminar";
            TSBEliminar.Click += TSBEliminar_Click;
            // 
            // DGVPersonaje
            // 
            DGVPersonaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPersonaje.Columns.AddRange(new DataGridViewColumn[] { ID, NombreMateria, Tipo, Horario, Calificacion });
            DGVPersonaje.Location = new Point(12, 42);
            DGVPersonaje.Name = "DGVPersonaje";
            DGVPersonaje.Size = new Size(527, 150);
            DGVPersonaje.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NombreMateria
            // 
            NombreMateria.HeaderText = "Nombre";
            NombreMateria.Name = "NombreMateria";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Horario
            // 
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificacion";
            Calificacion.Name = "Calificacion";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 208);
            Controls.Add(DGVPersonaje);
            Controls.Add(toolStrip1);
            Name = "VentanaPrincipal";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPersonaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSBObtener;
        private ToolStripButton TSBAgregar;
        private ToolStripButton TSBEliminar;
        private DataGridView DGVPersonaje;
        private ToolStripButton TSBEditar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreMateria;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Calificacion;
    }
}
