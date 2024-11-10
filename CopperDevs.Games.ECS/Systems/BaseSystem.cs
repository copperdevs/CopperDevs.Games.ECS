namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem
{
    protected World World = null!;
    protected internal abstract void UpdateSystem<TStreamType>(IFilter[] filters) where TStreamType : StreamType;

    protected internal void SetWorld(World targetWorld) => World = targetWorld;
}