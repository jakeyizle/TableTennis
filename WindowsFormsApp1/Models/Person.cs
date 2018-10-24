using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        static TableTennisModel context = new TableTennisModel();

        public virtual ICollection<MatchPerson> MatchPeople { get; set; }
        public Person() : base(0)
        {

        }

        public Person(string name) : base(name)
        {
            Name = name;
            var people = context.People.Where(x => x.Name == Name).ToList();
           
            if (people.Any())
            {
                GamesPlayed = people[0].GamesPlayed;
                WinPercentage = people[0].WinPercentage;
                Mean = people[0].Mean;
                StandardDeviation = people[0].StandardDeviation;
                PersonId = people[0].PersonId;
            }
            else
            {
                GamesPlayed = 0;
                WinPercentage = 0;
                Mean = 25;
                StandardDeviation = Mean / 3;
                context.People.Add(this);
                context.SaveChanges();
            }
        }

        public double UpdateRating(IDictionary<Player,Rating> dict)
        {
            OldRating = Rating();
            Mean = dict[this].Mean;
            StandardDeviation = dict[this].StandardDeviation;
            Save();
            return Rating().ConservativeRating - OldRating.ConservativeRating;
        }

        public void Save()
        {
            context.Entry(this).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public Rating Rating()
        {
            return new Rating(Mean, StandardDeviation);
        }
    }
}
