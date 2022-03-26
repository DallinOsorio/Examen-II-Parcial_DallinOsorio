using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=Dallin20.;";

        MySqlConnection conn;
        MySqlCommand cmd;
        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();
           
            try
            {
                string sql = "SELECT * FROM pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }


        public bool InsertarPedido(Pedidos pedidos)
            {
            bool inserto = false;

            try
            {
                string sql = "INSERT INTO pedidos VALUES (@Identidad, @Nombre, @Codigo, @Cantidad, @Descripcion, @Precio ,@Fecha);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Identidad",pedidos.identidad);
                cmd.Parameters.AddWithValue("@Nombre", pedidos.nombre);
                cmd.Parameters.AddWithValue("@Codigo", pedidos.codigo);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.cantidad);
                cmd.Parameters.AddWithValue("@Descripcion", pedidos.descripcion);
                cmd.Parameters.AddWithValue("@Precio", pedidos.precio);
                cmd.Parameters.AddWithValue("@Fecha", pedidos.fecha);
                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}

