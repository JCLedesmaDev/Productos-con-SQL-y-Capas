using Entidades.Data.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data.Entidades
{
    public class Categoria : IdComun
    {
        private string descripcion;
       
        //metodos get y set
        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
