using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Context;

public class OnlineShopContext : DbContext
{
    public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ModelBuilderExtensions.Seed(modelBuilder);
    }

    public DbSet<User> Users { get; set; } = default!;
    public DbSet<CartProduct> CartProducts { get; set; } = default!;
    public DbSet<Order> Orders { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<ShoppingCart> ShoppingCarts { get; set; } = default!;

    private static class ModelBuilderExtensions
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1000,
                    Username = "User 1",
                    Email = "user1@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User11.."),
                    Orders = new List<Order>(), 
                    ShoppingCart = new ShoppingCart()
                },
                new User
                {
                    Id = 1001,
                    Username = "User 2",
                    Email = "user2@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User22.."),
                    Orders = new List<Order>(), 
                    ShoppingCart = new ShoppingCart()
                },
                new User
                {
                    Id = 1002,
                    Username = "User 3",
                    Email = "user3@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User33.."),
                    Orders = new List<Order>(), 
                    ShoppingCart = new ShoppingCart()
                },
                new User
                {
                    Id = 1004,
                    Username = "Owner",
                    Email = "owner@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Owner123."),
                    Orders = new List<Order>(), 
                    ShoppingCart = new ShoppingCart()
                }
            );
        }
    }
}