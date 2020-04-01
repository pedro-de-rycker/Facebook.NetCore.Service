using Facebook.NetCore.HttpClient;
using Facebook.NetCore.HttpClient.ExtensionMethods;
using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service.ExtensionMethods
{
    /// <summary>
    /// Extension methods for the Facebook HttpClient
    /// </summary>
    /// 

    public static class FacebookHttpClientExtensionMethods
    {
        /// <summary>
        /// Get method to have content already desarialized.
        /// </summary>
        /// <typeparam name="T">The return type for the response content.</typeparam>
        /// <param name="client">The source Facebook HttpClient.</param>
        /// <param name="endpoint">The endpoint to request on the Facebook graph API.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="args">The arguments to pass to the request to the Facebook graph API.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// 

        public static async Task<FacebookHttpResponseMessage<T>> GetContentAsync<T>(this FacebookHttpClient client, string endpoint, string accessToken = null, IDictionary<string, string> args = null)
        {
            var response = await client.GetAsync(endpoint, accessToken, args, HttpCompletionOption.ResponseContentRead);
            return new FacebookHttpResponseMessage<T>(response);
        }
    }
}
