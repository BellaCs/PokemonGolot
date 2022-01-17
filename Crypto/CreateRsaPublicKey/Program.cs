using System.Security.Cryptography;

namespace CreateRsaPublicKey 
{ 
    public class Program 
    {
        public static void Main(string[] args) 
        {
            RSA asymmetryckey = RSA.Create();
            // Directory.CreateDirectory("/PublicKey");
            StreamWriter sw = new StreamWriter("F:\\PokemonGolotPublicKey\\PublicKeyFile", false);
            sw.Write(asymmetryckey.ToXmlString(false));
            sw.Close();
        } 
    }
}