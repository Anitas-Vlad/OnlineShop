namespace OnlineShop.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public List<CartProduct> CartProducts { get; set; }
    public double TotalPrice { get; set; }

    public void AddProduct(CartProduct cartProduct)
    {
        CartProducts.Add(cartProduct);
        TotalPrice += cartProduct.TotalPrice;
    }

    public CartProduct? FindProductInCart(int productId)
        => CartProducts.FirstOrDefault(cartProduct => cartProduct.ProductId == productId);

    public void RemoveProduct(int productId)
    {
        var product = CartProducts.First(product => product.ProductId == productId);
        CartProducts.Remove(product);
        TotalPrice -= product.TotalPrice;
    }
}