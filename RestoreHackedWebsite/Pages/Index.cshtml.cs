using EscapeRoomWebsite.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RestoreHackedWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HomepageLogic HomeLogic { get; set; } = new HomepageLogic();
        public int startCheck { get; set; } //Javascript can't take bool. 0 = false and 1 = true
        public int cookieCheck { get; set; }
        [BindProperty]
        public string CookiePassword { get; set; }
        public bool FailedCookie { get; set; } = false;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            startCheck = HomeLogic.CheckStartPuzzle();
            cookieCheck = HomeLogic.CheckCookiePuzzle();
        }
        public void OnPostStart()
        {
            HomeLogic.SolveStartPuzzle();
            cookieCheck = HomeLogic.CheckCookiePuzzle();
            startCheck = HomeLogic.CheckStartPuzzle();
        }
        public void OnPostSolveCookie() //ToDo: Visually connect links to cookies
        { //Clear cache before letting someone test
            if (CookiePassword.Equals("StringByteURLAPIMenuEncrypted"))
            {
                HomeLogic.SolveCookiePuzzle();
                FailedCookie = false;
            }
            else
            {
                //show wrong pass message
                FailedCookie = true;
            }
            startCheck = HomeLogic.CheckStartPuzzle();
            cookieCheck = HomeLogic.CheckCookiePuzzle();
        }
    }
}
