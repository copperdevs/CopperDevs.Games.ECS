using fennecs;

namespace CopperDevs.Games.ECS;

public partial class World
{
    public Stream<C1> Stream<C1>()
        where C1 : notnull =>
        QueryEntities<C1>().Stream();

    public Stream<C1, C2> Stream<C1, C2>()
        where C1 : notnull
        where C2 : notnull =>
        QueryEntities<C1, C2>().Stream();

    public Stream<C1, C2, C3> Stream<C1, C2, C3>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        QueryEntities<C1, C2, C3>().Stream();

    public Stream<C1, C2, C3, C4> Stream<C1, C2, C3, C4>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        QueryEntities<C1, C2, C3, C4>().Stream();

    public Stream<C1, C2, C3, C4, C5> Stream<C1, C2, C3, C4, C5>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        QueryEntities<C1, C2, C3, C4, C5>().Stream();

    public Stream<C1> Stream<C1>(params IFilter[] filters)
        where C1 : notnull =>
        QueryEntities<C1>(filters).Stream();

    public Stream<C1, C2> Stream<C1, C2>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull =>
        QueryEntities<C1, C2>(filters).Stream();

    public Stream<C1, C2, C3> Stream<C1, C2, C3>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        QueryEntities<C1, C2, C3>(filters).Stream();

    public Stream<C1, C2, C3, C4> Stream<C1, C2, C3, C4>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        QueryEntities<C1, C2, C3, C4>(filters).Stream();

    public Stream<C1, C2, C3, C4, C5> Stream<C1, C2, C3, C4, C5>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        QueryEntities<C1, C2, C3, C4, C5>(filters).Stream();
}
