using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphB.Types;

[ExtendServiceType]
public class Service
{
    [ID, Key]
    public string Id { get; set; } = default!;

    [ReferenceResolver]
    public static Service ResolveServiceReference(string id) => new() { Id = id };

    public async Task<IReadOnlyList<Material>> MaterialsAsync([Service] ILogger<Service> logger)
    {
        return await Task.FromResult(Repository.Materials.Where(m => m.ServiceId == Id).ToList());
    }
}
