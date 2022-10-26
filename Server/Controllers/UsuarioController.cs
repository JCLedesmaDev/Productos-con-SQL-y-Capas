using BaseDatos.Instrucciones;
using Entidades.Data.Entidades;
using System;
using System.Collections.Generic;
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
            return instUsuario.IniciarSesion(usuario);
        }


        public string Registrarse(Usuario usuario)
        {
            return instUsuario.Registrar(usuario);
        }

    }
}
