﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {

        public List <Categoria> listarCategoria()
        {
            List <Categoria> categoria = new List <Categoria> ();
            AccesoADatos datos = new AccesoADatos ();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    categoria.Add (aux);

                }

                return categoria;

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
