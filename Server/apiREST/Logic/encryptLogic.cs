using System.Security.Cryptography;
using System.Text;

namespace apiREST.Logic
{
    public class encryptLogic
    {

        Aes aes = Aes.Create();

        public string CreatePasswordHash(String password)
        {
            UnicodeEncoding ue = new UnicodeEncoding();

            RSACryptoServiceProvider rsa = AsymmetricKeyImport("F:\\PokemonGolotPublicKey\\AssymetricKeyFile");

            byte[] messageBytes = ue.GetBytes(password);

            RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);

            rsaFormatter.SetHashAlgorithm("SHA256");

            return Encoding.Default.GetString(rsaFormatter.CreateSignature(messageBytes));
        }

        public string EncryptUser(string userName)
        {
            string symmetricKeyFile = "F:\\PokemonGolotPublicKey\\SymmetricKey";
            string asymmetricKeyFile = "F:\\PokemonGolotPublicKey\\AssymetricKeyFile";

            //string key = DecryptSymmetricKey(symmetricKeyFile, AsymmetricKeyImport(asymmetricKeyFile));

            return EncryptStringToBytes_Aes(userName, aes.Key, aes.IV);
        }

        public string DecryptUser(string userName)
        {
            string symmetricKeyFile = "F:\\PokemonGolotPublicKey\\SymmetricKey";
            string asymmetricKeyFile = "F:\\PokemonGolotPublicKey\\AssymetricKeyFile";

            //string key = DecryptSymmetricKey(symmetricKeyFile, AsymmetricKeyImport(asymmetricKeyFile));
            
            string key = Encoding.Default.GetString(aes.Key);
            return DecryptString(key, userName);
        }

        private static string DecryptSymmetricKey(string inFile, RSACryptoServiceProvider rsa)
        {

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];


            using (FileStream inFs = new FileStream(inFile, FileMode.Open))
            {

                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

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

                inFs.Close();

                return Encoding.Default.GetString(KeyDecrypted);
            }
        }

        private static RSACryptoServiceProvider AsymmetricKeyImport(string keyFilePath)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            try
            {
                //Set reader on Public key file
                StreamReader sr = new StreamReader(keyFilePath);
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

        static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

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
            }

            // Return the encrypted bytes from the memory stream.
            return Encoding.Default.GetString(encrypted);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

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
}
