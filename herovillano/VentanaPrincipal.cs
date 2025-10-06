using herovillano.Models;

namespace herovillano
{
    public partial class VentanaPrincipal : Form
    {

        Materia materia = new Materia();

       



        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void TSBObtener_Click(object sender, EventArgs e)
        {
           
        }

        private void TSBAgregar_Click(object sender, EventArgs e)
        {
            AgregarVentana ventana = new AgregarVentana(personaje);
            ventana.ShowDialog();

            
            object[] renglonChido =
            {
                personaje.ID,
                personaje.Nombre,
                personaje.Tipo,
                personaje.Seguidores,
                personaje.Costo

            };
            if (personaje.noPasaras == true)
            {
                DGVPersonaje.Rows.Add(renglonChido);
            }
            
        }

        private void TSBEliminar_Click(object sender, EventArgs e)
        {
            if (DGVPersonaje.SelectedRows != null &&
                DGVPersonaje.SelectedRows.Count == 1) 
            {
                DialogResult = MessageBox.Show($"seguro desea eliminar el registro {personaje.Nombre}", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes) 
                {
                    DGVPersonaje.Rows.Remove(DGVPersonaje.SelectedRows[0]); 
                } 
                 
            }
            else
            {
                MessageBox.Show("porfavor, seleccione un registro");
            }

            
        }

        private void TSBEditar_Click(object sender, EventArgs e)
        {

            if (DGVPersonaje.SelectedRows != null &&
                DGVPersonaje.SelectedRows.Count == 1)
            {
                DataGridViewRow r = DGVPersonaje.SelectedRows[0];

                personaje.ID = int.Parse(r.Cells["ID"].Value.ToString());
                personaje.Nombre = r.Cells["Nombre"].Value.ToString();
                personaje.Tipo = r.Cells["Tipo"].Value.ToString();
                personaje.Seguidores = int.Parse(r.Cells["Seguidores"].Value.ToString());
                personaje.Costo = Double.Parse(r.Cells["Costo"].Value.ToString());

                EditarVentana ventana = new EditarVentana(personaje);
                ventana.ShowDialog();

                if (personaje.noPasaras == true)
                {
                    r.Cells["ID"].Value = personaje.ID;
                    r.Cells["Nombre"].Value = personaje.Nombre;
                    r.Cells["Tipo"].Value = personaje.Tipo;
                    r.Cells["Seguidores"].Value = personaje.Seguidores;
                    r.Cells["Costo"].Value = personaje.Costo;
                }
            }
            else
            {
                MessageBox.Show("porfavor selecione un registro para editar");
            }

        }
    }
}
