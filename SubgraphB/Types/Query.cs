namespace SubgraphB.Types;

public class Query
{
    public Task<IReadOnlyList<Equipment>> EquipmentAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Equipment);
    }
}
