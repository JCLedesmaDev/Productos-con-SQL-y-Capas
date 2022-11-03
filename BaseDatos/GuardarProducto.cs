using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Entidades.Data.Entidades
{
    public class GuardarProducto
    {
        static string cnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Productos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";



        SqlConnection conexion = new SqlConnection(cnString);
        Producto producto = new Producto();
        public GuardarProducto()
        {

        }

        public bool guardarNuevoProducto(Producto producto)
        {

            try
            {
                conexion.Open();

                string insert = "INSERT INTO Productos ([idCategoria],[idMarca],[descripcion],[precio]) VALUES (@idCategoria,@idMarca,@descripcion,@marca,@precio)";
        
                SqlCommand cmd = new SqlCommand(insert, conexion);



                cmd.Parameters.AddWithValue("@idCategoria", producto._IdCategoria);
                cmd.Parameters.AddWithValue("@idMarca", producto._IdMarca);
                cmd.Parameters.AddWithValue("@descripcion", producto._Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto._Precio);
               

                cmd.ExecuteNonQuery();



                conexion.Close();
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error al guardar el producto. Intente nuevamente ");
                Console.WriteLine(E);
                conexion.Close();
                return false;
            }

        }


    }
}
