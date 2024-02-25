using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models;

public class CartProduct
{
    public int Id { get; set; }
    [Required] public int ProductId { get; set; }
    [Required] public string ProductName { get; set; }
    [Required] public double PricePerProduct { get; set; }
    [Required] public int Quantity { get; set; }
    [Required] public double TotalPrice { get; set; }

    public void EditQuantity(int amount)
    {
        Quantity = amount;
        TotalPrice = PricePerProduct * amount;
    }
}