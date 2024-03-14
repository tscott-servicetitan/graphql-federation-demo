namespace SubgraphA.Types;

public class Query
{
    public Task<IReadOnlyList<Service>> ServicesAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Services);
    }
}
