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

    public interface IPageService
    {
        /// <summary>
        /// Get the pages where user has a role.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userAccessToken">The user access token.</param>
        /// <returns>Returns a list of pages where the user has a role.</returns>
        /// 

        Task<List<Page>> GetUserPagesAsync(string userId, string userAccessToken);

        /// <summary>
        /// Get insights for a specific page.
        /// </summary>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <param name="metrics">The metrics to request.</param>
        /// <param name="period">The period to request.</param>
        /// <returns>Returns the list of page insights.</returns>
        /// 

        Task<List<Metric>> GetPageInsightsAsync(
            string pageId,
            string pageAccessToken,
            string metrics,
            string period);


        /// <summary>
        /// Get published post for a specific page.
        /// </summary>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <param name="metrics">The metrics to request.</param>
        /// <param name="period">The period to request.</param>
        /// <returns>Returns the list of page insights.</returns>
        /// 

        Task<List<Post>> GetPagePublishedPostAsync(
            string pageId,
            string pageAccessToken,
            DateTime? startDateTime = null,
            DateTime? endDateTime = null);

        /// <summary>
        /// Get information about a specific page.
        /// </summary>
        /// <param name="fields">The information fields to request.</param>
        /// <param name="pageId">The page id.</param>
        /// <param name="pageAccessToken">The page access token.</param>
        /// <returns>Returns the page informations</returns>
        /// 

        Task<PageInformations> GetPageInformationAsync(
        string fields,
        string pageId,
        string pageAccessToken);
    }
}
