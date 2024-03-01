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
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.Imagen);
            }

        }


        private void Cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnas();
                CargarImagen(listaArticulos[0].Imagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagenArticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioAlta alta = new FormularioAlta();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormularioAlta modificar = new FormularioAlta(seleccionado);
            modificar.ShowDialog();
            Cargar();

        }
    }
}
