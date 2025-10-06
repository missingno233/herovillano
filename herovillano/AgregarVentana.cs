using herovillano.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herovillano
{
    public partial class AgregarVentana : Form
    {
        Materia Superman = new Materia();
        public AgregarVentana(Materia superman)
        {
            this.Superman = superman;
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSBAceptar_Click(object sender, EventArgs e)
        {

            verificacion();

            if (Superman.noPasaras == true)
            {
                Superman.Nombre = txtNombreMateria.Text;
                Superman.Seguidores = int.Parse(txtHorario.Text);
                Superman.Tipo = cbTipo.SelectedItem.ToString();
                Superman.Costo = Double.Parse(txtCalificacion.Text);
                this.Close();
            }
            else
            {
                return;
            }


        }

        public void verificacion()
        {
            if (String.IsNullOrEmpty(txtNombreMateria.Text))
            {
                MessageBox.Show("Porfavor ingrese un nombre");
                return;
            }
            if (String.IsNullOrEmpty(txtHorario.Text))
            {
                MessageBox.Show("Porfavor ingrese el numero de seguidores");
                return;
            }
            if (cbTipo.SelectedItem == null)
            {
                MessageBox.Show("Porfavor seleccione un tipo");
                return;
            }
            if (string.IsNullOrEmpty(txtCalificacion.Text) || double.Parse(txtCalificacion.Text) <= 0.00)
            {
                MessageBox.Show("Porfavor ingrese un nombre");
                return;
            }
            Superman.noPasaras = true;
        }

    }
}
