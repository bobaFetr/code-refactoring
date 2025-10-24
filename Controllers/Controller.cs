using AnimalServices.Controllers.Services;
using Microsoft.AspNetCore.Mvc;
using NamesappDbContextpace;

//using Namespace;
//using NameSpace;

using Stock.Models;
//using Controllers.Services;
namespace CodeRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : appDbContext
    {
        private appDbContext db;
        private AnimalService servicer;

        //Stock stock = new Stock();

        //Stocka stock = new Stocka();
        public AnimalService(appDbContext d, AnimalService s)
        {
            db = d;
            servicer = s;
        }

        [HttpGet("getall")]
        public List<Stock> GetAllAnimals()
        {
            
            return db.Stoki.ToList();
        }

        [HttpGet("getone/{x}")]
        public Stock GetOneAnimal(int x)
        {
            return db.Stoki.Find(x); 
        }

        [HttpPost("add")]
        public string AddAnimal([FromQuery] string n, string o, int a, string t)
        {
            servicer.AddNewAnimal(n, o, a, t);
            return "200? most probably.";
        }

        [HttpPost("heal/{id}")]
        public string HealAnimal(int id)
        {
            servicer.DoHeal(id);
            return "Animal is healed... maybe. What status code?";
        }

        [HttpDelete("delete/{id}")]
        public string DeleteAnimal(int id)
        {
            db.Remove(id);
            return "removed i think";
        }

        [HttpPost("ageup")]
        public string AgeUp()
        {
            servicer.RandomAgeUp();
            return "everyone got older";
        }
    }
}
