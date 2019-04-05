using VisibleSCM.Contract.V1;

namespace VisibleSCM.Test
{
    public class BaseTests
    {
        public string Username = "VisibleTest";
        public string Password = "Visible123";
        public string SecurityToken;

        public LoginRequest GetLoginRequest()
        {
            return new LoginRequest()
            {
                UserName = Username,
                Password = Password,
            };
        }
    }
}
