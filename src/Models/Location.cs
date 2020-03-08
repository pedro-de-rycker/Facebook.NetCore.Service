using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    public class Location
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        [JsonPropertyName("located_in")]
        public string LocatedIn { get; set; }

        [JsonPropertyName("longitude")]
        public int Longitude { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
