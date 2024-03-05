using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormDetalle : Form
    {

        private Articulo articulo;
        public FormDetalle()
        {
            InitializeComponent();
           
        }

        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                               
                if(articulo != null)
                {
                    lblID.Text= articulo.Id.ToString();
                    lblCodigo.Text = articulo.Codigo;
                    lblNombre.Text = articulo.Nombre;
                    lblMarca.Text = articulo.Marca.Id.ToString();
                    lblCategoria.Text = articulo.Categoria.Id.ToString();
                    lblImagen.Text = articulo.Imagen;
                    CargarImagenAlta(articulo.Imagen);
                    lblPrecio.Text = articulo.Precio.ToString();
                    lblDescripcion.Text = articulo.Descripcion;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarImagenAlta(string imagen)
        {
            try
            {
                pbxDetalle.Load(imagen);

            }
            catch (Exception)
            {
                pbxDetalle.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
