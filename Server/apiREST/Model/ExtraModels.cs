namespace apiREST.Model
{
    public class LoginResponse
    {
        public string token { get; set; }
        public ResponsePlayer user { get; set; }

        public LoginResponse(string token, ResponsePlayer player) 
        {
            this.token = token;
            this.user = player;
        }
    }
}
