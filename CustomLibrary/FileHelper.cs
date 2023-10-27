using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
	public static class FileHelper
	{
		public static string Encrypt(string input,string salt)
		{
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(salt);
				aesAlg.IV = new byte[16];

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(input);
						}
					}
					return Convert.ToBase64String(msEncrypt.ToArray());
				}
			}
		}
		public static string Decrypt(string encryptedInput, string salt)
		{
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(salt);
				aesAlg.IV = new byte[16];

				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedInput)))
				{
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							return srDecrypt.ReadToEnd();
						}
					}
				}
			}
		}
	}
}
