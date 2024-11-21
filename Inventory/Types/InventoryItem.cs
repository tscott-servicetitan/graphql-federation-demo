using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace Inventory.Types;

public class InventoryItem
{
    [ID, Key]
    public required string Id { get; set; }

    [ID]
    public required string ProductId { get; set; }

    public required string Name { get; set; }

    [ReferenceResolver]
    public static Task<InventoryItem?> ResolveReferenceById(string id)
    {
        return Task.FromResult(Repository.Inventory.FirstOrDefault(s => s.Id == id));
    }

    public Task<Product> ProductAsync()
    {
        return Task.FromResult(new Product { Id = ProductId });
    }
}
