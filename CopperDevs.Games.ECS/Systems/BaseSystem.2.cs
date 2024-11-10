namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem<T1, T2> : BaseSystem
    where T1 : notnull, new()
    where T2 : notnull, new()
{
    public abstract void Update(ref T1 componentOne, ref T2 componentTwo);

    protected internal override void UpdateSystem<TStreamType>(IFilter[] filters)
    {
        var stream = World.QueryEntities<T1, T2>(filters).Stream();

        if (typeof(TStreamType) == typeof(StreamTypes.For)) stream.For(Update);
        else if (typeof(TStreamType) == typeof(StreamTypes.Job)) stream.Job(Update);
    }
}