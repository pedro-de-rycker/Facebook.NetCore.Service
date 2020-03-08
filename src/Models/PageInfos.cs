using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    public class PageInfos
    {
        [JsonPropertyName("about")]
        public string About { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("emails")]
        public List<string> Emails { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
