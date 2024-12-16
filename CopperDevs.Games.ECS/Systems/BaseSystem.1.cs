namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem<T1> : BaseSystem
    where T1 : notnull, new()
{
    public abstract void Update(ref T1 component);

    protected internal override void UpdateSystem<TStreamType>(IFilter[] filters)
    {
        if (typeof(TStreamType) == typeof(StreamTypes.For)) World.For<T1>(Update);
        else if (typeof(TStreamType) == typeof(StreamTypes.Job)) World.Job<T1>(Update);
    }
}
