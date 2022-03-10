using apiREST.Model;

namespace ExtensionMethods
{
    public static class MyExtensions
    {


        /// <summary>
        /// List user extension that convert a list of users to simple user class
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<SimpleUserData> toSimpleResponseListUserData(this List<User> users)
        {
            List<SimpleUserData> response = new List<SimpleUserData>();

            foreach (User admin in users)
            {
                response.Add(admin.toSimpleResponseUserData());
            }

            return response;
        }


        /// <summary>
        /// Custom user extension that converts a user object to simple data response user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static SimpleUserData toSimpleResponseUserData(this User user)
        {
            SimpleUserData response = new SimpleUserData();

            response.name = user.name;
            response.email = user.email;
            response.user_name = user.user_name;

            return response;
        }
    }
}
