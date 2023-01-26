namespace ProfileKeeper.Data
{
    public interface IProfileService
    {
        Task<Profile[]> GetProfilesAsync();

        Task AddProfileAsync(Profile profile);

        Task DeleteProfileAsync(int id);
    }
}