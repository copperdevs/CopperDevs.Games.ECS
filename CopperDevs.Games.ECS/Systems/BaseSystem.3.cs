﻿namespace CopperDevs.Games.ECS.Systems;

public abstract class BaseSystem<T1, T2, T3> : BaseSystem
    where T1 : notnull, new()
    where T2 : notnull, new()
    where T3 : notnull, new()
{
    public abstract void Update(ref T1 componentOne, ref T2 componentTwo, ref T3 componentThree);

    protected internal override void UpdateSystem<TStreamType>(IFilter[] filters)
    {
        if (typeof(TStreamType) == typeof(StreamTypes.For)) World.For<T1, T2, T3>(Update);
        else if (typeof(TStreamType) == typeof(StreamTypes.Job)) World.Job<T1, T2, T3>(Update);
    }
}
