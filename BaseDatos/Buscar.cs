using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Entidades.Data.Entidades
{
    internal class Buscar
    {
        static string cnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Productos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";


        SqlConnection conexion = new SqlConnection(cnString);

        
        DataTable dataGridView1 = new DataTable();

        public DataTable buscarGeneral(string str)
        {

            conexion.Open();
            string query = "SELECT [idCategoria],[idMarca],[descripcion],[precio] FROM Productos; WHERE nombre LIKE '%" + str + "%' or idCategoria LIKE '%" + str + "%' or idMarca LIKE '%" + str + "%' or Descripcion LIKE '%" + str + "%' or Precio LIKE '%";



            SqlCommand cmd = new SqlCommand(query, conexion);
            //cmd.Parameters.AddWithValue("@buscar",str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            using (dataAdapter)
            {
                dataAdapter.Fill(dataGridView1);
            }

            conexion.Close();

            return dataGridView1;

        }

    }
}


