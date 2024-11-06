using System.Diagnostics.CodeAnalysis;
using CopperDevs.Games.ECS.Internal;

namespace CopperDevs.Games.ECS;

public partial class World
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1> QueryEntities<C1>()
        where C1 : notnull =>
        new(this);

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2> QueryEntities<C1, C2>()
        where C1 : notnull
        where C2 : notnull =>
        new(this);

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3> QueryEntities<C1, C2, C3>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        new(this);

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3, C4> QueryEntities<C1, C2, C3, C4>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        new(this);

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3, C4, C5> QueryEntities<C1, C2, C3, C4, C5>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        new(this);

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1> QueryEntities<C1>(params IFilter[] filters)
        where C1 : notnull =>
        filters.Aggregate(QueryEntities<C1>(), (current, filter) => filter.FilterQuery(current));

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2> QueryEntities<C1, C2>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull =>
        filters.Aggregate(QueryEntities<C1, C2>(), (current, filter) => filter.FilterQuery(current));

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3> QueryEntities<C1, C2, C3>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        filters.Aggregate(QueryEntities<C1, C2, C3>(), (current, filter) => filter.FilterQuery(current));

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3, C4> QueryEntities<C1, C2, C3, C4>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        filters.Aggregate(QueryEntities<C1, C2, C3, C4>(), (current, filter) => filter.FilterQuery(current));

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public QueryBuilder<C1, C2, C3, C4, C5> QueryEntities<C1, C2, C3, C4, C5>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        filters.Aggregate(QueryEntities<C1, C2, C3, C4, C5>(), (current, filter) => filter.FilterQuery(current));
}