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

        public List<ResponseAdminUserToList> toAdminResponseList(List<User> users) 
        {
            List<ResponseAdminUserToList> responseAdminsUserToList = new();

            foreach (User user in users)
            {
                responseAdminsUserToList.Add(toAdminResponseList(user));
            }

            return responseAdminsUserToList;
        }

        public ResponseAdminUserToList toAdminResponseList(User user) 
        {
            ResponseAdminUserToList response = new ResponseAdminUserToList();

            response.user_name = user.user_name;
            response.name = user.name;
            response.email = user.email;

            return response;
        }

    }
}
