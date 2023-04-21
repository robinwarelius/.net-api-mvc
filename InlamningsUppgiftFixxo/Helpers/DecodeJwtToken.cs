using System.IdentityModel.Tokens.Jwt;

namespace InlamningsUppgiftFixxo.Helpers
{
    public static class DecodeJwtToken
    {       
        public static bool GetUserRole(string token)
        {          
            var decodedToken = new JwtSecurityToken(jwtEncodedString: token);
            var userRole = decodedToken.Claims.First(claim => claim.Type == "role").Value;

            if (userRole.ToLower() == "admin" || userRole.ToLower() == "productmanager")
            {
                return true;
            }

            return false;
        }
    }
}
