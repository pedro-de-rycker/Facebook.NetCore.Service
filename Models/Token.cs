using Facebook.NetCore.Service.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.NetCore.Service.Models
{
    public class Token
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
