using apiREST.Data;
using apiREST.Model;
using apiREST.Logic;

namespace apiREST.Logic
{
    public class loginLogic
    {
        private readonly pokemonGolotApi _context;
        private readonly encryptLogic _encryptLogic;

        public loginLogic(pokemonGolotApi context)
        {
            _context = context;
            _encryptLogic = new encryptLogic();
        }

        public async Task<User?> UserExist(UserLogin? loginInfo)
        {
            if (loginInfo == null)
                return null;

            //Player? player = await _context.Player.FindAsync(_encryptLogic.EncryptUser(loginInfo!.user_name!));
            User? player = await _context.User.FindAsync(loginInfo!.user_name!.ToLower());

            if (player == null)
            {               
                return null;                
            } 
            else if (player.password != _encryptLogic.CreatePasswordHash(loginInfo.password!))
            //else if (player.password != loginInfo.password!)
            {
               return null;
            }

            return player;
        }

        
    }
   
}
