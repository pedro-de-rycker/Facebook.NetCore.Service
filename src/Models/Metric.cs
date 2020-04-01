using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The metric class.
    /// </summary>
    /// 

    public class Metric
    {
        /// <summary>
        /// The name of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The period on which the metric stands.
        /// </summary>
        /// 

        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// The metric values.
        /// </summary>
        /// 

        [JsonPropertyName("values")]
        public List<Value> Values { get; set; }

        /// <summary>
        /// The title of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The id of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    /// <summary>
    /// The value class.
    /// </summary>
    /// 

    public class Value
    {
        /// <summary>
        /// The value of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("value")]
        public long InsightValue { get; set; }

        /// <summary>
        /// The end time of the value of the metric.
        /// </summary>
        /// 

        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }
    }
}
