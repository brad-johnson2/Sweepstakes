using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public List<Contestant> contestants = new List<Contestant>();


        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant);

        }
        public string PickWinner()
        {
            Random rnd = new Random();
            int winningNumber = rnd.Next(0, contestants.Count);
            string winner = contestants[winningNumber];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }
    }
}
