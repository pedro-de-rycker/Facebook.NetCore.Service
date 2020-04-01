using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The page informations class.
    /// </summary>
    /// 

    public class PageInformations
    {
        /// <summary>
        /// The about section of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("about")]
        public string About { get; set; }

        /// <summary>
        /// The location of a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// The emails linked to a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("emails")]
        public List<string> Emails { get; set; }

        /// <summary>
        /// The about website linked to a Facebook page.
        /// </summary>
        /// 

        [JsonPropertyName("website")]
        public string Website { get; set; }

        /// <summary>
        /// The Facebook page id.
        /// </summary>
        /// 

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
