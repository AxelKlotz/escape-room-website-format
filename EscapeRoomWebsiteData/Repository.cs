namespace EscapeRoomWebsiteData
{
    public class Repository
    {
        public static List<AccountModel> Accounts = new List<AccountModel>
        {
            new AccountModel { Role="Employee", Username="Rick95", Password="Start04-24"}, //Hint at what username and password could be
            new AccountModel { Role="Admin", Username="dSt56FSmp13", Password="#tte34&GFaDbju23Bd?!dim"}
        };
        public static AccountModel? LoggedInAccount = null;


        public static List<InfoModel> HomepageInfo = new List<InfoModel>
        {
            new InfoModel { Title="Over 100 websites made", ImageUrl="Images/Info1.png", InfoText="Ajax website designs have helped in the creation and design of over 100 successfull websites"}
        };
    }
}
