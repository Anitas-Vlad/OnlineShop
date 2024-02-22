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

    public void EditProductQuantity(int productId, int quantity)
    {

        var product = FindProductInCart(productId);
        if (product == null)
        {
            
        }
    }
    //TODO Add to cart when product already exists. (when you press buy one more time)
    //TODO EditQuantity when product already exists in cart.
}