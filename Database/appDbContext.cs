using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stock.Models;
using User.Models;
using AnimalDetails.Models;

namespace NamesappDbContextpace
{
    public class appDbContext : IdentityDbContext
    {
        public appDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Stock> Stoki { get; set; }
        public DbSet<Animal> Animal { get; set; }

        public DbSet<AnimalDetails> AnimalDetails { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
//kjfsdkjglkdsjgsdkjglksdjglsdkjgskljgskdjgkldsjglksdjglkdsjgdsjglkdsjglksjgkdsjglkdsgjlsdfgj