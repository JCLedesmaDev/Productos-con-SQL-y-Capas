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
                _Email = MASKEDTXTUSUARIO.Text,
                _Password = txtcontraseña.Text,
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
                _Email = maskedemailRegister.Text,
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
            txtcontraseña.Text = "";
            MASKEDTXTUSUARIO.Text = "";
        }

        public void clearFormRegister()
        {
            maskedemailRegister.Text = "";
            txtContraRegister.Text = "";
            txtNombreCompleto.Text = "";
            txtRepeContra.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MASKEDTXTUSUARIO.UseSystemPasswordChar = true;
        }

        private void txtEmailRegister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
