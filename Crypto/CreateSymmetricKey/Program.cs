using System.Security.Cryptography;

namespace CreateSymmetricKey 
{
    public class CreateSymmetricKey 
    {
        public static void Main() 
        {
            Aes myAes = Aes.Create();

            RSACryptoServiceProvider rsa = PublicKeyImport();

            EncryptSymmetricKey(rsa, myAes);


         }

        private static RSACryptoServiceProvider PublicKeyImport()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            try
            {
                //Set reader on Public key file
                StreamReader sr = new StreamReader("F:\\PokemonGolotPublicKey\\PublicKeyFile");

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

        private static void EncryptSymmetricKey(RSACryptoServiceProvider PublicAsymmetricKey, Aes aes)
        {

            // Use RSACryptoServiceProvider to encrypt the AES key.
            byte[] keyEncrypted = PublicAsymmetricKey.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            using (FileStream outFs = new FileStream("F:\\PokemonGolotPublicKey\\SymmetricKey", FileMode.Create))
            {

                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                outFs.Close();
            }

        }
    }



}
