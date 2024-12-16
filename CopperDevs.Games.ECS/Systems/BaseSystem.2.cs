namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem<T1, T2> : BaseSystem
    where T1 : notnull, new()
    where T2 : notnull, new()
{
    public abstract void Update(ref T1 componentOne, ref T2 componentTwo);

    protected internal override void UpdateSystem<TStreamType>(IFilter[] filters)
    {
        if (typeof(TStreamType) == typeof(StreamTypes.For)) World.For<T1, T2>(Update);
        else if (typeof(TStreamType) == typeof(StreamTypes.Job)) World.Job<T1, T2>(Update);
    }
}
