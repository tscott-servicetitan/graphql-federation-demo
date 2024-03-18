using SubgraphA.Types;
using Location = SubgraphA.Types.Location;

namespace SubgraphA;

public abstract class Repository
{
    public static readonly IReadOnlyList<Location> Locations = new List<Location>
    {
        new() { Id = "location/1", ExternalId = "External1", Name = "Location1" },
        new() { Id = "location/2", ExternalId = "External2", Name = "Location2" },
        new() { Id = "location/3", ExternalId = "External3", Name = "Location3" },
        new() { Id = "location/4", ExternalId = "External4", Name = "Location4" },
        new() { Id = "location/5", ExternalId = "External5", Name = "Location5" },
    };
}
