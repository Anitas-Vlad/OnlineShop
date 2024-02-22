using OnlineShop.Models.Requests;

namespace OnlineShop.Services.Interfaces;

public interface IAuthService
{
    Task<string> Login(LoginRequest request);
}