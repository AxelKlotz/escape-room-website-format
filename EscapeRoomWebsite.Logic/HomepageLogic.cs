namespace EscapeRoomWebsite.Logic
{
    public class HomepageLogic
    {
        PuzzleLogic puzzleLogic = new();
        public int CheckStartPuzzle() //Javascript can't take bool. 0 = false and 1 = true
        {
            bool check = puzzleLogic.CheckPuzzle("start");
            if (check)
                return 1;
            else
                return 0;
        }
        public void SolveStartPuzzle()
        {
            puzzleLogic.SolvePuzzle("start");
        }
        public int CheckCookiePuzzle()
        {
            bool check = puzzleLogic.CheckPuzzle("cookie");
            if (check)
                return 1;
            else
                return 0;
        }
        public void SolveCookiePuzzle()
        {
            puzzleLogic.SolvePuzzle("cookie");
        }
        public bool CheckHomepageInfo()
        {
            return puzzleLogic.CheckPuzzle("homeinfo");
        }
        public string[] GetCookieWords()
        {
            return puzzleLogic.GetCookiePuzzleWords();
        }
    }
}
