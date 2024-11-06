using CopperDevs.Games.ECS.Internal;
using CopperDevs.Games.ECS.Utility;

namespace CopperDevs.Games.ECS;

public enum FilterType
{
    Has,
    Not,
    Any
}

public record struct HasFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public T FilterQuery<T>(T queryBuilder) where T : QueryBuilder => (T)queryBuilder.Not<TTargetType>();
}

public record struct NotFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public T FilterQuery<T>(T queryBuilder) where T : QueryBuilder => (T)queryBuilder.Not<TTargetType>();
}

public record struct AnyFilter<TTargetType> : IFilter
    where TTargetType : notnull, new()
{
    public T FilterQuery<T>(T queryBuilder) where T : QueryBuilder => (T)queryBuilder.Any<TTargetType>();
}

public interface IFilter
{
    public T FilterQuery<T>(T queryBuilder) where T : QueryBuilder;
}