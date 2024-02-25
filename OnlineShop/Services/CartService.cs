using OnlineShop.Context;
using OnlineShop.Models;
using OnlineShop.Models.Requests;
using OnlineShop.Services.Interfaces;

namespace OnlineShop.Services;

public class CartService : ICartService
{
    private readonly IUserService _userService;
    private readonly OnlineShopContext _context;

    public CartService(OnlineShopContext context, IUserService userService)
    {
        _context = context;
        _userService = userService;
    }
    
    private CartProduct ConstructCartProduct(NewCartProductRequest request)
    {
        return new CartProduct()
        {
            ProductId = request.ProductId,
            ProductName = request.ProductName,
            PricePerProduct = request.PricePerProduct,
            Quantity = request.Quantity,
            TotalPrice = request.TotalPrice
        };
    }

    public async Task<ShoppingCart> AddToCart(NewCartProductRequest request)
    {
        if (request.Quantity <= 0)
            throw new ArgumentException("Invalid amount.");

        var cart = await _userService.QueryPersonalShoppingCart();

        var optionalCartProduct = cart.FindProductInCart(request.ProductId);
        
        if (optionalCartProduct == null)
        {
            var newCartProduct = ConstructCartProduct(request);
            
            cart.AddProduct(newCartProduct);

            _context.ShoppingCarts.Update(cart);
            _context.CartProducts.Add(newCartProduct);

            await _context.SaveChangesAsync();
            return cart;
        }

        if (request.Quantity  ==  0)
        {
            cart.RemoveProduct(request.ProductId);
            
            _context.ShoppingCarts.Update(cart);
            await _context.SaveChangesAsync();
            return cart;
        }
        
        optionalCartProduct.EditQuantity(request.Quantity);
        return cart;
    }

    public async Task<ShoppingCart> RemoveProductFromCart(int productId)
    {
        var cart = await _userService.QueryPersonalShoppingCart();
        cart.RemoveProduct(productId);
        return cart;
    }
}