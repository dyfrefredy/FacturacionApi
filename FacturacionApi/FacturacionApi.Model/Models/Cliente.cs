using System;
using System.Collections.Generic;

#nullable disable

namespace FacturacionApi.Model.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
