using Facebook.NetCore.Client;
using Facebook.NetCore.Service.Enums;
using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service
{
    public class FacebookService : IFacebookService
    {
        private readonly IFacebookHttpClient _client = new FacebookHttpClient("v6.0");

        private readonly string _appId;

        private readonly string _secretId;

        private Token _applicationToken = null;

        public FacebookService(string appId, string secretId)
        {
            _appId = appId;
            _secretId = secretId;
        }

        public async Task<Token> GetApplicationTokenAsync()
        {
            if(_applicationToken is null || (_applicationToken.Expiration.HasValue && DateTime.Now > _applicationToken.Expiration.Value))
            {
                var applicationToken = await _client.GetRawContentAsync<ApplicationToken>("oauth/access_token", new Dictionary<string, string>
                {
                    {"client_id", _appId },
                    {"client_secret", _secretId },
                    {"grant_type", "client_credentials" }
                });

                if(applicationToken is null)
                {
                    throw new ArgumentException("Request failed to return access token. App id and secret could be false.");
                }

                _applicationToken = new Token
                {
                    Value = applicationToken.AccessToken,
                    Type = TokenType.Application,
                    Expiration = null
                };
            }

            return _applicationToken;
        }
    }
}
