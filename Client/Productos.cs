using BaseDatos.Instrucciones;
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
        }

        private void LimpiarFormulario()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objproducto._IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                objproducto._IdMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                objproducto._Descripcion = txtDescripcion.Text;
                objproducto._Precio = Convert.ToDouble(txtPrecio.Text);
                objproducto.InsertarProductos();

                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion == "Editar")
            {
                objproducto._IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                objproducto._IdMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                objproducto._Descripcion = txtDescripcion.Text;
                objproducto._Precio = Convert.ToDouble(txtPrecio.Text);
                objproducto._Idprod = Convert.ToInt32(idprod);

                objproducto.EditarProductos();
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
                CmbCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objproducto._Idprod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                objproducto.EliminarProducto();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEditarf2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MantenimientoProd frm = new MantenimientoProd();
                frm.Operacion = "Editar";
                frm.ListarCategorias();
                frm.ListarMarcas();

                frm.idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                frm.CmbCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                frm.CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                frm.txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();
                ListarProductos();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            MantenimientoProd frm = new MantenimientoProd();
            frm.Operacion = "Insertar";
            frm.ListarCategorias();
            frm.ListarMarcas();
            frm.ShowDialog();
            ListarProductos();
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
