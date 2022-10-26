using Entidades.Data.Entidades;
using Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        Productos ProductosView;
        UsuarioController usuarioController = new UsuarioController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            Usuario usuarioLogin = new Usuario
            {
                _Email = "juanchi@gmail.com",
                _Password = "123"
            };

            bool result = usuarioController.Login(usuarioLogin);

            if (result)
            {
                ProductosView = new Productos();
                ProductosView.ShowDialog();
                this.Hide();
            }
        }
    }
}
