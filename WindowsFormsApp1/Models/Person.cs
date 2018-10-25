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
        static TableTennisModel context = new TableTennisModel();
        public virtual ICollection<MatchPerson> MatchPeople { get; set; }
        [NotMapped]
        public int Result;
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
            var local = context.Set<Person>()
                            .Local
                            .FirstOrDefault(f => f.Name == Name);
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(this).State = EntityState.Modified;
            context.SaveChanges();
        }
        public Rating Rating()
        {
            return new Rating(Mean, StandardDeviation);
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
                Result = 1;
            }
            }
        }          
}

