namespace APIWeb.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Content { get; set; }
    public decimal? Price { get; set; }
    public bool IsGlutenFree { get; set; }
}