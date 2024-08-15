using AppAny.HotChocolate.FluentValidation;

namespace HotChocolateFluentValidation
{
    public class Mutation
    {
        public async Task<string> CreateUserAsync([UseFluentValidation, UseValidator<UserInputValidator>] UserInput input, [Service] IUserService userService)
        {
            // Add user creation logic here
            return await userService.CreateUserAsync(input);
        }
    }
}
