using Autofac;

namespace WebApplication3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<List<Cocktail>>(new List<Cocktail>
    {
        new Cocktail { Name = "Margarita", Ingredients = "Tequila, lime juice, triple sec", Description = "A classic tequila cocktail" },
        new Cocktail { Name = "Manhattan", Ingredients = "Whiskey, sweet vermouth, bitters", Description = "A classic whiskey cocktail" },
        new Cocktail { Name = "Gin and Tonic", Ingredients = "Gin, tonic water, lime", Description = "A refreshing gin cocktail" }
    });

            services.AddMvc();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<CocktailController>();
        }
    }
}
