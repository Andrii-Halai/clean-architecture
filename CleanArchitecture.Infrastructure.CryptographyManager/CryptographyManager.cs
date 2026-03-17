using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CleanArchitecture.Application.Abstractions;


namespace CleanArchitecture.Infrastructure.CryptographyManager;

public class CryptographyManager : ICryptographyManager
  {
    private const string sharedSecret = "7F22EC8B";
    private static byte[] _salt = Encoding.ASCII.GetBytes("3B2A45878ABA");

    public string Crypt(string plainText)
    {
      string outStr = null;
      RijndaelManaged aesAlg = null;

      try
      {
        Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

        aesAlg = new RijndaelManaged();
        aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using (MemoryStream msEncrypt = new MemoryStream())
        {
          msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
          msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
          using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
            {
              //Write all data to the stream.
              swEncrypt.Write(plainText);
            }
          }
          outStr = Convert.ToBase64String(msEncrypt.ToArray());
          outStr = ConvertStringToHex(outStr, Encoding.Unicode);
        }
      }
      finally
      {
        if (aesAlg != null)
          aesAlg.Clear();
      }

      return outStr;
    }
    
    public string EnCrypt(string cipherText)
    {
      RijndaelManaged aesAlg = null;
      string plaintext;

      try
      {
        Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

        cipherText = ConvertHexToString(cipherText, Encoding.Unicode);
        byte[] bytes = Convert.FromBase64String(cipherText);
        using (MemoryStream msDecrypt = new MemoryStream(bytes))
        {
          aesAlg = new RijndaelManaged();
          aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
          aesAlg.IV = ReadByteArray(msDecrypt);
          ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
          using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
              plaintext = srDecrypt.ReadToEnd();
          }
        }
      }
      catch (Exception)
      {
        return cipherText;
      }
      finally
      {
        if (aesAlg != null)
          aesAlg.Clear();
      }

      return plaintext;
    }

    public string ConvertStringToHex(string input, Encoding encoding)
    {
      Byte[] stringBytes = encoding.GetBytes(input);
      StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
      foreach (byte b in stringBytes)
      {
        sbBytes.AppendFormat("{0:X2}", b);
      }
      return sbBytes.ToString();
    }

    public string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
    {
      int numberChars = hexInput.Length;
      byte[] bytes = new byte[numberChars / 2];
      for (int i = 0; i < numberChars; i += 2)
      {
        bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
      }
      return encoding.GetString(bytes);
    }

    private byte[] ReadByteArray(Stream s)
    {
      byte[] rawLength = new byte[sizeof(int)];
      if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
        throw new SystemException("Stream did not contain properly formatted byte array");

      try
      {
        byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
        if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
          throw new SystemException("Did not read byte array properly");

        return buffer;
      }
      catch (Exception)
      { }

      return null;
    }
  }