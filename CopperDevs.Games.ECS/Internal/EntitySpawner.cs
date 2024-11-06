namespace CopperDevs.Games.ECS.Internal;

public class EntitySpawner
{
    private readonly World world;
    private List<Type> componentTypes = [];

    internal EntitySpawner(World world)
    {
        this.world = world;
    }

    public EntitySpawner Add<T>() where T : notnull
    {
        return this;
    }

    public EntitySpawner Add<T>(T component) where T : notnull
    {
        return this;
    }

    public void Spawn()
    {
        world.AddEntity(new Entity(componentTypes.ToArray()));
    }
}