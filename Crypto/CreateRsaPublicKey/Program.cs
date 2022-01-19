using System.Security.Cryptography;

namespace CreateRsaPublicKey 
{ 
    public class Program 
    {
        public static void Main(string[] args) 
        {
            RSA asymmetryckey = RSA.Create();
            // Directory.CreateDirectory("/PublicKey");
            StreamWriter sw = new StreamWriter("C:\\Users\\Marc\\Desktop\\Portfolio\\PokemonGolot\\CryptoKeys\\PublicKeyFile");
            sw.Write(asymmetryckey.ToXmlString(false));
            sw.Close();
        } 
    }
}