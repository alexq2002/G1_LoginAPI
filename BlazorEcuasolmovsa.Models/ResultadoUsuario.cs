using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorEcuasolmovsa.Models
{
    public class ResultadoUsuario
    {
        [JsonProperty("OBSERVACION")]
        public string observacion { get; set; }
        [JsonProperty("Emisor")]
        public int emisor { get; set; }
        [JsonProperty("NOMBRECOMPANIA")]
        public string nombreCompania { get; set; }

    }
}
