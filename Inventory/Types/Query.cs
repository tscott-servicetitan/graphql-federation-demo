namespace Inventory.Types;

public class Query
{
    public Task<IQueryable<InventoryItem>> InventoryAsync(CancellationToken ct)
    {
        return Task.FromResult(Repository.Inventory);
    }
}
