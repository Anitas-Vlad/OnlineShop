using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models.Requests;

public class NewCartProductRequest
{
    public int ProductId { get; set; }
    public double PricePerProduct { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Positive value required.")] 
    public int Quantity { get; set; }
    public string ProductName { get; set; }

    public double TotalPrice => Quantity * PricePerProduct;
}