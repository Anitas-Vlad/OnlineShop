using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models;

public class User
{
    public int Id { get; set; }
    [Required] public string Username { get; set; }
    [Required] public string PasswordHash { get; set; }
    [Required] public string Email { get; set; }
    [Required] public ShoppingCart ShoppingCart { get; set; }
    public List<Order> Orders { get; set; }
}