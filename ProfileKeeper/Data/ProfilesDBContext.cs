using Microsoft.EntityFrameworkCore;

namespace ProfileKeeper.Data
{
    public class ProfilesDBContext : DbContext
    {
        // There are no foreign keys and logic stuff. Therefore use same model as for UI
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ProfilesDb");
        }
    }
}
