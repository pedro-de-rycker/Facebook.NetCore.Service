using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The Facebook HttpResponseMessage class.
    /// </summary>
    /// <typeparam name="T">The desired content response cast.</typeparam>

    public class FacebookHttpResponseMessage<T> : HttpResponseMessage
    {
        /// <summary>
        /// The contente of the response.
        /// </summary>
        /// 

        public new T Content { get; set; }

        /// <summary>
        /// Gets the collection of HTTP response headers.
        /// </summary>
        /// 

        public new HttpResponseHeaders Headers { get; }

        /// <summary>
        /// Gets the collection of trailing headers included in an HTTP response.
        /// </summary>
        /// 

        public new HttpResponseHeaders TrailingHeaders { get; }

        /// <summary>
        /// Gets a value that indicates if the HTTP response was successful.
        /// </summary>
        /// 

        public new bool IsSuccessStatusCode { get; set; }

        /// <summary>
        /// Facebook HttpResponseMessage
        /// </summary>
        /// <param name="message">The HttpResponseMessage to cast.</param>
        /// 

        public FacebookHttpResponseMessage(HttpResponseMessage message)
        {
            T content;
            if(message.IsSuccessStatusCode)
            {
                content = JsonSerializer.Deserialize<T>(message.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }
            else
            {
                content = default;
            }

            this.ReasonPhrase = message.ReasonPhrase;
            this.Content = content;
            this.Headers = message.Headers;
            this.RequestMessage = message.RequestMessage;
            this.StatusCode = message.StatusCode;
            this.IsSuccessStatusCode = message.IsSuccessStatusCode;
            this.TrailingHeaders = message.TrailingHeaders;
            this.Version = message.Version;
        }
    }
}
