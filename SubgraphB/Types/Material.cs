using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphB.Types;

public class Material
{
    [ID, Key]
    public string Id { get; set; } = default!;

    [GraphQLIgnore]
    public string ServiceId { get; set; }

    public Task<Service> ServiceAsync()
    {
        return Task.FromResult(new Service { Id = ServiceId });
    }

    public string Name { get; set; } = default!;

    [ReferenceResolver]
    public static Task<Material?> ResolveReferenceByIdAsync(string id)
    {
        return Task.FromResult(Repository.Materials.FirstOrDefault(s => s.Id == id));
    }
}
