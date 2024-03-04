using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> Listar()
        {

            List<Categoria> lista = new List<Categoria>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }          
        }

        public void AgregarUnaCategoria(Categoria nuevo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    
    }
}
