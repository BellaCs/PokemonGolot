using System.Security.Cryptography;

namespace CreateRsaPrivateKey
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RSA asymmetryckey = RSA.Create();
            // Directory.CreateDirectory("/PublicKey");
            StreamWriter sw = new StreamWriter("F:\\PokemonGolotPublicKey\\AssymetricKeyFile", false);
            sw.Write(asymmetryckey.ToXmlString(true));
            sw.Close();
        }
    }
}