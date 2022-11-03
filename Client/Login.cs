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
                _Email = txtEmail.Text,
                _Password = txtcontra.Text
            };

            bool isLogin = usuarioController.Login(usuarioLogin);

            if (isLogin == true)
            {
                ProductosView = new Productos();
                ProductosView.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectos, intentelo nuevamente");
            }

            clearFormLogin();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            if (txtContraRegister.Text != txtRepeContra.Text)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden");
                return;
            }

            Usuario usuarioRegister = new Usuario
            {
                _Email = txtEmailRegister.Text,
                _Password = txtContraRegister.Text,
                _NombreCompleto = txtNombreCompleto.Text                
            };
            string isRegisterMessage = usuarioController.Registrarse(usuarioRegister);

            MessageBox.Show(isRegisterMessage);
            clearFormRegister();

            // Re direccionamos el nav a la seccion del Login para iniciar sesion
            navLoginRegistro.SelectedTab = tabLogin;
        }

        public void clearFormLogin()
        {
            txtEmail.Text = "";
            txtcontra.Text = "";
        }

        public void clearFormRegister()
        {
            txtEmailRegister.Text = "";
            txtContraRegister.Text = "";
            txtNombreCompleto.Text = "";
            txtRepeContra.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MASKEDTXTCONTRA.UseSystemPasswordChar = true;
        }
    }
}
