using Microsoft.EntityFrameworkCore;
using OnlineShop.Context;
using OnlineShop.Models;
using OnlineShop.Services.Interfaces;

namespace OnlineShop.Services;

public class ProductService : IProductService
{
    private OnlineShopContext _context;

    public ProductService(OnlineShopContext context)
    {
        _context = context;
    }

    public async Task<Product> FindProductById(int productId)
    {
        var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == productId);

        if (product == null)
            throw new ArgumentException("Product not found.");

        return product;
    }

    public async Task<List<Product>> QueryAllProducts() 
        => await _context.Products.ToListAsync();
}