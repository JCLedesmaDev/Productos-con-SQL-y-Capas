using BaseDatos.Instrucciones;
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
    }
}
