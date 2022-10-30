using Entidades.Data.Entidades;
using Server.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;




namespace Client
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            //CARGAR LISTAS EN COMBOBOXS/ DATAGRIDVIEW
            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }

        ProductoController productoController = new ProductoController();
        MarcaController marcaController = new MarcaController();
        CategoriaController categoriaController = new CategoriaController();

        string Operacion = "Insertar";
        string idprod;

        private void ListarCategorias()
        {
            /// Almacenamos el listado obtenido en el ComboBox
            CmbCategoria.DataSource = categoriaController.ObtenerListadoCategorias(); 
            
            // Indicamos que propiedad de los datos del listado obtenido, se mostrara en pantalla
            CmbCategoria.DisplayMember = "Descripcion"; 
            
            // Indicamos que propiedad de los datos del listado obtenido, sera el valor por defecto al seleccionar un combo
            CmbCategoria.ValueMember = "Id"; 
        }
        
        private void ListarMarcas()
        {
            /// Almacenamos el listado obtenido en el ComboBox
            CmbMarca.DataSource = marcaController.ObtenerListadoMarcas();

            // Indicamos que propiedad de los datos del listado obtenido, se mostrara en pantalla
            CmbMarca.DisplayMember = "Descripcion";

            // Indicamos que propiedad de los datos del listado obtenido, sera el valor por defecto al seleccionar un combo
            CmbMarca.ValueMember = "Id";
        }
        
        private void ListarProductos()
        {
            /// Almacenamos el listado obtenido en el ComboBox
            dataGridView1.DataSource = productoController.ObtenerListadoProductos();
        }


        private void LimpiarFormulario()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            
            if (Operacion == "Insertar")
            {
                 // Validacion de campos
                 if (Convert.ToInt32(CmbCategoria.SelectedValue) == 1 || Convert.ToInt32(CmbMarca.SelectedValue) == 1 || txtDescripcion.Text == "" || txtPrecio.Text == "")
                 {
                     MessageBox.Show("Debe completar todos los campos para insertar un producto");
                     return;
                 }

                producto = new Producto
                {
                    _IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue),
                    _IdMarca = Convert.ToInt32(CmbMarca.SelectedValue),
                    _Descripcion = txtDescripcion.Text,
                    _Precio = Convert.ToDouble(txtPrecio.Text)
                };

                string result = productoController.InsertarProducto(producto);
                MessageBox.Show(result);
                
                // Indicamos en los Select que seleccione la opcion cuyo valor es 1 y que es un string vacio.
                CmbCategoria.SelectedValue = 1;
                CmbMarca.SelectedValue = 1;
            }
            
            if (Operacion == "Editar")
            {

                producto = new Producto
                {
                    _Id = Convert.ToInt32(idprod),
                    _IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue),
                    _IdMarca = Convert.ToInt32(CmbMarca.SelectedValue),
                    _Descripcion = txtDescripcion.Text,
                    _Precio = Convert.ToDouble(txtPrecio.Text)
                };

                string result = productoController.EditarProducto(producto);
                Operacion = "Insertar";

                MessageBox.Show(result);
            }
            
             ListarProductos();
            //Limpiar texboxs
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";

                CmbCategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                CmbMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                idprod = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int _IdProd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string result = productoController.EliminarProducto(_IdProd);

                MessageBox.Show(result);

                ListarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

    }
}
