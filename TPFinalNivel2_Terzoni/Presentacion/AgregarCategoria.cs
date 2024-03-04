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
    public partial class AgregarCategoria : Form
    {
        private Categoria categoria = null;
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {

                if (ValidarCategoria())
                    return;


                if(categoria == null)
                {
                    categoria = new Categoria();
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea agregar una nueva Categoria?", "Agregar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(respuesta == DialogResult.Yes)
                    {
                        categoria.Descripcion = txtAgregarCategoria.Text;
                        negocio.AgregarUnaCategoria(categoria);
                        MessageBox.Show("Agregado exitosamente.");

                    }

                    Close();
                }

            }
            catch (Exception)
            {             
                MessageBox.Show("Error al agregar la nueva categoria");
            }


        }

        private bool ValidarCategoria()
        {

            if(txtAgregarCategoria.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la categoría.");
                return true;
            }
            return false;
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
