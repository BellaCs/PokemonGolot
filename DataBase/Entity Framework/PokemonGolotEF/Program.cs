using System;
using PokemonGolotEF.Library.Requests;
using System.Threading.Tasks;


namespace PokemonGolotEF
{
    class Program
    {
       static void Main(string[] args)
        {

           
            getlevel().Wait();

        }

        static async Task getlevel()
        {
            Console.WriteLine(); 
        }
    }
}
