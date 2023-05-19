using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BusinessLayer;

public class AuthOptions
{
    public const string Issuer = "TreeExample";
    public const string Audience = "TreeExample";
    const string Key = "mysupersecret_secretkey!123";
    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
}