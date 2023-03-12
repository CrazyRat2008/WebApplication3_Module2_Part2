using Autofac;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    public class Cocktail
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
    }
    public class CocktailController : Controller
    {
        private readonly List<Cocktail> cocktails;

        public CocktailController(List<Cocktail> cocktails)
        {
            this.cocktails = cocktails;
        }

        public IActionResult Index()
        {
            return View(cocktails);
        }
    }



}
