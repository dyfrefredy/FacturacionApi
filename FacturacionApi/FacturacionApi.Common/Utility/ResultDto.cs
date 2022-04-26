using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Common.Utility
{
    [Serializable]
    [JsonObject(Title = "resultDto")]
    public class ResultDto<T>
    {
        [JsonProperty(PropertyName = "responseDto")]
        public ResponseDto ResponseDto { get; set; }

        [JsonProperty(PropertyName = "totalRecords")]
        public Int64 TotalRecords { get; set; }

        [JsonProperty(PropertyName = "businessDto")]
        public List<T> BusinessDto { get; set; }
    }
}
