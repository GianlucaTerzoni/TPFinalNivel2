using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public  class MarcaNegocio
    {

        public List<Marca> ListarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion From MARCAS");
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                     Marca aux = new Marca();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;

            }catch  (Exception ex)
            {
                throw ex;
            }
        }
    }
}
