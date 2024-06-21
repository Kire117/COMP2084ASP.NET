using LabWebApp.Data;
using LabWebApp.Models;
using System.Linq;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        // Look for any products.
        if (context.Products.Any())
        {
            return;   // DB has been seeded
        }

        var products = new Product[]
        {
            new Product{Name="Product1",Price=10.99M,Description="Description1"},
            new Product{Name="Product2",Price=20.99M,Description="Description2"},
            new Product{Name="Product3",Price=30.99M,Description="Description3"},
        };

        foreach (var p in products)
        {
            context.Products.Add(p);
        }
        context.SaveChanges();
    }
}
