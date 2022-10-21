using System;
using System.Data.SqlClient;
using System.Data;


namespace BaseDatos
{
    public class ConexionBaseDatos
    {

        /* NOTA MUCHO MUY IMPORTANTE. Crear BaseDatos Productos con Tabla Producto en el SQL Server */

        protected SqlConnection ConnectionSql { get; set; }

        protected string ConnectionString = "Data Source=JUANCHINOTE\\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

        public ConexionBaseDatos()
        {
            this.ConnectionSql = new SqlConnection(ConnectionString);
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (ConnectionSql.State == ConnectionState.Broken ||
                    ConnectionSql.State == ConnectionState.Closed)
                {
                    ConnectionSql.Open();
                }

                return this.ConnectionSql;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de abrir la conexion", ex);
            }
        }

        public SqlConnection CloseConnection()
        {
            try
            {
                if (ConnectionSql.State == ConnectionState.Open)
                {
                    ConnectionSql.Close();
                }
                return this.ConnectionSql;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de cerrar la conexion", ex);
            }
        }
    }
}

