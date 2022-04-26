using System;
using System.Collections.Generic;

#nullable disable

namespace FacturacionApi.Model.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Inventarios = new HashSet<Inventario>();
            VentaProductos = new HashSet<VentaProducto>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<VentaProducto> VentaProductos { get; set; }
    }
}
