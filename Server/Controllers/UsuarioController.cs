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
    public class UsuarioController
    {

        InstUsuario instUsuario = new InstUsuario();    

        public bool Login(Usuario usuario)
        {
            bool result = false;
            List<object> User = instUsuario.GetUser(usuario);

            if (User.Count > 0)
            {
                result = true;
            }

            return result;
        }


        public string Registrarse(Usuario usuario)
        {
            return instUsuario.CreateUser(usuario);
        }

    }
}
