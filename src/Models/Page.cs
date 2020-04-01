using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The page class.
    /// </summary>
    /// 

    [DataContract]
    public class Page
    {
        /// <summary>
        /// The accessToken of a Facebook page.
        /// It is linked to a user.
        /// </summary>
        /// 

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The category of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The categories of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("category_list")]
        public List<Category> CategoryList { get; set; }

        /// <summary>
        /// The name of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Facebook page id.
        /// </summary>
        /// 

        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The tasks of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("tasks")]
        public List<string> Tasks { get; set; }
    }
}
