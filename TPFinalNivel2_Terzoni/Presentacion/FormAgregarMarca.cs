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
using Dominio;

namespace Presentacion
{
    public partial class FormAgregarMarca : Form
    {
        private Marca marca = null;
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if (ValidarMarca())
                    return;


                if (marca == null)
                    marca = new Marca();

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea agregar una nueva Marca?", "Agregar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    marca.Descripcion = txtAgregarMarca.Text;
                    marcaNegocio.AgregarMarca(marca);
                    MessageBox.Show("Agregado exitosamente.");
                }


                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al intentar agregar la marca.");
            }
        }

        private bool ValidarMarca()
        {
            if(txtAgregarMarca.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la marca que desea agregar.");
                return true;
            }


            return false;
        }

    }
}
