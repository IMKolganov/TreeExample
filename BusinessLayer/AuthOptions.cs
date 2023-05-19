using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace YakimGames.BackOffice.Server.Business;

public class AuthOptions
{
    public const string Issuer = "YakimGames.BackOffice";
    public const string Audience = "YakimGames.BackOffice";
    const string Key = "mysupersecret_secretkey!123";
    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
}