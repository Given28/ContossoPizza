using PizzaApi.Models;

namespace PizzaApi.Services
{
    public class PizzaService
    {
        static List<Pizza> Pizzas = new()
        {
            new Pizza { Id = 1, Name = "Margherita", IsVegetarian = true, IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Pepperoni", IsVegetarian = false, IsGlutenFree = false },
            new Pizza { Id = 3, Name = "Gluten-Free Veg", IsVegetarian = true, IsGlutenFree = true },
            new Pizza { Id = 4, Name = "BBQ Chicken", IsVegetarian = false, IsGlutenFree = false },
            new Pizza { Id = 5, Name = "Hawaiian", IsVegetarian = false, IsGlutenFree = false },
            new Pizza { Id = 6, Name = "Four Cheese", IsVegetarian = true, IsGlutenFree = false },
            new Pizza { Id = 7, Name = "Mushroom Delight", IsVegetarian = true, IsGlutenFree = true },
            new Pizza { Id = 8, Name = "Meat Lovers", IsVegetarian = false, IsGlutenFree = false },
            new Pizza { Id = 9, Name = "Vegan Supreme", IsVegetarian = true, IsGlutenFree = true },
            new Pizza { Id = 10, Name = "Buffalo Chicken", IsVegetarian = false, IsGlutenFree = false }
        };

        public List<Pizza> GetAll() => Pizzas;

        public Pizza? GetById(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public void Add(Pizza pizza)
        {
            pizza.Id = Pizzas.Max(p => p.Id) + 1;
            Pizzas.Add(pizza);
        }

        public void Delete(int id) => Pizzas.RemoveAll(p => p.Id == id);
    }
}
