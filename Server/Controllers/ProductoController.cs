using BaseDatos.Instrucciones;
using Entidades.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class ProductoController
    {

        InstProductos instProductos = new InstProductos();
        
        public DataTable ObtenerListadoProductos()
        {
            return instProductos.ListarProductos();
        }

        public string InsertarProducto(Producto producto)
        {
            return instProductos.InsertarProducto(producto);
        }

        public string EditarProducto(Producto producto)
        {
            return instProductos.EditarProducto(producto);
        }

        public string EliminarProducto(int idProd)
        {
            return instProductos.EliminarProducto(idProd);
        }
   
    }
}
