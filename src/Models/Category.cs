using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The category class.
    /// </summary>
    /// 

    [DataContract]
    public class Category
    {
        /// <summary>
        /// The id of the category.
        /// </summary>
        /// 

        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        /// 

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
