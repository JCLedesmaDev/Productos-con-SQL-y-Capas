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
        }

        ProductoController productoController = new ProductoController();
        MarcaController marcaController = new MarcaController();
        CategoriaController categoriaController = new CategoriaController();

        string Operacion = "Insertar";
        string idprod;

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            //CARGAR LISTAS EN COMBOBOXS/ DATAGRIDVIEW
            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }

        private void ListarCategorias()
        {
            /* Nota: Las columnas de la Tabla se cargan automaticamente a partir de los datos que nos devuelve ListarProductos  */
            CmbCategoria.DataSource = categoriaController.ObtenerListadoCategorias();
            CmbCategoria.DisplayMember = "Descripcion";
            CmbCategoria.ValueMember = "Id";
        }
        
        private void ListarMarcas()
        {
            /* Nota: Las columnas de la Tabla se cargan automaticamente a partir de los datos que nos devuelve ListarProductos  */
            CmbMarca.DataSource = marcaController.ObtenerListadoMarcas();
            CmbMarca.DisplayMember = "Descripcion";
            CmbMarca.ValueMember = "Id";
        }
        
        private void ListarProductos()
        {   /*IGNORAR ESTA LINEA ->*/
                VistaBaseDatos();
            /*<- IGNORAR ESTA LINEA*/

            /* Nota: Las columnas de la Tabla se cargan automaticamente a partir de los datos que nos devuelve ListarProductos  */
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
                producto = new Producto
                {
                    _IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue),
                    _IdMarca = Convert.ToInt32(CmbMarca.SelectedValue),
                    _Descripcion = txtDescripcion.Text,
                    _Precio = Convert.ToDouble(txtPrecio.Text)
                };

                string result = productoController.InsertarProducto(producto);

                MessageBox.Show(result);
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

  
        //METODOS VISTA DE LA BASE DE DATOS
        #region ocultar_mostrar_TablasBD

        private void btnVistaBD_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 330)
                this.Size = new Size(1000, 700);
            else
                this.Size = new Size(1000, 330);
        }
        private void VistaBaseDatos()
        {

            DGVProductos.DataSource = productoController.ObtenerTablaProducto();
            DGVCategorias.DataSource = categoriaController.ObtenerListadoCategorias();
            DGVMarcas.DataSource = marcaController.ObtenerListadoMarcas();
        }

        #endregion ocultar_mostrar_TablasBD
    }
}
