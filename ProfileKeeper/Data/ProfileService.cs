using Microsoft.EntityFrameworkCore;

namespace ProfileKeeper.Data
{
    public class ProfileService : IProfileService
    {
        public async Task AddProfileAsync(Profile profile)
        {
            using var dbContext = new ProfilesDBContext();
            await dbContext.Profiles.AddAsync(profile);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteProfileAsync(int id)
        {
            using var dbContext = new ProfilesDBContext();
            var profile = await dbContext.Profiles.SingleOrDefaultAsync(p => p.Id == id);
            if (profile != null)
            {
                dbContext.Remove(profile);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Profile[]> GetProfilesAsync()
        {
            using var dbContext = new ProfilesDBContext();
            return await dbContext.Profiles.ToArrayAsync();
        }
    }
}