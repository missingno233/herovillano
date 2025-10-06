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
    public partial class EditarVentana : Form
    {
        Materia spiderman = new Materia();
        public EditarVentana(Materia Spiderman)
        {
            this.spiderman = Spiderman;
            InitializeComponent();

            txtID.Text = spiderman.ID.ToString();
            txtNombreMateria.Text = spiderman.NombreMateria.ToString();
            txtCalificaciones.Text = spiderman.Calificacion.ToString();
            cbTipo.SelectedItem = spiderman.Tipo.ToString();
            txtHorario.Text = spiderman.Seguidores.ToString();
        }

        private void TSBAceptar_Click(object sender, EventArgs e)
        {

            verificacion();

            if (spiderman.noPasaras == true)
            {
                spiderman.Nombre = txtNombreMateria.Text;
                spiderman.Tipo = cbTipo.SelectedItem.ToString();
                spiderman.Costo = Double.Parse(txtCalificaciones.Text);
                spiderman.Seguidores = int.Parse(txtHorario.Text);


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
            if (string.IsNullOrEmpty(txtCalificaciones.Text) || double.Parse(txtCalificaciones.Text) <= 0.00)
            {
                MessageBox.Show("Porfavor ingrese un nombre");
                return;
            }
            spiderman.noPasaras = true;
        }

    }
}
