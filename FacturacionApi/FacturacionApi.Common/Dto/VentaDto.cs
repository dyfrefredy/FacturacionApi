using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Common.Dto
{
    [JsonObject(Title = "venta")]
    public class VentaDto
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "clienteId")]
        public int ClienteId { get; set; }

        [JsonProperty(PropertyName = "fecha")]
        public DateTime Fecha { get; set; }

        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }


        [JsonProperty(PropertyName = "ventaProducto")]
        public List<VentaProductoDto> VentaProductos { get; set; }
    }
}
