using System.Security.Cryptography;
using System.Text;

namespace apiREST.Logic
{
    public class encryptLogic
    {

        public string CreatePasswordHash(String password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public string EncryptUser(string userName)
        {
            string symmetricKeyFile = "C:\\Users\\Marc\\Desktop\\Portfolio\\PokemonGolot\\CryptoKeys\\SymmetricKey";
            string asymmetricKeyFile = "C:\\Users\\Marc\\Desktop\\Portfolio\\PokemonGolot\\CryptoKeys\\AssymetricKeyFile";

            

            return EncryptStringToBytes_Aes(userName, DecryptSymmetricKey(symmetricKeyFile, AsymmetricKeyImport(asymmetricKeyFile), Aes.Create()));
        }

        public string DecryptUser(string userName)
        {
            string symmetricKeyFile = "C:\\Users\\Marc\\Desktop\\Portfolio\\PokemonGolot\\CryptoKeys\\SymmetricKey";
            string asymmetricKeyFile = "C:\\Users\\Marc\\Desktop\\Portfolio\\PokemonGolot\\CryptoKeys\\AssymetricKeyFile";

            
            
            //string key = Encoding.Default.GetString(aes.Key);
            return DecryptString(DecryptSymmetricKey(symmetricKeyFile, AsymmetricKeyImport(asymmetricKeyFile), Aes.Create()), userName);
        }

        private static ICryptoTransform DecryptSymmetricKey(string inFile, RSACryptoServiceProvider rsa, Aes aes)
        {

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];


            using (FileStream inFs = new FileStream(inFile, FileMode.Open))
            {

                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 4);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 4);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).s
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);



                inFs.Close();

                return transform;
            }
        }

        private static RSACryptoServiceProvider AsymmetricKeyImport(string keyFilePath)
        {
            RSACryptoServiceProvider rsa = new();
            try
            {
                //Set reader on Public key file
                StreamReader sr = new(keyFilePath);
                // Create, initializate and set key on RSACryptoServiceProvider instance
                string keytxt = sr.ReadToEnd();
                rsa.FromXmlString(keytxt);
                sr.Close();
                return rsa;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error on Public key import: {e}");
                return rsa;

            }
        }

        static string EncryptStringToBytes_Aes(string plainText, ICryptoTransform encryptor)
        {
            byte[] encrypted;
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            // Return the encrypted bytes from the memory stream.
            return Encoding.Default.GetString(encrypted);
        }

        public static string DecryptString(ICryptoTransform decryptor, string cipherText)
        {
           byte[] buffer = Convert.FromBase64String(cipherText);        

           using (MemoryStream memoryStream = new MemoryStream(buffer))
           {
               using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
               {
                  using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                  {
                     return streamReader.ReadToEnd();
                  }
               }
           }
            
        }
    }
}
