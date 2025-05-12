using CashFlow.Domain.Security.Cryptograph;
using BC = BCrypt.Net.BCrypt;

namespace CashFlow.Infrastructure.Security;
internal class BCrypt : IPasswordEncripter
{
    public string Encrypt(string password)
    {
        string PasswordHash = BC.HashPassword(password);

        return PasswordHash;
    }
}
