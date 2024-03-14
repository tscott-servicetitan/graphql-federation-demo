namespace SubgraphB.Types;

public class Query
{
    public Task<IReadOnlyList<Material>> MaterialsAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Materials);
    }
}
