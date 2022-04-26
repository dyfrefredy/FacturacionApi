using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Common.Dto
{
    [JsonObject(Title = "cliente")]
    public class ClienteDto
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "apellido")]
        public string Apellido { get; set; }

        [JsonProperty(PropertyName = "edad")]
        public int Edad { get; set; }
    }
}
