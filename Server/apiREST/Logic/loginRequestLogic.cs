using apiREST.Data;
using apiREST.Model;

namespace apiREST.Logic
{
    public class loginLogic
    {
        private readonly pokemonGolotApi _context;

        public loginLogic(pokemonGolotApi context)
        {
            _context = context;
        }

        public async Task<Player?> userExist(PlayerLogin play)
        {
            Player? player = await _context.Player.FindAsync(play.user_name);

            if (player == null)
            {
                player = await _context.Player.FindAsync(play.email);

                if(player == null)
                {
                    return null;
                }
                
            }

            return player;
        }
    }
   
}
