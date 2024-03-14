using SubgraphB.Types;

namespace SubgraphB;

public abstract class Repository
{
    public static readonly IReadOnlyList<Material> Materials = new List<Material>
    {
        new() { Id = "material/1", ServiceId = "service/1", Name = "Material1" },
        new() { Id = "material/2", ServiceId = "service/1", Name = "Material2" },
        new() { Id = "material/3", ServiceId = "service/2", Name = "Material3" },
        new() { Id = "material/4", ServiceId = "service/3", Name = "Material4" },
        new() { Id = "material/5", ServiceId = "service/4", Name = "Material5" },
    };
}
