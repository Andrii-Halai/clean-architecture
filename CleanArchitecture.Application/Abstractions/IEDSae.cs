namespace CleanArchitecture.Application.Abstractions;

public interface IEDSae
{
    public string EStringAE(string plainText, string sharedSecret);
    public string DStringAE(string cipherText, string sharedSecret);
}