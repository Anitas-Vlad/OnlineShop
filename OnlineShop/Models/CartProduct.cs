namespace OnlineShop.Models;

public class CartProduct
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double PricePerProduct { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }

    public void EditQuantity(int amount)
    {
        Quantity = amount;
        TotalPrice = PricePerProduct * amount;
    }
}