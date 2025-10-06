namespace herovillano
{
    partial class AgregarVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarVentana));
            label1 = new Label();
            txtNombreMateria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbTipo = new ComboBox();
            toolStrip1 = new ToolStrip();
            TSBAceptar = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            comboBox1 = new ComboBox();
            cbCalificacion = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la\r\n Materia:";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(145, 62);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(121, 23);
            txtNombreMateria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 164);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Horario:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 212);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Calificacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 120);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Materia";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Obligatoria", "Optativa ", "Eje Formación Común" });
            cbTipo.Location = new Point(145, 117);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBAceptar, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(351, 25);
            toolStrip1.TabIndex = 8;
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
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(49, 22);
            toolStripButton2.Text = "Salir";
            toolStripButton2.ToolTipText = "\r\n";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00", "18:00 - 19:00", "19:00 - 20:00", "20:00 - 21:00" });
            comboBox1.Location = new Point(145, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // cbCalificacion
            // 
            cbCalificacion.FormattingEnabled = true;
            cbCalificacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cbCalificacion.Location = new Point(145, 209);
            cbCalificacion.Name = "cbCalificacion";
            cbCalificacion.Size = new Size(121, 23);
            cbCalificacion.TabIndex = 10;
            // 
            // AgregarVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 290);
            ControlBox = false;
            Controls.Add(cbCalificacion);
            Controls.Add(comboBox1);
            Controls.Add(toolStrip1);
            Controls.Add(cbTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreMateria);
            Controls.Add(label1);
            Name = "AgregarVentana";
            Text = "AgregarVentana";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreMateria;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbTipo;
        private ToolStrip toolStrip1;
        private ToolStripButton TSBAceptar;
        private ToolStripButton toolStripButton2;
        private ComboBox comboBox1;
        private ComboBox cbCalificacion;
    }
}