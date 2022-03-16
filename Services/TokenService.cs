using BlogAspNet6.Extensions;
using BlogAspNet6.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlogAspNet6.Services;

public class TokenService
{
    public string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
        var claims = user.GetClaims();

        var tokenDescription = new SecurityTokenDescriptor {
            /*
            Subject = new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.Name, ""), //User.Identity.Name
                new Claim(ClaimTypes.Role, ""), //User.IsInRole
            }),
            */
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(8),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescription);
        return tokenHandler.WriteToken(token);
    }
}
