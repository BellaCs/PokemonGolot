using apiREST.Model;

namespace apiREST.Logic
{
    public class playerLogic
    {

        encryptLogic _enctypt;

        public playerLogic()
        {
            _enctypt = new encryptLogic();
        }

        public ResponsePlayer toDecryptedPlayer(Player player) 
        {
            ResponsePlayer decryptedPlayer = new ResponsePlayer();

            //decryptedPlayer.user_name = _enctypt.DecryptUser(player.user_name!);
            decryptedPlayer.user_name = player.user_name;
            decryptedPlayer.rol = player.rol;
            decryptedPlayer.email = player.email;
            decryptedPlayer.birth_date = player.birth_date;
            decryptedPlayer.gender = player.gender;
            decryptedPlayer.name = player.name;

            return decryptedPlayer;
        }

    }
}
