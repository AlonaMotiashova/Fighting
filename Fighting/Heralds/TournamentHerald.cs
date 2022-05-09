using System;

namespace Fighting.Heralds
{
    public class TournamentHerald : ObservableObject
    {
        public void NotifyAboutTournament()
        {
            Console.WriteLine("The tournament starts!");
            Notify();
        }
    }
}
