namespace EscapeRoomWebsiteData
{
    public class AccountModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public void Clear() //Might need it when logging out
        {
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }
    }

}
