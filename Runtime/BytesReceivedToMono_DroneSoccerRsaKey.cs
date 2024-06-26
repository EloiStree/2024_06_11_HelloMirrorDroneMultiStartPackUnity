using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class BytesReceivedToMono_DroneSoccerRsaKey : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 11 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 11 };
    }



    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 11)
        {
            byte b = bytes[0];
            int j = 0;
            for (int i = 1; i < bytes.Length; i += 128)
            {
                j++;

                byte [] rsaBytes = new byte[128];
                Buffer.BlockCopy(bytes, i, rsaBytes, 0, 128);
                RSA rsa = ConvertPKCS1PublicKey(rsaBytes);
                
                if (j > m_rsaString.Count)
                {
                    m_rsaString.Add(rsa.ToXmlString(false));
                }
                else
                {
                    m_rsaString[j-1] = rsa.ToXmlString(false);
                }

            }
        }
    }

    public static RSA ConvertPKCS1PublicKey(byte[] modulus)
    {
        // Create an RSA object
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        try
        {
            // Hard-code the common exponent value 65537 (0x10001)
            byte[] exponent = { 0x01, 0x00, 0x01 }; // Representing 65537 in big-endian byte order

            // Create a RSAParameters object and initialize it with the modulus and exponent
            RSAParameters rsaKeyInfo = new RSAParameters
            {
                Modulus = modulus,
                Exponent = exponent
            };

            // Import the public key
            rsa.ImportParameters(rsaKeyInfo);

            return rsa;
        }
        catch
        {
            rsa.Dispose();
            throw;
        }
    }
    public List<string> m_rsaString = new List<string>();

}
