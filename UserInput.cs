using FluentValidation;

namespace HotChocolateFluentValidation
{
    public class UserInput
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UserInputValidator : AbstractValidator<UserInput>
    {
        public UserInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Age).GreaterThan(0).WithMessage("Age must be greater than zero.");
        }
    }
}
