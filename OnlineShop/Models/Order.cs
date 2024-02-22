namespace OnlineShop.Models;

public class Order
{
    public int Id { get; set; }
    public List<CartProduct> CartProducts { get; set; }
    public double TotalPrice { get; set; }
    public DateTime Time { get; set; }
}