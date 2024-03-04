namespace EscapeRoomWebsite.Logic
{
    public class PuzzleLogic
    {
        public bool CheckPuzzle(string puzzle)
        {
            switch (puzzle)
            {
                case "start":
                    if (PuzzleRepo.StartPuzzleSolved)
                        return true;
                    else
                        return false;
                case "cookie":
                    if (PuzzleRepo.CookiePuzzleSolved)
                        return true;
                    else
                        return false;
                case "service":
                    if (PuzzleRepo.ServiceLinkWorks)
                        return true;
                    else
                        return false;
                case "homeinfo":
                    if (PuzzleRepo.HomepageInfoFixed)
                        return true;
                    else
                        return false;
                default:
                    Console.WriteLine("Puzzle not found");
                    return false;
            }
        }
        public void SolvePuzzle(string puzzle)
        {
            switch (puzzle)
            {
                case "start":
                    PuzzleRepo.StartPuzzleSolved = true;
                    break;
                case "cookie":
                    PuzzleRepo.CookiePuzzleSolved = true;
                    break;
                case "service":
                    PuzzleRepo.ServiceLinkWorks = true;
                    break;
                case "homeinfo":
                    PuzzleRepo.HomepageInfoFixed = true;
                    break;
                default:
                    Console.WriteLine("Puzzle not found");
                    break;
            }
        }
        public string[] GetCookiePuzzleWords()
        {
            return PuzzleRepo.CookiePuzzleWords;
        }
    }
    public class PuzzleRepo
    {
        public static bool StartPuzzleSolved { get; set; } = false;
        public static bool CookiePuzzleSolved { get; set; } = false;
        public static bool ServiceLinkWorks { get; set; } = false;
        public static bool HomepageInfoFixed { get; set; } = false;
        public static string[] CookiePuzzleWords { get; set; } = { "Domain", "Server", "URL", "Link", "Firewall", "Encrypted", "String", "Integer", "API", "Data", "HTTP", "Byte", "Web", "Menu", "Default" };
    }
}
