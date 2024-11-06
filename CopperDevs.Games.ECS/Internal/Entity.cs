namespace CopperDevs.Games.ECS.Internal;

public readonly struct Entity
{
    private readonly Type[] components = [];

    internal Entity(Type[] components)
    {
        this.components = components;
    }
    
    public bool Has<T>() where T : notnull
    {
        return components.Contains(typeof(T));
    }
}