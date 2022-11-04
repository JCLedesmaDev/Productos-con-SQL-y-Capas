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
    public class MarcaController
    {

        InstMarca instMarca = new InstMarca();

        public DataTable ObtenerListadoMarcas()
        {
            return instMarca.ListarMarcas();
        }

        public string InsertarMarca(Marca marca)
        {
            //return instProductos.InsertarProducto(marca);
            return instMarca.InsertarMarca(marca);
        }
    }
}
