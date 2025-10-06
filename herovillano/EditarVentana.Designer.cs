namespace herovillano
{
    partial class EditarVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarVentana));
            toolStrip1 = new ToolStrip();
            TSBAceptar = new ToolStripButton();
            TSBSalir = new ToolStripButton();
            cbTipo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtHorario = new TextBox();
            label2 = new Label();
            txtNombreMateria = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            cbCalificacion = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBAceptar, TSBSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(325, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSBAceptar
            // 
            TSBAceptar.Image = (Image)resources.GetObject("TSBAceptar.Image");
            TSBAceptar.ImageTransparentColor = Color.Magenta;
            TSBAceptar.Name = "TSBAceptar";
            TSBAceptar.Size = new Size(68, 22);
            TSBAceptar.Text = "Aceptar";
            TSBAceptar.Click += TSBAceptar_Click;
            // 
            // TSBSalir
            // 
            TSBSalir.Alignment = ToolStripItemAlignment.Right;
            TSBSalir.Image = (Image)resources.GetObject("TSBSalir.Image");
            TSBSalir.ImageTransparentColor = Color.Magenta;
            TSBSalir.Name = "TSBSalir";
            TSBSalir.Size = new Size(49, 22);
            TSBSalir.Text = "Salir";
            TSBSalir.ToolTipText = "\r\n";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Obligatoria", "Optativa ", "Eje Formación Común" });
            cbTipo.Location = new Point(143, 145);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 15;
            label4.Text = "Tipo de materia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 240);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 13;
            label3.Text = "Calificaciones:";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(143, 189);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(121, 23);
            txtHorario.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 192);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 11;
            label2.Text = "Horario:";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(143, 93);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(121, 23);
            txtNombreMateria.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 86);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 9;
            label1.Text = "Nombre de la \r\nmateria:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 49);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 18;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(143, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 19;
            // 
            // cbCalificacion
            // 
            cbCalificacion.FormattingEnabled = true;
            cbCalificacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cbCalificacion.Location = new Point(143, 232);
            cbCalificacion.Name = "cbCalificacion";
            cbCalificacion.Size = new Size(121, 23);
            cbCalificacion.TabIndex = 20;
            // 
            // EditarVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 293);
            ControlBox = false;
            Controls.Add(cbCalificacion);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(toolStrip1);
            Controls.Add(cbTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHorario);
            Controls.Add(label2);
            Controls.Add(txtNombreMateria);
            Controls.Add(label1);
            Name = "EditarVentana";
            Text = "EditarVentana";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSBAceptar;
        private ToolStripButton TSBSalir;
        private ComboBox cbTipo;
        private Label label4;
        private Label label3;
        private TextBox txtHorario;
        private Label label2;
        private TextBox txtNombreMateria;
        private Label label1;
        private Label label5;
        private TextBox txtID;
        private ComboBox cbCalificacion;
    }
}