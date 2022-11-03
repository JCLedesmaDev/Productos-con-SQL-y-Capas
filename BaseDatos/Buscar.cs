using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BaseDatos
{
    public class Buscar: ConexionBaseDatos
    {

        public DataTable buscarGeneral(string str)
        {
            string query = $"SELECT * FROM TablaProductos WHERE Descripcion LIKE '%{str}%';";

            DataTable Tabla = new DataTable();

            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                this.reader= cmd.ExecuteReader();
                Tabla.Load(this.reader);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar productos", e);
            }
            finally
            {
                this.reader.Close();
                CloseConnection();
                cmd.Dispose();
            }
            return Tabla;
        }
    }
}


