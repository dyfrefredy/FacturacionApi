using System;
using System.Collections.Generic;

#nullable disable

namespace FacturacionApi.Model.Models
{
    public partial class Venta
    {
        public Venta()
        {
            VentaProductos = new HashSet<VentaProducto>();
        }

        public long Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<VentaProducto> VentaProductos { get; set; }
    }
}
