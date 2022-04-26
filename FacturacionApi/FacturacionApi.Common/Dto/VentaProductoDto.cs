using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Common.Dto
{
    [JsonObject(Title = "ventaProductoDto")]
    public class VentaProductoDto
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "ventaId")]
        public long VentaId { get; set; }

        [JsonProperty(PropertyName = "productoId")]
        public int ProductoId { get; set; }

        [JsonProperty(PropertyName = "cantidad")]
        public int Cantidad { get; set; }

        [JsonProperty(PropertyName = "valorUnitario")]
        public decimal ValorUnitario { get; set; }

        [JsonProperty(PropertyName = "valorTotal")]
        public decimal ValorTotal { get; set; }
    }
}
