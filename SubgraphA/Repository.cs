using SubgraphA.Types;

namespace SubgraphA;

public abstract class Repository
{
    public static readonly IReadOnlyList<Service> Services = new List<Service>
    {
        new() { Id = "service/1", ExternalId = "External1", Name = "Service1" },
        new() { Id = "service/2", ExternalId = "External2", Name = "Service2" },
        new() { Id = "service/3", ExternalId = "External3", Name = "Service3" },
        new() { Id = "service/4", ExternalId = "External4", Name = "Service4" },
        new() { Id = "service/5", ExternalId = "External5", Name = "Service5" },
    };
}
