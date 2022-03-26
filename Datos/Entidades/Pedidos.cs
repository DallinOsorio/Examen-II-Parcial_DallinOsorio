using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public string identidad { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public decimal precio { get; set; }

        public Pedidos()
        {
        }
        public Pedidos(string identidad, string nombre, string codigo, int cantidad, string descripcion, DateTime fecha, decimal precio)
        {
            this.identidad = identidad;
            this.nombre = nombre;
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.precio = precio;
        }
    }
}
