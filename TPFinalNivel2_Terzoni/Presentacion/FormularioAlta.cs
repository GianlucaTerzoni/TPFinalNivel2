using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Presentacion
{
    public partial class FormularioAlta : Form
    {
        private Articulo articulo = null;

        public FormularioAlta()
        {
            InitializeComponent();

        }
        
        public FormularioAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (ValidacionAgregar())
                    return;


                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Descripcion = txtDescripcion.Text;



                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                negocio.Agregar(articulo);
                MessageBox.Show("Agregado exitosamente.");

                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidacionAgregar()
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un código para el producto.");
                return true;
            }
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del producto.");
                return true;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoría para el producto.");
                return true;
            }
            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar la marca del producto.");
                return true;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio para el producto.");
                return true;
            }
            if (!(SoloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Debe ingresar solo valores numéricos.");
                txtPrecio.Text = "";
                return true;
            }
          
            return false;
        }


        private bool SoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))

                    return false;
            }

            return true;
        }

        private void FormularioAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();
            

            try
            {
                cboCategoria.DataSource = categoria.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = marca.ListarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";



                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtImagen.Text = articulo.Imagen;
                    CargarImagenAlta(articulo.Imagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;

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
                pbxImagenAlta.Load(imagen);

            }
            catch (Exception)
            {
                pbxImagenAlta.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagenAlta(txtImagen.Text);
        }
    }
}
