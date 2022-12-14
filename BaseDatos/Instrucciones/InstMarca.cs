using Entidades.Data.Entidades;
using System;
using System.Data;

namespace BaseDatos.Instrucciones
{
    /// INSTRUCCIONES DE MARCA
    public class InstMarca: ConexionBaseDatos
    {
        public DataTable ListarMarcas()
        {
            DataTable Table = new DataTable();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "SpListarMarcas"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.reader = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion

                Table.Load(this.reader); // Cargamos la tabla con los datos obtenidos

                return Table;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de obtener el listado.", e);
            }
            finally
            {
                this.reader.Close(); // Cerramos la lectura de datos
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }

        public string InsertarMarca(Marca marca)
        {
            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion

                this.cmd.CommandText = "SpAgregarMarcas"; /// Nombramos el procedimiento creado en el SqlServer

                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@descripcion", marca._Descripcion);

                this.cmd.ExecuteNonQuery();

                return "Se inserto correctamente";
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de insertar una marca.", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }
    }
}
