using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace TripleDESTest
{
    class TripleDESTest
    {
        static void Main(string[] args)
        {
            string myData = "This is a test.";
            string myKey = "5137153cc611227c000bbd1bd8cd200";//Development Env Key.
            string encrypted = EncryptTDES(myData, myKey);
            Console.Write("Encrypted string = ");
            Console.WriteLine(encrypted);
            //Target: oHX1DB5B0rvn6mlr9T7pkg==

            string s = DecryptTDES(encrypted, myKey);
            Console.Write("Decrypted string = ");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static string EncryptTDES(string value, string decryptionKey)
        {
            TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
            string result = null;
            try
            {
                byte[] encryptdata = Encoding.UTF8.GetBytes(value);

                tDESalg.Mode = CipherMode.ECB;
                tDESalg.Padding = PaddingMode.PKCS7;//According to MS, same as PKCS5PADDING

                byte[] hash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(decryptionKey));
                byte[] Key = new byte[tDESalg.KeySize / 8];
                Array.Copy(hash, Key, hash.Length < Key.Length ? hash.Length : Key.Length); //The size of the Key property must be the same as the KeySize property divided by 8

                tDESalg.Key = Key;
                ICryptoTransform cryptoTransform = tDESalg.CreateEncryptor();

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptdata, 0, encryptdata.Length);
                        cryptoStream.FlushFinalBlock();
                        result = Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message + e.StackTrace);
                return null;
            }
            return result;
        }

        public static string DecryptTDES(string value, string decryptionKey)
        {
            string decryptString = "";
            TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
            try
            {
                byte[] decodedData = Convert.FromBase64String(value);
                tDESalg.Mode = CipherMode.ECB;
                tDESalg.Padding = PaddingMode.PKCS7;//According to MS, same as PKCS5PADDING

                byte[] hash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(decryptionKey));
                byte[] Key = new byte[tDESalg.KeySize / 8]; //The size of the Key property must be the same as the KeySize property divided by 8
                Array.Copy(hash, Key, hash.Length < Key.Length ? hash.Length : Key.Length);

                tDESalg.Key = Key;
                ICryptoTransform cryptoTransform = tDESalg.CreateDecryptor();

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(decodedData, 0, decodedData.Length);
                        cryptoStream.FlushFinalBlock();
                        decryptString = Encoding.UTF8.GetString(memoryStream.ToArray());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message + e.StackTrace);
                return null;
            }

            return decryptString;
        }

    }
}
