using Entidades.Data.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data.Entidades
{
    public class Producto: IdComun
    {
        //ATRIBUTOS
        private int idCategoria;
        private int idMarca;
        private string descripcion;
        private double precio;

        //metodos get y set
        public int _IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public int _IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double _Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
