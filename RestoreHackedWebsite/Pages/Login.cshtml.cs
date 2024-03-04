using EscapeRoomWebsite.Logic;
using EscapeRoomWebsiteData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RestoreHackedWebsite.Pages
{
    public class LoginModel : PageModel
    {
        public LoggedInAccountLogic AccountLogic { get; set; } = new();
        public AccountModel? Account { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
            //Should have links to employee page or admin page if logged in correctly
            //Those pages should have checks to see if you really are logged in. Could show hints if you try typing in the url and get an exception
            //When logged in should change log in link to view clearence page and log out.
            Account = AccountLogic.GetLoggedIn();
        }
        public void OnPostLogin()
        {
            AccountLogic.Login(Username, Password);
            Account = AccountLogic.GetLoggedIn();
        }
    }
}
