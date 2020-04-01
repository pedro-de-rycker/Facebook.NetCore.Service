using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The content list class.
    /// </summary>
    /// <typeparam name="T">The data type to be casted.</typeparam>
    /// 

    [DataContract]
    public class ListContent<T>
    {
        /// <summary>
        /// The data returned by the Facebook graph API.
        /// </summary>
        /// 

        [JsonPropertyName("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// The paging of the content.
        /// </summary>
        /// 

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }

    /// <summary>
    /// The content class.
    /// </summary>
    /// <typeparam name="T">The data type to be casted.</typeparam>
    /// 

    [DataContract]
    public class Content<T>
    {
        /// <summary>
        /// The data returned by the Facebook graph API.
        /// </summary>
        /// 

        [JsonPropertyName("data")]
        public T Data { get; set; }

        /// <summary>
        /// The paging of the content.
        /// </summary>
        /// 

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }

    /// <summary>
    /// The paging class.
    /// </summary>
    /// 

    public class Paging
    {
        /// <summary>
        /// The paging cursors.
        /// </summary>
        /// 

        [JsonPropertyName("cursors")]
        public Cursors Cursors { get; set; }
    }

    /// <summary>
    /// The cursors class.
    /// </summary>

    public class Cursors
    {
        /// <summary>
        /// The before cursor.
        /// </summary>
        /// 

        [JsonPropertyName("before")]
        public string Before { get; set; }

        /// <summary>
        /// The after cursor.
        /// </summary>
        /// 

        [JsonPropertyName("after")]
        public string After { get; set; }
    }
}
