using Facebook.NetCore.Client;
using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service.Services.PageService
{
    public class PageService : IPageService
    {
        private readonly IFacebookService _facebookService;
        private readonly IFacebookHttpClient _facebookHttpClient;

        public PageService(
            IFacebookService facebookService,
            IFacebookHttpClient facebookHttpClient)
        {
            _facebookService = facebookService;
            _facebookHttpClient = facebookHttpClient;
        }

        public async Task<List<Page>> GetUserPagesAsync(string userId, string userAccessToken)
        {
            if(string.IsNullOrWhiteSpace(userId)) { throw new ArgumentNullException(nameof(userId)); }
            if(string.IsNullOrWhiteSpace(userAccessToken)) { throw new ArgumentNullException(nameof(userAccessToken)); }

            var response = await _facebookHttpClient.GetContentAsync<Content<Page>>(
                userAccessToken,
                string.Format("{0}/accounts",
                userId));

            return response.Content.Data;
        }

        public async Task<List<Metric>> GetPageInsights(
            string pageId,
            string pageAccessToken,
            string metrics,
            string period)
        {
            if (string.IsNullOrWhiteSpace(pageId)) { throw new ArgumentNullException(nameof(pageId)); }
            if (string.IsNullOrWhiteSpace(pageAccessToken)) { throw new ArgumentNullException(nameof(pageAccessToken)); }
            if (string.IsNullOrWhiteSpace(metrics)) { throw new ArgumentNullException(nameof(metrics)); }
            if (string.IsNullOrWhiteSpace(period)) { throw new ArgumentNullException(nameof(period)); }

            IDictionary<string, string> args = new Dictionary<string, string>
            {
                { "metric", metrics },
                { "period", period }
            };

            var response = await _facebookHttpClient.GetContentAsync<Content<Metric>>(
                pageAccessToken,
                string.Format("{0}/insights",
                pageId),
                args);

            return response.Content.Data;
        }
    }
}
