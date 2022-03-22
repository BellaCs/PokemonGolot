namespace apiREST.Model
{
    public class LoginResponse
    {
        public string token { get; set; }
        public ResponseUser user { get; set; }

        public LoginResponse(string token, ResponseUser player) 
        {
            this.token = token;
            this.user = player;
        }
    }
}
