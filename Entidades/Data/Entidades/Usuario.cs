using Entidades.Data.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data.Entidades
{
    public class Usuario : IdComun
    {
        private string nombreCompleto {get; set; }
        private string email { get; set; }
        private string password { get; set; }

        public string _NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string _Email
        {
            get { return email; }
            set { email = value; }
        }

        public string _Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
