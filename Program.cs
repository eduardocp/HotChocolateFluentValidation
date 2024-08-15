using HotChocolateFluentValidation;
using FluentValidation;
using AppAny.HotChocolate.FluentValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        builder.Services.AddScoped<UserInputValidator>();
        builder.Services.AddScoped<IUserService, UserService>();

        builder.Services
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .AddFluentValidation(o => o.UseDefaultErrorMapper());

        var app = builder.Build();

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL();
        });

        app.Run();
    }
}