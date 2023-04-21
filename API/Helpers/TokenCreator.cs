using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Helpers
{
    public class TokenCreator
    {
        private static readonly IConfiguration configuration;
        static TokenCreator()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = config.Build();
        }

        public static string Generate(ClaimsIdentity claimsIdentity, DateTime expiresAt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = configuration.GetSection("TokenValidation").GetValue<string>("Issuer")!,
                Audience = configuration.GetSection("TokenValidation").GetValue<string>("Audience")!,
                Subject = claimsIdentity,
                Expires = expiresAt,
                SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configuration.GetSection("TokenValidation").GetValue<string>("SecretKey")!)),
                    SecurityAlgorithms.HmacSha512Signature
                )
            };

            return tokenHandler.WriteToken(tokenHandler.CreateToken(securityTokenDescriptor));
        }
    }
}
