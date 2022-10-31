using Entidades.Data.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Instrucciones
{
    public class InstUsuario: ConexionBaseDatos
    {
        public string CreateUser(Usuario usuario)
        {
            string Message = "";
            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion 
                this.cmd.CommandText = "SpAgregarUsuario"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@email", usuario._Email);
                this.cmd.Parameters.AddWithValue("@password", usuario._Password);
                this.cmd.Parameters.AddWithValue("@nombreCompleto", usuario._NombreCompleto);
                this.cmd.Parameters.AddWithValue("@createDateUser", DateTime.Now);

                this.cmd.ExecuteNonQuery();

                Message = "Se registro correctamente. Inicie Sesion";
            }
            catch (Exception e)
            {
                Message = "Ocurrio un error a la hora de registrarse. Intentelo con otro email";
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
            return Message;
        }

        public List<object> GetUser (Usuario usuario)
        {
            List<object> UserFind = new List<object>();

            try
            {
                this.cmd.Connection = this.OpenConnection(); // Abrimos conexion
                this.cmd.CommandText = "SpObtenerUsuario"; /// Nombramos el procedimiento creado en el SqlServer
                this.cmd.CommandType = CommandType.StoredProcedure; // Indicamos que estamos utilizando procedimientos almacenados (Por lo de arriba) 

                this.cmd.Parameters.AddWithValue("@email", usuario._Email);
                this.cmd.Parameters.AddWithValue("@password", usuario._Password);
                
                this.reader = this.cmd.ExecuteReader(); // Almacenamos los resultados de nuestra peticion

                while (this.reader.Read())
                {
                    UserFind.Add(this.reader[0]);
                }

                return UserFind;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error a la hora de iniciar sesion", e);
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.reader.Close(); // Cerramos la lectura de datos
                this.CloseConnection(); // Cerramos la conexion a la BD
            }
        }
    }
}
