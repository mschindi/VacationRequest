using Microsoft.EntityFrameworkCore;
using VacationRequest.UserRole;

namespace VacationRequest.Database
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        
        // the dbset propterty will tell ef core that we have a table that needs to be created id doesnt exist
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<VacationRequest.VacationRequest> VacationRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                optionsBuilder.UseSqlite("Data Source=VacationRequestDb.db");
  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}