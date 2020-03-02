using Facebook.NetCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.NetCore.Service
{
    public interface IFacebookService
    {
        Task<Token> GetApplicationTokenAsync();
    }
}
