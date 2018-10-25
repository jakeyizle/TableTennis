using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moserware.Skills;
namespace WindowsFormsApp1.Models
{
    public class Person : Player
    {
        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; }
        public double Mean { get; set; }
        public double StandardDeviation { get; set; }
        [NotMapped]
        public int GamesPlayed { get; set; }
        [NotMapped]
        public double WinPercentage { get; set; }
        [NotMapped]
        public Rating OldRating;
        [NotMapped]
        public virtual ICollection<MatchPerson> MatchPeople { get; set; }
        [NotMapped]
        public Result Result;
        [NotMapped]
        public Rating Rating
        {
            get
            {
                return new Rating(Mean, StandardDeviation);
            }
            set
            {
                Mean = value.Mean;
                StandardDeviation = value.StandardDeviation;
            }
        }
        [NotMapped]
        public double ConservativeRating
        {
            get
            {
                return Math.Round(Rating.ConservativeRating, 4);
            }
        }
        public int Rank;

        public Person() : base(0)
        {

        }

        public Person(string name, GameInfo gameInfo) : base(name)
        {
            Name = name;
            var person = Get();
           
            if (person != null)
            {
                Mean = person.Mean;
                StandardDeviation = person.StandardDeviation;
                PersonId = person.PersonId;
            }
            else
            {
                Mean = gameInfo.InitialMean;
                StandardDeviation = gameInfo.InitialStandardDeviation;
                Save();
            }
        }

        public double UpdateRating(IDictionary<Player,Rating> dict)
        {
            OldRating = Rating;
            Mean = dict[this].Mean;
            StandardDeviation = dict[this].StandardDeviation;
            Save();
            return ConservativeRating - OldRating.ConservativeRating;
        }

        public void Save()
        {
            using (var context = new TableTennisModel())
            {
                context.Entry(this).State = PersonId == 0 ?
                                       EntityState.Added :
                                       EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Person Get()
        {
            using (var context = new TableTennisModel())
            {
                return context.People.SingleOrDefault(x => x.Name == Name);
            }
        }

        public void SetResult(List<string> names)
        {
            //Relying on order of textbox input to determine who wins/loses
            int index = names.IndexOf(Name);
            if (index > 1 || (index == 1 && names.Count == 2))
            {
                Result = 0;
            }
            else
            {
                Result = (Result)1;
            }
        }
    }          
}

