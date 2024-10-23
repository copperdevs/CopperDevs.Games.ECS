using fennecs;

namespace CopperDevs.Games.ECS.Utility;

internal static class QueryBuilderExtensions
{
    private enum FilterType
    {
        Has,
        Not,
        Any
    }

    private static TQueryBuilder BaseFilter<TQueryBuilder>(TQueryBuilder queryBuilder, Type type, FilterType filterType)
        where TQueryBuilder : class
    {
        var queryBuilderType = queryBuilder.GetType();

        var method = queryBuilderType.GetMethod(filterType.ToString(), [typeof(Match)]);

        var genericMethod = method?.MakeGenericMethod(type);

        genericMethod?.Invoke(queryBuilder, [default(Match)]);

        return queryBuilder;
    }

    internal static TQueryBuilder Has<TQueryBuilder>(this TQueryBuilder queryBuilder, Type type)
        where TQueryBuilder : class =>
        BaseFilter(queryBuilder, type, FilterType.Has);

    internal static TQueryBuilder Not<TQueryBuilder>(this TQueryBuilder queryBuilder, Type type)
        where TQueryBuilder : class =>
        BaseFilter(queryBuilder, type, FilterType.Not);

    internal static TQueryBuilder Any<TQueryBuilder>(this TQueryBuilder queryBuilder, Type type)
        where TQueryBuilder : class =>
        BaseFilter(queryBuilder, type, FilterType.Any);
}