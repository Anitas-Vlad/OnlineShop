using OnlineShop.Models;
using OnlineShop.Models.Responses;
using OnlineShop.Services.Interfaces;

namespace OnlineShop.Services.Mappers;

public class UserMapper : IUserMapper
{
    public UserResponse Map(User user)
        => new()
        {
            Id = user.Id,
            UserName = user.Username
        };

    public List<UserResponse> Map(List<User> users) 
        => users.Select(user => Map(user)).ToList();
}