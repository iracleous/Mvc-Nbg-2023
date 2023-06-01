using Microsoft.EntityFrameworkCore;

namespace Meb_Nbg_2023.Models
{
    public class NbgDbContext:DbContext
    {

        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=nbg-2023;User Id=sa; Password=passw0rd;TrustServerCertificate=True; ";
 

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
