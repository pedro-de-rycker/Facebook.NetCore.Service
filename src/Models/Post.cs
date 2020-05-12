using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The post class
    /// </summary>
    /// 

    public class Post
    {
        /// <summary>
        /// The post id.
        /// </summary>
        /// 

        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The post creation time.
        /// </summary>
        /// 

        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The post message.
        /// </summary>
        /// 

        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The post story.
        /// </summary>
        /// 

        [JsonPropertyName("story")]
        public string Story { get; set; }
    }
}
