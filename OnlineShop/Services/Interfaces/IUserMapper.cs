using OnlineShop.Models;
using OnlineShop.Models.Responses;

namespace OnlineShop.Services.Interfaces;

public interface IUserMapper
{
    UserResponse Map(User user);
    List<UserResponse> Map(List<User> users);
}