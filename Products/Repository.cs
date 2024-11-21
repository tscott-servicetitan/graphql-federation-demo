using Products.Types;

namespace Products;

public abstract class Repository
{
    public static readonly IQueryable<Product> Products = new List<Product>
    {
        new() { Id = "product/1", Name = "Product1" },
        new() { Id = "product/2", Name = "Product2" },
        new() { Id = "product/3", Name = "Product3" },
        new() { Id = "product/4", Name = "Product4" },
        new() { Id = "product/5", Name = "Product5" },
    }.AsQueryable();
}
