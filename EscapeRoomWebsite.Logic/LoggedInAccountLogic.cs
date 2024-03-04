using EscapeRoomWebsiteData;

namespace EscapeRoomWebsite.Logic
{
    public class LoggedInAccountLogic
    {
        List<AccountModel> accounts = Repository.Accounts;
        AccountModel? currentAccount = Repository.LoggedInAccount;
        public bool CheckLoginAttempt(string username, string password)
        {
            switch (username)
            {
                case "":
                    Console.WriteLine("Username missing");
                    return false;
                case "Rick95":
                    if (password.Equals("Start04-24"))
                        return true;
                    else
                        Console.WriteLine("Wrong Password");
                    return false;
                case "dSt56FSmp13":
                    if (password.Equals("#tte34&GFaDbju23Bd?!dim"))
                        return true;
                    else
                        Console.WriteLine("Wrong Password");
                    return false;
                default:
                    Console.WriteLine("User does not exist");
                    return false;
            }
        }
        public void Login(string username, string password)
        {
            if (CheckLoginAttempt(username, password))
            {
                currentAccount = accounts.First(a => a.Username.Equals(username));
            }
            else
                Console.WriteLine("Login attempt failed");
        }
        public void Logout()
        {
            currentAccount = null;
        }
        public bool CheckClerance(string pageToAccess)//Make it impossible to reach logged in pages trough UI but cause exception with hint if you try to access them in other ways
        {
            switch (pageToAccess)
            {
                case "ForEmployees":
                    if (currentAccount.Role.Equals("Employee"))
                        return true;
                    else
                        Console.WriteLine("Insufficient clearence");
                    return false;
                case "Admin":
                    if (currentAccount.Role.Equals("Admin"))
                        return true;
                    else
                        Console.WriteLine("Insufficient clearence");
                    return false;
                default:
                    //Page doesn't exist Exception?
                    return false;
            }
        }
        public AccountModel? GetLoggedIn()
        {
            return currentAccount;
        }
    }
}
