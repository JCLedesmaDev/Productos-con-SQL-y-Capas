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
    public class CategoriaController
    {

        InstCategoria instCategoria = new InstCategoria();

        public DataTable ObtenerListadoCategorias()
        {
            return instCategoria.ListarCategorias();
        }

        public string InsertarCategoria(Categoria categoria)
        {
            return instCategoria.InsertarCategoria(categoria);
        }
    }

}
