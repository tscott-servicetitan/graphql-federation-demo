using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace Inventory.Types;

[ExtendServiceType]
public class Product
{
    [ID, Key]
    public required string Id { get; set; }

    [ReferenceResolver]
    public static Product ResolveServiceReference(string id) => new() { Id = id };

    public async Task<IQueryable<InventoryItem>> InventoryAsync()
    {
        return await Task.FromResult(Repository.Inventory.Where(m => m.ProductId == Id));
    }

    public async Task<bool> InStockAsync()
    {
        return await ItemsInStockAsync() > 0;
    }

    public async Task<long> ItemsInStockAsync()
    {
        return await Task.FromResult(Repository.Inventory.Count(m => m.ProductId == Id));
    }
}
