namespace HotChocolateFluentValidation
{
    public interface IUserService
    {
        Task<string> CreateUserAsync(UserInput input);
    }

    public class UserService : IUserService
    {
        public Task<string> CreateUserAsync(UserInput input)
        {
            // Logic for creating a user
            return Task.FromResult("User created successfully.");
        }
    }
}
