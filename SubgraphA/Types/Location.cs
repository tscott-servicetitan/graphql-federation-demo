using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphA.Types;

public class Location
{
    [ID, Key]
    public string Id { get; set; } = default!;

    [ID]
    public string ExternalId { get; set; } = default!;

    public string Name { get; set; } = default!;

    [ReferenceResolver]
    public static Task<Location?> ResolveReferenceById(string id)
    {
        return Task.FromResult(Repository.Locations.FirstOrDefault(s => s.Id == id));
    }

    [ReferenceResolver]
    public static Task<Location?> ResolveReferenceByExternalId(string externalId)
    {
        return Task.FromResult(Repository.Locations.FirstOrDefault(s => s.ExternalId == externalId));
    }
}
