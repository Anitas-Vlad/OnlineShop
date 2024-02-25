using OnlineShop.Models;
using OnlineShop.Models.Requests;

namespace OnlineShop.Services.Interfaces;

public interface ICartService
{
    Task<ShoppingCart> AddToCart(NewCartProductRequest request);
    Task<ShoppingCart> RemoveProductFromCart(int productId);
}