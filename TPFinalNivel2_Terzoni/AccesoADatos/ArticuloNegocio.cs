using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
       
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, C.Id AS IdCategoria, C.Descripcion AS Categoria, M.Id AS IdMarca, M.Descripcion AS Marca From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.Id = A.IdMarca");
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }

         
                return lista;

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

        public void Agregar(Articulo nuevo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdCategoria, IdMarca) VALUES (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @Precio, @IdCategoria, @IdMarca)");
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.SetearParametro("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametro("ImagenUrl", nuevo.Imagen);
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

        public void Modificar(Articulo articulo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio, Descripcion = @Descripcion Where Id = @Id");
                datos.SetearParametro("@Codigo", articulo.Codigo);
                datos.SetearParametro("@Nombre", articulo.Nombre);
                datos.SetearParametro("@IdMarca", articulo.Marca.Id);
                datos.SetearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.SetearParametro("@ImagenUrl", articulo.Imagen);
                datos.SetearParametro("@Precio", articulo.Precio);
                datos.SetearParametro("@Descripcion", articulo.Descripcion);
                datos.SetearParametro("@Id", articulo.Id);

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


        public void  Eliminar(Articulo articulo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearConsulta("Delete from ARTICULOS where Id = @Id");
                datos.SetearParametro("@Id", articulo.Id);
                datos.EjecutarAccion();

            }catch(Exception ex)
            {
                throw ex;
            }

        }


        public List<Articulo> Filtrar( string campo,string criterio, string filtro)
        {
            List <Articulo> lista = new List <Articulo>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                string consulta = ("Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, C.Id AS IdCategoria, C.Descripcion AS Categoria, M.Id AS IdMarca, M.Descripcion AS Marca From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.Id = A.IdMarca AND ");
                
                if (campo == "Precio")
                {

                    switch (criterio)
                    {
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;

                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;

                        default:
                            consulta += "Precio = " + filtro;
                            break;

                    }

                }else if (campo == "Marca")
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%'";
                            break;

                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;

                    }
                }
                else
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%'";
                            break;

                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;

                    }
                }


                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }



            return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
