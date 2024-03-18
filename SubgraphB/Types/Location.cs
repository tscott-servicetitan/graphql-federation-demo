using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace SubgraphB.Types;

[ExtendServiceType]
public class Location
{
    [ID, Key]
    public string Id { get; set; } = default!;

    [ReferenceResolver]
    public static Location ResolveServiceReference(string id) => new() { Id = id };

    public async Task<IReadOnlyList<Equipment>> EquipmentAsync()
    {
        return await Task.FromResult(Repository.Equipment.Where(m => m.LocationId == Id).ToList());
    }
}
