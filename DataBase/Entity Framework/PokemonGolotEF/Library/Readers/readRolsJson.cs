using System;
using System.IO;

namespace PokemonGolotEF.Library.Readers
{
    public class readRolsJson
    {
        public static String readRolsData()
        {
            String file = ".\\Library\\Json\\JsonRol.json";
            String data = "";

            using (StreamReader r = new StreamReader(file))
            {
                data = r.ReadToEnd();
            }

            return data;
        }
    }
}
