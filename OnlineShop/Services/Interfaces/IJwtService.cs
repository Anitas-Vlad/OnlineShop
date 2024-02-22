using OnlineShop.Models;

namespace OnlineShop.Services.Interfaces;

public interface IJwtService
{
    string CreateToken(User user);
}