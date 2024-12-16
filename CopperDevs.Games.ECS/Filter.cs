using fennecs;

namespace CopperDevs.Games.ECS;

public record struct HasFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public readonly T FilterQuery<T>(T queryBuilder)
        where T : QueryBuilderBase<T>
        => queryBuilder.Has<TTargetType>();
}

public record struct NotFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public readonly T FilterQuery<T>(T queryBuilder)
        where T : QueryBuilderBase<T>
        => queryBuilder.Not<TTargetType>();
}

public record struct AnyFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public readonly T FilterQuery<T>(T queryBuilder)
        where T : QueryBuilderBase<T>
        => queryBuilder.Any<TTargetType>();
}

public interface IFilter
{
    public T FilterQuery<T>(T queryBuilder) where T : QueryBuilderBase<T>;
}
