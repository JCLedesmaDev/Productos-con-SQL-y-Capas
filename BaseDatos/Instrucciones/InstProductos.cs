using System;
using System.Data.SqlClient;
using System.Data;
using Entidades.Data.Entidades;

namespace BaseDatos.Instrucciones
{
    public class InstProductos: ConexionBaseDatos
    {

        public DataTable ListarCategorias()
        {
            DataTable Table = new DataTable();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "ListarCategorias"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.LeerFilas = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion

                Table.Load(this.LeerFilas); // Cargamos la tabla con los datos obtenidos

                return Table;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de obtener el listado.", e);
            } 
            finally
            {
                this.LeerFilas.Close(); // Cerramos la lectura de datos
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }

        public DataTable ListarMarcas()
        {
            DataTable Table = new DataTable();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "ListarMarcas"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.LeerFilas = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion

                Table.Load(this.LeerFilas); // Cargamos la tabla con los datos obtenidos

                return Table;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de obtener el listado.", e);
            }
            finally
            {
                this.LeerFilas.Close(); // Cerramos la lectura de datos
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }

        public DataTable ListarProductos()
        {
            DataTable Table = new DataTable();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "ListarProductos"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.LeerFilas = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion

                Table.Load(this.LeerFilas); // Cargamos la tabla con los datos obtenidos

                return Table;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de obtener el listado.", e);
            }
            finally
            {
                this.LeerFilas.Close(); // Cerramos la lectura de datos
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }


        public void InsertarProductos(Producto producto)
        {
            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "AgregarProducto"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@idCategoria", producto._IdCategoria);
                this.cmd.Parameters.AddWithValue("@idMarca", producto._IdMarca);
                this.cmd.Parameters.AddWithValue("@descripcion", producto._Descripcion);
                this.cmd.Parameters.AddWithValue("@precio", producto._Precio);

                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de obtener el listado.", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }



        public void EditarProductos(Producto producto)
        {
            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "EditarProducto"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@id", producto._Idprod);
                this.cmd.Parameters.AddWithValue("@idCategoria", producto._IdCategoria);
                this.cmd.Parameters.AddWithValue("@idMarca", producto._IdMarca);
                this.cmd.Parameters.AddWithValue("@descripcion", producto._Descripcion);
                this.cmd.Parameters.AddWithValue("@precio", producto._Precio);

                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de editar un producto.", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }

        public void EliminarProducto()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete PRODUCTOS where IDPROD=" + idprod;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }


        #region regi
        public DataTable tablaproductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select *from PRODUCTOS";
            Comando.CommandType = CommandType.Text;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        #endregion
    }

}

