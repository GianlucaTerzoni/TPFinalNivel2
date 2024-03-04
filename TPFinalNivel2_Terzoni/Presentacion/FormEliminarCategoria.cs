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
    public partial class FormEliminarCategoria : Form
    {
        private List<Categoria> ListaDeCategorias;
        public FormEliminarCategoria()
        {
            InitializeComponent();
        }

        private void FormEliminarCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                ListaDeCategorias = negocio.Listar();
                lbxCategoria.DataSource = ListaDeCategorias;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EliminarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminarla?", "Eliminando Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)lbxCategoria.SelectedItem;
                    negocio.EliminarUnaCategoria(seleccionado);
                    Cargar();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar eliminar la categoría seleccionada.");
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
           
        }

        private void btnCancelarEliminarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
