using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service
{
    /// <summary>
    /// The Central service for the graph API interface.
    /// </summary>
    /// 

    public interface IFacebookService
    {
        /// <summary>
        /// Get the application token.
        /// </summary>
        /// <returns>Returns the application token object.</returns>
        /// 

        Task<Token> GetApplicationTokenAsync();
    }
}
