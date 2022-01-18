using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Library.Readers
{
    internal class readPokestopsJson
    {
        public static String readPokestopsData() 
        {
            String file = ".\\Library\\Json\\pokestop.json";
            String data = "";

            using (StreamReader r = new StreamReader(file)) 
            {
                data = r.ReadToEnd();
            }

            return data;
        }
    }
}
