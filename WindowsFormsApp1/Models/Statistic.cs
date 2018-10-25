using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Statistic
    {
        public Person Person;


        public string Record(Person personAgainst = null)
        {
            using (var context = new TableTennisModel())
            {
                var matchIds = context.MatchPeople.Where(x => x.PersonId == Person.PersonId).ToList();

                if (personAgainst != null)
                {
                    matchIds = matchIds.Intersect(context.MatchPeople.Where(x => x.PersonId == personAgainst.PersonId)).ToList();
                }

                double totalGameCount = matchIds.Count();
                double winGameCount = matchIds.Where(x => x.MatchResult == Result.Win).Count();
                double loseGameCount = matchIds.Where(x => x.MatchResult == Result.Loss).Count();
                double percentage = winGameCount / totalGameCount * 100;
                return (personAgainst == null) ? "{winGameCount}-{loseGameCount} ({percentage}%)"
                    : "{winGameCount}-{loseGameCount} ({percentage}%) vs {personAgainst.Name}";
            }
        }
        public string BestOrWorstRecord(Result result)
        {
            using (var context = new TableTennisModel())
            {
                var matchPeople = context.MatchPeople.Where(x => x.PersonId == Person.PersonId).ToList();
                var matchIds = matchPeople.Select(x => x.MatchId).ToList();

                var opponentMatches = matchPeople.Where(x => matchIds.Contains(x.MatchId) && x.PersonId != Person.PersonId).ToList();
                var opponentIds = opponentMatches.Select(x => x.PersonId).ToList();
                Dictionary<int, int> dict = new Dictionary<int, int>();
                foreach (int opponentId in opponentIds)
                {
                    int winningMatches = context.MatchPeople.Where(x => x.PersonId == opponentId && x.MatchResult == Result.Loss).Count();
                    int losingMatches = context.MatchPeople.Where(x => x.PersonId == opponentId && x.MatchResult == Result.Win).Count();
                    int record = winningMatches - losingMatches;
                    dict.Add(opponentId, record); 
                }
                int id;
                if (result == Result.Loss)
                {

                    id = dict.Min().Key;
                }
                else
                {
                    id = dict.Max().Key;
                }
                double winningCount = context.MatchPeople.Where(x => x.PersonId == id && x.MatchResult == Result.Loss).Count();
                double losingCount = context.MatchPeople.Where(x => x.PersonId == id && x.MatchResult == Result.Win).Count();
                double percentage = winningCount / (winningCount + losingCount) * 100;
                string name = context.People.SingleOrDefault(x => x.PersonId == id).Name;
                return "{winGameCount}-{loseGameCount} ({percentage}%) vs {name}";
            }
        }
    }
}
