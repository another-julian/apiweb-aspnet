using System.ComponentModel.DataAnnotations;

namespace APIWeb.Models;

public class Pizza
{
    public int Id { get; set; }
    [Required(ErrorMessage = "The name is required")]
    public string? Name { get; set; }
    public string? Content { get; set; }
    [Required(ErrorMessage = "The price is required")]
    public decimal? Price { get; set; }
    public bool IsGlutenFree { get; set; }
}