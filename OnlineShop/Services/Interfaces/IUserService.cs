using OnlineShop.Models;
using OnlineShop.Models.Requests;
using OnlineShop.Models.Responses;

namespace OnlineShop.Services.Interfaces;

public interface IUserService
{
    // Task<User> QueryUserById(int userId);
    // Task<UserResponse> QueryUserProfile(string username);
    Task<User> QueryPersonalAccount();
    Task<ShoppingCart> QueryPersonalShoppingCart();
    // Task<List<User>> QueryAllUsers();
    Task<User?> QueryUserByEmail(string userEmail);
    Task<User> CreateUser(RegisterRequest request);
}