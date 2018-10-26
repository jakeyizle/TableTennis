using MoreLinq;
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

        public Statistic (string name)
        {
            using (var context = new TableTennisModel())
            {
                Person = context.People.FirstOrDefault(x => x.Name == name);
            }
        }

        //abandon all hope, ye who enter here 
        public string Record(PointType pointType)
        {
            using (var context = new TableTennisModel())
            {
                var matchIds = GetMatchIds(Person, pointType);
                var matchPeople = context.MatchPeople.Where(x => matchIds.Contains(x.MatchId) && x.PersonId == Person.PersonId).ToList();

                double totalGameCount = matchIds.Count();
                double winGameCount = matchPeople.Where(x => x.MatchResult == Result.Win).Count();
                double loseGameCount = matchPeople.Where(x => x.MatchResult == Result.Loss).Count();
                double percentage = Math.Round(winGameCount / totalGameCount * 100, 3);
                return $"{winGameCount}-{loseGameCount} ({percentage}%)";
            }
        }
        public string BestOrWorstRecord(Result result, PointType pointType)
        {
            using (var context = new TableTennisModel())
            {
                var matchIds = GetMatchIds(Person, pointType);

                if (!matchIds.Any())
                {
                    return "null";
                }

                var opponentMatches = context.MatchPeople.Where(x => matchIds.Contains(x.MatchId) && x.PersonId != Person.PersonId).ToList();
                opponentMatches = opponentMatches.DistinctBy(x => x.PersonId).ToList();
                var opponentIds = opponentMatches.Select(x => x.PersonId).ToList();
                Dictionary<int, int> dict = new Dictionary<int, int>();

                foreach (int opponentId in opponentIds)
                {
                    var oMatchIds = GetMatchIds(context.People.FirstOrDefault(x => x.PersonId == opponentId), pointType);
                    var ourMatchIds = matchIds.Intersect(oMatchIds);

                    var matchPeople = context.MatchPeople.Where(x => ourMatchIds.Contains(x.MatchId) && x.PersonId == Person.PersonId);
                    int winningMatchPeople = matchPeople.Count(x => x.MatchResult == Result.Win);
                    int losingMatchPeople = matchPeople.Count(x => x.MatchResult == Result.Loss);
                    int record = winningMatchPeople - losingMatchPeople;
                    dict.Add(opponentId, record);                     
                }
                dict = dict.OrderBy(kvp => kvp.Value).ToDictionary();
                int id;
                if (result == Result.Loss)
                {
                    id = dict.First().Key;
                }
                else
                {
                    id = dict.Last().Key;
                }
                var opMatchIds = GetMatchIds(context.People.FirstOrDefault(x => x.PersonId == id), pointType);
                var combinedMatchIds = matchIds.Intersect(opMatchIds);

                var matches = context.MatchPeople.Where(x => combinedMatchIds.Contains(x.MatchId) && x.PersonId == Person.PersonId);
                double winningMatches = matches.Count(x => x.MatchResult == Result.Win);
                double losingMatches = matches.Count(x => x.MatchResult == Result.Loss);
                double percentage = Math.Round(winningMatches / (winningMatches + losingMatches) * 100, 3);
                string name = context.People.SingleOrDefault(x => x.PersonId == id).Name;
                return $"{winningMatches}-{losingMatches} ({percentage}%) vs {name}";
            }
        }

        public string AveragePointsForOrAgainst(Result result, PointType pointType)
        {
            using (var context = new TableTennisModel())
            {
                var matchIds = GetMatchIds(Person, pointType, result);
                var matchList = context.MatchPeople.Where(x => matchIds.Contains(x.MatchId)).ToList();
                double sum = 0;
                double count = 0;
                if (result == Result.Loss)
                {
                    matchList = matchList.Where(x => x.PersonId != Person.PersonId).ToList();
                    foreach(MatchPerson matchPerson in matchList)
                    {
                        var matchResult = matchPerson.MatchResult;
                        var match = context.Matches.FirstOrDefault(x => x.MatchId == matchPerson.MatchId);
                        if (match.WinningScore == null || match.LosingScore == null)
                        {
                            continue;
                        }
                        sum += (matchPerson.MatchResult == Result.Win) ? (double)match.WinningScore : (double)match.LosingScore;
                        count++;
                    }
                }
                else
                {
                    matchList = matchList.Where(x => x.PersonId == Person.PersonId).ToList();
                    foreach (MatchPerson matchPerson in matchList)
                    {
                        var matchResult = matchPerson.MatchResult;
                        var match = context.Matches.FirstOrDefault(x => x.MatchId == matchPerson.MatchId);
                        if (match.WinningScore == null || match.LosingScore == null)
                        {
                            continue;
                        }
                        sum += (matchPerson.MatchResult == Result.Win) ? (double)match.WinningScore : (double)match.LosingScore;
                        count++;
                    }
                }
                double average = sum / count;
                return $"{average} points per game";                
            }
        }
        public List<int> GetMatchIds(Person person, PointType pointType)
        {
            using (var context = new TableTennisModel())
            {                
                var matchPeople = context.MatchPeople.Where(x => x.PersonId == Person.PersonId).ToList();
                var matchIds = matchPeople.Select(x => x.MatchId);
                var matches = context.Matches.Where(x => matchIds.Contains(x.MatchId) && x.PointType == pointType).ToList();
                return matches.Select(x => x.MatchId).ToList();
            }
        }
        public List<int> GetMatchIds(Person person, PointType pointType, Result result)
        {
            using (var context = new TableTennisModel())
            {
                var matchPeople = context.MatchPeople.Where(x => x.PersonId == Person.PersonId && x.MatchResult == result).ToList();
                var matchIds = matchPeople.Select(x => x.MatchId);
                var matches = context.Matches.Where(x => matchIds.Contains(x.MatchId) && x.PointType == pointType).ToList();
                return matches.Select(x => x.MatchId).ToList();
            }
        }
    }
}
