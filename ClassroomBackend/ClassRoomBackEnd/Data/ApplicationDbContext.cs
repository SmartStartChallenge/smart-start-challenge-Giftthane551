using System.Security.Cryptography.X509Certificates;
using Code.Model;
using Microsoft.EntityFrameworkCore;
namespace Code.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
         public DbSet<Classroom> Classrooms { get; set; }
         public DbSet<Classes> Classess { get; set; }

        public DbSet<Teachers> teachers {  get; set; }

    }
}
