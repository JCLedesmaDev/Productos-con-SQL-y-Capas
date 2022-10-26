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
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //if ((txtusuario.Text != "") && (txtcontra.Text != ""))
            //{
            //if ((txtusuario.Text == "AdiminJYV") && (txtusuario.Text == "12345vanejuan"))
            //{
                    ProductosView = new Productos();
                    ProductosView.ShowDialog();
                    this.Hide();
            //}
            //}
        }
    }
}
