using Microsoft.EntityFrameworkCore;
using RobsDogs.Models.Data;
using RobsDogs.Models.Domain;

namespace RobsDogs.Repositories
{
    public class DogOwnerDataContext : DbContext
    {
        public DogOwnerDataContext(DbContextOptions<DogOwnerDataContext> options) :base(options)
        {
        }
        
        public DbSet<DogOwnerData> DogOwners { get; set; }
    }
}