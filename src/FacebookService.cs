using Facebook.NetCore.HttpClient;
using Facebook.NetCore.Service.Enums;
using Facebook.NetCore.Service.ExtensionMethods;
using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service
{
    /// <summary>
    /// The Central service for the graph API.
    /// </summary>
    /// 

    public class FacebookService : IFacebookService
    {
        private readonly FacebookHttpClient _client = new FacebookHttpClient("v6.0");

        private readonly string _appId;

        private readonly string _secretId;

        private Token _applicationToken = null;

        /// <summary>
        /// The constructor for the central service of the Facebook graph API.
        /// </summary>
        /// <param name="appId">Your application Id.</param>
        /// <param name="secretId">Your application secret.</param>
        /// 

        public FacebookService(string appId, string secretId)
        {
            _appId = appId;
            _secretId = secretId;
        }

        /// <summary>
        /// Get the application token.
        /// </summary>
        /// <returns>Returns the application token object.</returns>
        /// 

        public async Task<Token> GetApplicationTokenAsync()
        {
            if(_applicationToken is null || (_applicationToken.Expiration.HasValue && DateTime.Now > _applicationToken.Expiration.Value))
            {
                var response = await _client.GetContentAsync<ApplicationToken>("oauth/access_token", args: new Dictionary<string, string>
                {
                    {"client_id", _appId },
                    {"client_secret", _secretId },
                    {"grant_type", "client_credentials" }
                });

                if(response.IsSuccessStatusCode && string.IsNullOrWhiteSpace(response.Content.AccessToken))
                {
                    _applicationToken = new Token
                    {
                        Value = response.Content.AccessToken,
                        Type = TokenType.Application,
                        Expiration = null
                    };
                }
                else
                { 
                    throw new ArgumentException("Request failed to return access token. App id and secret could be false.");
                }
            }

            return _applicationToken;
        }
    }
}
