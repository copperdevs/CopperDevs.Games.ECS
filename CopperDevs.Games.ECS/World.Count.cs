namespace CopperDevs.Games.ECS;

public partial class World
{
    public int Count<C1>()
        where C1 : notnull =>
        Stream<C1>().Count;

    public int Count<C1, C2>()
        where C1 : notnull
        where C2 : notnull =>
        Stream<C1, C2>().Count;

    public int Count<C1, C2, C3>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        Stream<C1, C2, C3>().Count;

    public int Count<C1, C2, C3, C4>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        Stream<C1, C2, C3, C4>().Count;

    public int Count<C1, C2, C3, C4, C5>()
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        Stream<C1, C2, C3, C4, C5>().Count;

    public int Count<C1>(params IFilter[] filters)
        where C1 : notnull =>
        Stream<C1>(filters).Count;

    public int Count<C1, C2>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull =>
        Stream<C1, C2>(filters).Count;

    public int Count<C1, C2, C3>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        Stream<C1, C2, C3>(filters).Count;

    public int Count<C1, C2, C3, C4>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        Stream<C1, C2, C3, C4>(filters).Count;

    public int Count<C1, C2, C3, C4, C5>(params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        Stream<C1, C2, C3, C4, C5>(filters).Count;
}
