using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PGDekho.com.ServiceFolder
{
    public class JWTServices
    {
        private readonly IConfiguration _config;

        public string SecretKey { get; set; }

        public int TokenDuration { get; set; }
        public JWTServices(IConfiguration config)
        {
            _config = config;
            this.SecretKey = _config.GetSection("jwtConfig").GetSection("Key").Value;
            this.TokenDuration = Int32.Parse(_config.GetSection("jwtConfig").GetSection("duration").Value);
        }

        public String GenerateToken(String UserId,String FirstName,String LastName, String Email,String City,String PropertyOwner)
        {

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecretKey));
            var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var payload = new[]
            {
              new Claim("UserId",UserId),
              new Claim("FirstName",FirstName),   
              new Claim("LastName",LastName),
              new Claim("Email",Email),
              new Claim("City",City),
              new Claim("PropertyOwner",PropertyOwner)
            };

            var jwtToken = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: payload,
                expires: DateTime.Now.AddMinutes(TokenDuration),
                signingCredentials: signature
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);   
        }
    }
}
