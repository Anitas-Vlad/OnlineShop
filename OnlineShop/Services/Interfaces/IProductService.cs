using OnlineShop.Models;

namespace OnlineShop.Services;

public interface IProductService
{
    Task<Product> FindProductById(int productId);
    Task<List<Product>> QueryAllProducts();
}