using Facebook.NetCore.Service.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.NetCore.Service.Models
{
    /// <summary>
    /// The token class
    /// </summary>
    /// 

    public class Token
    {
        /// <summary>
        /// Token type
        /// </summary>
        /// 

        public TokenType Type { get; set; }

        /// <summary>
        /// The token value. The token itself.
        /// </summary>
        /// 

        public string Value { get; set; }

        /// <summary>
        /// The token expiration date. Can be null.
        /// </summary>
        /// 

        public DateTime? Expiration { get; set; }
    }
}
