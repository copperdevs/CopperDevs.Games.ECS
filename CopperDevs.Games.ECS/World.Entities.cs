using CopperDevs.Games.ECS.Internal;

namespace CopperDevs.Games.ECS;

public partial class World
{
    private List<Entity> entities = [];

    internal void AddEntity(Entity entity)
    {
        entities.Add(entity);
    }
}