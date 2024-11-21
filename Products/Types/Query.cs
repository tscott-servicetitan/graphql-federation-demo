namespace Products.Types;

public class Query
{
    public Task<IQueryable<Product>> ProductsAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Products);
    }
}
