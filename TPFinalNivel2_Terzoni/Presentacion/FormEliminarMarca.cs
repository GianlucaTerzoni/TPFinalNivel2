using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class FormEliminarMarca : Form
    {

        private List<Marca> ListaDeMarcas;

        public FormEliminarMarca()
        {
            InitializeComponent();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            EliminarMarca();

        }
        private void Cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                ListaDeMarcas = negocio.ListarMarca();
                lbxMarcas.DataSource = ListaDeMarcas;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormEliminarMarca_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void EliminarMarca()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro desea eliminarla?", "Eliminando Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)lbxMarcas.SelectedItem;
                    negocio.EliminarMarca(seleccionado);
                    Cargar();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar eliminar la marca seleccionada.");
            }

        }

        private void btnCancelarEliminarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
