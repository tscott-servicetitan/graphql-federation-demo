using SubgraphB.Types;

namespace SubgraphB;

public abstract class Repository
{
    public static readonly IReadOnlyList<Equipment> Equipment = new List<Equipment>
    {
        new() { Id = "equipment/1", LocationId = "location/1", Name = "Equipment1" },
        new() { Id = "equipment/2", LocationId = "location/1", Name = "Equipment2" },
        new() { Id = "equipment/3", LocationId = "location/2", Name = "Equipment3" },
        new() { Id = "equipment/4", LocationId = "location/3", Name = "Equipment4" },
        new() { Id = "equipment/5", LocationId = "location/4", Name = "Equipment5" },
    };
}
