using BaseDatos.Instrucciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class CategoriaController
    {

        InstCategoria instCategoria = new InstCategoria();

        public DataTable ObtenerListadoCategorias()
        {
            return instCategoria.ListarCategorias();
        }
    }
}
