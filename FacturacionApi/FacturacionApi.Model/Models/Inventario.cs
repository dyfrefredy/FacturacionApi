using System;
using System.Collections.Generic;

#nullable disable

namespace FacturacionApi.Model.Models
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int CantidadDisponible { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
