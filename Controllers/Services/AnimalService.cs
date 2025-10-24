using System;
//using Animal.Models ;
using Animals.Models;
using NamesappDbContextpace;

namespace AnimalServices.Controllers.Services
{
    public class AnimalService : appDbContext
    {
        private appDbContext _db;
        //public appDbContext.ani (appDbContext d) { _db = d; }

        public void DoHeal(int id)
        {
            var x = _db.Animal.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal id=" + id);
            }
        }

        public void AddNewAnimal(string n, string o, int a, string t)
        {
            var newAnimal = new Animal();
            newAnimal.Id = new Random().Next(1000, 9999);
            newAnimal.Names = n;
            newAnimal.Owner = o;
            newAnimal.Age = a;
            newAnimal.Type = t;
            newAnimal.sickOrNot = false;
        }

        public void RandomAgeUp()
        {
            foreach (var x in _db.Animal.ToList())
            {
                x.agee += 7;
            }
        }
    }
}
