namespace CashFlow.Domain.Security.Cryptograph;
public interface IPasswordEncripter
{
    string Encrypt(string password);
}
