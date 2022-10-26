using Entidades.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Instrucciones
{
    public class InstUsuario: ConexionBaseDatos
    {
        public string Registrar(Usuario usuario)
        {
            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion 
                this.cmd.CommandText = "SpRegistrarUsuario"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@email", usuario._Email);
                this.cmd.Parameters.AddWithValue("@password", usuario._Password);
                this.cmd.Parameters.AddWithValue("@nombreCompleto", usuario._NombreCompleto);
                this.cmd.Parameters.AddWithValue("@createDateUser", DateTime.Now);

                this.cmd.ExecuteNonQuery();

                return "Se registro correctamente";
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de registrarse.", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }

        public bool IniciarSesion(Usuario usuario)
        {
            DataTable Table = new DataTable();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "SpIniciarSesion"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@email", usuario._Email);
                this.cmd.Parameters.AddWithValue("@password", usuario._Password);
                
                this.LeerFilas = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion
                Table.Load(this.LeerFilas); // Cargamos la tabla con los datos obtenidos


                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de iniciar sesion", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }
    }
}
