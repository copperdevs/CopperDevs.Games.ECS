namespace CopperDevs.Games.ECS.Internal;

public abstract class QueryBuilder
{
    private readonly Dictionary<Type, FilterType> queries = [];
    internal readonly World world;

    internal QueryBuilder(World world)
    {
        this.world = world;
    }

    private QueryBuilder Filter(Type type, FilterType filter)
    {
        queries.TryAdd(type, filter);
        return this;
    }

    public QueryBuilder Has<T>() where T : notnull => Filter(typeof(T), FilterType.Has);
    public QueryBuilder Not<T>() where T : notnull => Filter(typeof(T), FilterType.Not);
    public QueryBuilder Any<T>() where T : notnull => Filter(typeof(T), FilterType.Any);ww
}

public sealed class QueryBuilder<T1> : QueryBuilder
    where T1 : notnull
{
    internal QueryBuilder(World world) : base(world)
    {
        Has<T1>();
    }
}

public sealed class QueryBuilder<T1, T2> : QueryBuilder
    where T1 : notnull
    where T2 : notnull
{
    internal QueryBuilder(World world) : base(world)
    {
        Has<T1>();
        Has<T1>();
    }
}

public sealed class QueryBuilder<T1, T2, T3> : QueryBuilder
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
{
    internal QueryBuilder(World world) : base(world)
    {
        Has<T1>();
        Has<T2>();
        Has<T3>();
    }
}

public sealed class QueryBuilder<T1, T2, T3, T4> : QueryBuilder
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
{
    internal QueryBuilder(World world) : base(world)
    {
        Has<T1>();
        Has<T2>();
        Has<T3>();
        Has<T4>();
    }
}

public sealed class QueryBuilder<T1, T2, T3, T4, T5> : QueryBuilder
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
{
    internal QueryBuilder(World world) : base(world)
    {
        Has<T1>();
        Has<T2>();
        Has<T3>();
        Has<T4>();
        Has<T5>();
    }
}