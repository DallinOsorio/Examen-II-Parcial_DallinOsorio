using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }


        Productos productos;
        private void GuardarButton_Click(object sender, EventArgs e)
        {
           
            string operacion = string.Empty;
           // Productos productos = new Productos();

            Pedidos pedidos = new Pedidos();
            pedidos.identidad = IdentidadMaskedTextBox.Text;
            pedidos.nombre = NombreTextBox.Text;
            pedidos.codigo = productos.Codigo;
            pedidos.cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.descripcion = productos.Descripcion;
            pedidos.precio = productos.Precio;
            pedidos.fecha = FechaDateTimePicker.Value;
            PedidosDA pedidosDA = new PedidosDA();

                bool inserto = pedidosDA.InsertarPedido(pedidos);

                if (inserto)
                {
                    MessageBox.Show("Pedido Insertado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                LimpiarControles();

                }
                 else
                 {
                MessageBox.Show("Pedido NO Insertado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
    
           
            
            }
            private void FrmProducto_Load(object sender, EventArgs e)
            {
                ListarProductos();
            }

            private void ListarProductos()
            {
              PedidosDA pedidosDA = new PedidosDA();
             ProductosDA ProductosDA = new ProductosDA();
            ProductosDataGridView.DataSource = ProductosDA.ListarProductos();
            PedidosDataGridView.DataSource = pedidosDA.ListarProductos();
            }

            

            
            private void LimpiarControles()
            {

                CodigoTextBox.Clear();
                CantidadTextBox.Clear();
                
            }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

      
    }
    
}
