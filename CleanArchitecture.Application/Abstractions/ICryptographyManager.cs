using System.Text;

namespace CleanArchitecture.Application.Abstractions;

public interface ICryptographyManager
{
    public string Crypt(string plainText);

    public string EnCrypt(string cipherText);

    public string ConvertStringToHex(string input, Encoding encoding);

    public string ConvertHexToString(String hexInput, System.Text.Encoding encoding);
}