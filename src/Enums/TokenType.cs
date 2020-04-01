using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.NetCore.Service.Enums
{
    /// <summary>
    /// Token type of the Facebook graph API
    /// </summary>
    /// 

    public enum TokenType
    {
        /// <summary>
        /// Application token
        /// </summary>
        Application,
        /// <summary>
        /// User token
        /// </summary>
        User,
        /// <summary>
        /// Page token
        /// </summary>
        Page
    }
}
