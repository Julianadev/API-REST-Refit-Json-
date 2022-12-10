using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APICep.Models
{
    internal class CepModels
    {
        [JsonProperty("Cep")]
        public string? Cep { get; set; }

        [JsonProperty("Logradouro")]
        public string? Logradouro { get; set; }

        [JsonProperty("Complemento")]
        public string? Complemento { get; set; }

        [JsonProperty("Bairro")]
        public string? Bairro { get; set; }

        [JsonProperty("Localidade")]
        public string? Localidade { get; set; }

        [JsonProperty("UF")]
        public string? UF { get; set; }

        [JsonProperty("DDD")]
        public string DDD { get; set; }
    }
}
