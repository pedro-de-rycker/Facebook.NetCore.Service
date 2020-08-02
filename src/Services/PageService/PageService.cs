using Facebook.NetCore.HttpClient;
using Facebook.NetCore.Service.ExtensionMethods;
using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service.Services.PageService
{
    /// <summary>
    /// The Page service.
    /// </summary>
    /// 

    public class PageService : IPageService
    {
        private readonly IFacebookService _facebookService;
        private readonly FacebookHttpClient _facebookHttpClient;

        /// <summary>
        /// The page service constructor.
        /// </summary>
        /// <param name="facebookService">The required IFacebookService.</param>
        /// <param name="facebookHttpClient">The required FacebookHttpClient.</param>
        /// 

        public PageService(
            IFacebookService facebookService,
            FacebookHttpClient facebookHttpClient)
        {
            _facebookService = facebookService;
            _facebookHttpClient = facebookHttpClient;
        }

        /// <summary>
        /// Get the pages where user has a role.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userAccessToken">The user access token.</param>
        /// <returns>Returns a list of pages where the user has a role.</returns>
        /// 

        public async Task<List<Page>> GetUserPagesAsync(string userId, string userAccessToken)
        {
            if(string.IsNullOrWhiteSpace(userId)) { throw new ArgumentNullException(nameof(userId)); }
            if(string.IsNullOrWhiteSpace(userAccessToken)) { throw new ArgumentNullException(nameof(userAccessToken)); }

            var response = await _facebookHttpClient.GetContentAsync<ListContent<Page>>(
                string.Format("{0}/accounts", userId),
                userAccessToken);

            return response.Content.Data;
        }

        /// <summary>
        /// Get insights for a specific page.
        /// </summary>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <param name="metrics">The metrics to request.</param>
        /// <param name="period">The period to request.</param>
        /// <returns>Returns the list of page insights.</returns>
        /// 

        public async Task<List<Metric>> GetPageInsightsAsync(
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

            var response = await _facebookHttpClient.GetContentAsync<ListContent<Metric>>(
                string.Format("{0}/insights", pageId),
                pageAccessToken,
                args);

            return response.Content.Data;
        }

        /// <summary>
        /// Get published post for a specific page.
        /// </summary>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <param name="metrics">The metrics to request.</param>
        /// <param name="period">The period to request.</param>
        /// <returns>Returns the list of page insights.</returns>
        /// 

        public async Task<List<Post>> GetPagePublishedPostAsync(
            string pageId,
            string pageAccessToken,
            DateTime? startDateTime = null,
            DateTime? endDateTime = null)
        {
            if (string.IsNullOrWhiteSpace(pageId)) { throw new ArgumentNullException(nameof(pageId)); }
            if (string.IsNullOrWhiteSpace(pageAccessToken)) { throw new ArgumentNullException(nameof(pageAccessToken)); }

            IDictionary<string, string> args = new Dictionary<string, string>();

            if(startDateTime != null && startDateTime.HasValue) { args.Add("since", startDateTime.Value.ToString()); }
            if(startDateTime != null && startDateTime.HasValue) { args.Add("until", endDateTime.Value.ToString()); }

            var response = await _facebookHttpClient.GetContentAsync<ListContent<Post>>(
                string.Format("{0}/published_posts", pageId),
                pageAccessToken,
                args);

            return response.Content?.Data;
        }

        /// <summary>
        /// Get information about a specific page.
        /// </summary>
        /// <param name="fields">The information fields to request.</param>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <returns>Returns the page informations</returns>
        /// 

        public async Task<PageInformations> GetPageInformationAsync(
            string fields,
            string pageId,
            string pageAccessToken)
        {
            if (string.IsNullOrWhiteSpace(pageId)) { throw new ArgumentNullException(nameof(pageId)); }
            if (string.IsNullOrWhiteSpace(pageAccessToken)) { throw new ArgumentNullException(nameof(pageAccessToken)); }
            if (string.IsNullOrWhiteSpace(fields)) { throw new ArgumentNullException(nameof(fields)); }

            IDictionary<string, string> args = new Dictionary<string, string>
            {
                { "fields", fields }
            };

            var response = await _facebookHttpClient.GetContentAsync<Content<PageInformations>>(
                string.Format("{0}", pageId),
                pageAccessToken,
                args);

            return response.Content.Data;
        }
    }
}
