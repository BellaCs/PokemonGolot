using apiREST.Model;
using apiREST.Logic;

namespace apiREST.Logic
{
    public class registerLogic
    {

        encryptLogic _enctypt;

        public registerLogic() 
        {
            _enctypt = new encryptLogic();
        }

        public Player publicRegister(PlayerRegister newPlayer) 
        {
            Player  newFullPlayer = new();

            //newFullPlayer.user_name = _enctypt.EncryptUser(newPlayer.user_name!);
            newFullPlayer.user_name = newPlayer.user_name;
            newFullPlayer.email = newPlayer.email;
            newFullPlayer.name = newPlayer.name;
            newFullPlayer.password = _enctypt.CreatePasswordHash(newPlayer.password!);
            newFullPlayer.gender = newPlayer.gender;
            newFullPlayer.birth_date = newPlayer.birth_date;
            newFullPlayer.rol = "Player";

            return newFullPlayer;
        }

        public void privateRegister(Player newPlayer)
        {

        }
    }
}
