using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphB.Types;

public class Equipment
{
    [ID, Key]
    public string Id { get; set; } = default!;

    [GraphQLIgnore]
    public string LocationId { get; set; }

    public Task<Location> ServiceAsync()
    {
        return Task.FromResult(new Location { Id = LocationId });
    }

    public string Name { get; set; } = default!;

    [ReferenceResolver]
    public static Task<Equipment?> ResolveReferenceByIdAsync(string id)
    {
        return Task.FromResult(Repository.Equipment.FirstOrDefault(s => s.Id == id));
    }
}
