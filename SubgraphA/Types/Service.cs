using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphA.Types;

public class Service
{
    [ID, Key, Shareable]
    public string Id { get; set; } = default!;

    [ID]
    public string ExternalId { get; set; } = default!;

    public string Name { get; set; } = default!;

    [ReferenceResolver]
    public static Task<Service?> ResolveReferenceById(string id)
    {
        return Task.FromResult(Repository.Services.FirstOrDefault(s => s.Id == id));
    }

    [ReferenceResolver]
    public static Task<Service?> ResolveReferenceByExternalId(string externalId)
    {
        return Task.FromResult(Repository.Services.FirstOrDefault(s => s.ExternalId == externalId));
    }
}
