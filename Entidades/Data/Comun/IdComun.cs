using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data.Comun
{
    public class IdComun
    {
        private int id { get; set; }

        public int _Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
