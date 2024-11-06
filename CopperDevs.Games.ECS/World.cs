using CopperDevs.Games.ECS.Internal;
using CopperDevs.Games.ECS.Utility;

namespace CopperDevs.Games.ECS;

public partial class World : SafeDisposable
{
    public EntitySpawner CreateEntity() => new(this);

    public override void DisposeResources()
    {
    }
}