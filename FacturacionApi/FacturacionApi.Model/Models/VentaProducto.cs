using System;
using System.Collections.Generic;

#nullable disable

namespace FacturacionApi.Model.Models
{
    public partial class VentaProducto
    {
        public long Id { get; set; }
        public long VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
