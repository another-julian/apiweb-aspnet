using APIWeb.Models;

namespace APIWeb.Services;

public static class BurguerService
{
    static List<Burguer> Burguers { get; }

    static int nextId = 6;

    static BurguerService()
    {
        Burguers = new List<Burguer> {

            new Burguer { Id = 1, Name = "Classic Cheeseburguer", IsGlutenFree = false, Content = "Pan brioche, carne de res, queso cheddar, lechuga, tomate, cebolla, pepinillos, mayonesa, mostaza, kétchup.", Price = 9.5m },

            new Burguer { Id = 2, Name = "BBQ Bacon Burguer", IsGlutenFree = false, Content = "Pan brioche, carne de res, queso cheddar, tocino, cebolla crispy, salsa BBQ, mayonesa.", Price = 11.0m },

            new Burguer { Id = 3, Name = "Spicy Jalapeño Burguer", IsGlutenFree = false, Content = "Pan brioche, carne de res, queso pepper jack, jalapeños, lechuga, tomate, cebolla, mayonesa picante.", Price = 10.5m },

            new Burguer { Id = 4, Name = "Mushroom Swiss Burguer", IsGlutenFree = false, Content = "Pan brioche, carne de res, queso suizo, champiñones salteados, cebolla caramelizada, mayonesa.", Price = 10.0m },

            new Burguer { Id = 5, Name = "Veggie Burguer", IsGlutenFree = true, Content = "Pan integral, hamburguesa de garbanzos y quinoa, lechuga, tomate, cebolla, aguacate, mayonesa vegana.", Price = 9.0m }
        };
    }

    public static List<Burguer> GetAll() => Burguers;

    public static Burguer? Get(int id) => Burguers.FirstOrDefault(b => b.Id == id);

    public static void Add(Burguer burguer)
    {
        burguer.Id = nextId++;
        Burguers.Add(burguer);
    }

    public static void Delete(int id)
    {
        var burguer = Get(id);
        if (burguer is null) return;

        Burguers.Remove(burguer);
    }

    public static void Update(Burguer burguer)
    {
        var index = Burguers.FindIndex(b => b.Id == burguer.Id);
        if (index == -1) return;
        Burguers[index] = burguer;
    }
}