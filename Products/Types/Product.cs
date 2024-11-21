using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace Products.Types;

public class Product
{
    [ID, Key]
    public string Id { get; set; } = default!;

    public string Name { get; set; } = default!;

    [ReferenceResolver]
    public static Task<Product?> ResolveReferenceByIdAsync(string id)
    {
        return Task.FromResult(Repository.Products.FirstOrDefault(s => s.Id == id));
    }
}
