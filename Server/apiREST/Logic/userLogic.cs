using apiREST.Model;

namespace apiREST.Logic
{
    public class userLogic
    {

        encryptLogic _enctypt;

        public userLogic()
        {
            _enctypt = new encryptLogic();
        }

        public ResponseUser toDecryptedUser(User player) 
        {
            ResponseUser decryptedUser = new ResponseUser();

            //decryptedPlayer.user_name = _enctypt.DecryptUser(player.user_name!);
            decryptedUser.User_name = player.user_name;
            decryptedUser.Email = player.email;
            decryptedUser.Birth_date = player.birth_date;
            decryptedUser.Gender = player.gender;
            decryptedUser.Name = player.name;

            return decryptedUser;
        }

    }
}
