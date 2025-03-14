using APIWeb.Models;

namespace APIWeb.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 6;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false, Content = "Masa fina, salsa de tomate, mozzarella fresca, albahaca, ajo, orégano, aceite de oliva, jamón, champiñones, alcachofas, aceitunas, salami picante, quesos como gorgonzola, parmesano y fontina.", Price = 12.5m },

            new Pizza { Id = 2, Name = "Margherita", IsGlutenFree = false, Content = "Masa fina, salsa de tomate, mozzarella fresca, albahaca, aceite de oliva.", Price = 10.0m },

            new Pizza { Id = 3, Name = "Quattro Formaggi", IsGlutenFree = false, Content = "Masa fina, salsa de tomate, mozzarella, gorgonzola, parmesano, fontina.", Price = 13.0m },

            new Pizza { Id = 4, Name = "Diavola", IsGlutenFree = false, Content = "Masa fina, salsa de tomate, mozzarella, salami picante, aceite de oliva.", Price = 11.5m },

            new Pizza { Id = 5, Name = "Vegetariana", IsGlutenFree = true, Content = "Masa fina sin gluten, salsa de tomate, mozzarella, champiñones, pimientos, cebolla, aceitunas, orégano.", Price = 12.0m }
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
}