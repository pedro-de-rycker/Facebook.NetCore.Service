using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service.Services.PageService
{
    public interface IPageService
    {
        Task<List<Page>> GetUserPagesAsync(string userId, string userAccessToken);

        Task<List<Metric>> GetPageInsights(
            string pageId,
            string pageAccessToken,
            string metrics,
            string period);
    }
}
