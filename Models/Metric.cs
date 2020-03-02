using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    public class Metric
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("values")]
        public List<Value> Values { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class Value
    {
        [JsonPropertyName("value")]
        public long InsightValue { get; set; }

        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }
    }
}
