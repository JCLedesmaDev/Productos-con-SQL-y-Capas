using BaseDatos.Instrucciones;
using Entidades.Data.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // https://www.youtube.com/watch?v=Z6D02LVQX5M&list=RDCMUCEQlGiXhpdO4Qhn0sPviagg&index=2&ab_channel=RJCodeAdvance min 5.30
        //https://rjcodeadvance.com/crud-insertar-y-mostrar-datos-con-tablas-relacionadas-sql-c-poo-y-capas-nivel-base/
        //https://github.com/RJCodeAdvance/CRUD-CON-TABLAS-RELACIONADAS-PARTE-2-Completo-C-Sharp-SQL/blob/master/TABLAS_RELACIONADAS/CAPAPRESENTACION/PRODUCTOS.cs

        InstProductos objproducto  = new InstProductos();

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
            InstProductos objProd = new InstProductos();
            CmbCategoria.DataSource = objProd.ListarCategorias();
            CmbCategoria.DisplayMember = "Descripcion";
            CmbCategoria.ValueMember = "Id";
        }
        
        private void ListarMarcas()
        {
            InstProductos objProd = new InstProductos();
            CmbMarca.DataSource = objProd.ListarMarcas();
            CmbMarca.DisplayMember = "Descripcion";
            CmbMarca.ValueMember = "Id";
        }
        
        private void ListarProductos()
        { /*IGNORAR ESTA LINEA ->*/
            VistaBaseDatos();/*<- IGNORAR ESTA LINEA*/

            InstProductos objprod = new InstProductos();
            dataGridView1.DataSource = objprod.ListarProductos();
            /* 
                Nota: Las columnas de la Tabla se cargan automaticamente a partir de los datos que nos devuelve ListarProductos 
            */
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
                
                objproducto.InsertarProductos(producto);

                MessageBox.Show("Se inserto correctamente");
            }
            
            if (Operacion == "Editar")
            {

                producto = new Producto
                {
                    _Idprod = Convert.ToInt32(idprod),
                    _IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue),
                    _IdMarca = Convert.ToInt32(CmbMarca.SelectedValue),
                    _Descripcion = txtDescripcion.Text,
                    _Precio = Convert.ToDouble(txtPrecio.Text)
                };

                objproducto.EditarProductos(producto);
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
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
                
                objproducto.EliminarProducto(_IdProd);

                MessageBox.Show("Se elimino satisfactoriamente");
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

            InstProductos obj = new InstProductos();
            DGVProductos.DataSource = obj.tablaproductos();
            DGVCategorias.DataSource = obj.ListarCategorias();
            DGVMarcas.DataSource = obj.ListarMarcas();
        }

        #endregion ocultar_mostrar_TablasBD
    }
}
