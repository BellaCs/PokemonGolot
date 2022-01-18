namespace apiREST.Model
{
    public class LoginOut
    {
        public string token { get; set; }

        public LoginOut(string token) 
        {
            this.token = token;
        }
    }
}
