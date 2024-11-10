﻿namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem<T1, T2, T3, T4> : BaseSystem
    where T1 : notnull, new()
    where T2 : notnull, new()
    where T3 : notnull, new()
    where T4 : notnull, new()
{
    public abstract void Update(ref T1 componentOne, ref T2 componentTwo, ref T3 componentThree, ref T4 componentFour);

    protected internal override void UpdateSystem<TStreamType>(IFilter[] filters)
    {
        var stream = World.QueryEntities<T1, T2, T3, T4>(filters).Stream();

        if (typeof(TStreamType) == typeof(StreamTypes.For)) stream.For(Update);
        else if (typeof(TStreamType) == typeof(StreamTypes.Job)) stream.Job(Update);
    }
}
