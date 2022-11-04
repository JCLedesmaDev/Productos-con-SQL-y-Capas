using Client.Interface;
using Entidades.Data.Entidades;
using Server.Controllers;
using System;
using System.Windows.Forms;
using Client.Interface;
using System.Text.RegularExpressions;

namespace Client
{
    public partial class AgregarCategoriaMarca : Form
    {

        MarcaController marcaController = new MarcaController();
        CategoriaController categoriaController = new CategoriaController();
        private IForm _formProducto;

        public AgregarCategoriaMarca( IForm formProducto)
        {
            InitializeComponent();
            this._formProducto = formProducto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._formProducto.ListarCategorias();
            this._formProducto.ListarMarcas();
            Close();
        }

        private void agregarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca
            {
                _Descripcion = lblMarca.Text
            };

                
            string result = marcaController.InsertarMarca(marca);
            MessageBox.Show(result);

            lblMarca.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria
            {
                _Descripcion = lblCategoria.Text
            };


            string result = categoriaController.InsertarCategoria(categoria);
            MessageBox.Show(result);

            lblCategoria.Text = "";
        }
    }
}
