using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class JWTContainerModel
    {
        #region public Metohds
        public int ExpireMinutes { get; set; }
        public string SecretKey { get; set; } = "mykey";
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims{ get; set; }
        #endregion
    }
}
