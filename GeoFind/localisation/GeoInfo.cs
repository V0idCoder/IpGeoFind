using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace localisation
{
    class GeoInfo
    {
        public string Query { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
        public string ZIP { get; set; }
        public String City { get; set; }

        [JsonPropertyName("as")]    // nécessite System.Text.Json.Serialization
        public string AutonomousSystem { get; set; }


    }
}
