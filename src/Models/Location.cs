using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The location class.
    /// </summary>
    /// 

    public class Location
    {
        /// <summary>
        /// The city location.
        /// </summary>
        /// 

        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// The country location.
        /// </summary>
        /// 

        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The latitude location.
        /// </summary>
        /// 

        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        /// <summary>
        /// The location parent.
        /// </summary>
        /// 

        [JsonPropertyName("located_in")]
        public string LocatedIn { get; set; }

        /// <summary>
        /// The longitude location.
        /// </summary>
        /// 

        [JsonPropertyName("longitude")]
        public int Longitude { get; set; }

        /// <summary>
        /// The zip of the location.
        /// </summary>
        /// 

        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
