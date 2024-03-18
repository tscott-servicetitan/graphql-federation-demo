namespace SubgraphA.Types;

public class Query
{
    public Task<IReadOnlyList<Location>> LocationsAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Locations);
    }
}
