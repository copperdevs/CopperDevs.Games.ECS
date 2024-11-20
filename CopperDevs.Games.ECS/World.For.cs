using fennecs;

namespace CopperDevs.Games.ECS;

public partial class World
{
    public void For<C1>(ComponentAction<C1> action)
        where C1 : notnull =>
        QueryEntities<C1>().Stream().For(action);

    public void For<C1, C2>(ComponentAction<C1, C2> action)
        where C1 : notnull
        where C2 : notnull =>
        QueryEntities<C1, C2>().Stream().For(action);

    public void For<C1, C2, C3>(ComponentAction<C1, C2, C3> action)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        QueryEntities<C1, C2, C3>().Stream().For(action);

    public void For<C1, C2, C3, C4>(ComponentAction<C1, C2, C3, C4> action)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        QueryEntities<C1, C2, C3, C4>().Stream().For(action);

    public void For<C1, C2, C3, C4, C5>(ComponentAction<C1, C2, C3, C4, C5> action)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        QueryEntities<C1, C2, C3, C4, C5>().Stream().For(action);

    public void For<C1>(ComponentAction<C1> action, params IFilter[] filters)
        where C1 : notnull =>
        QueryEntities<C1>(filters).Stream().For(action);

    public void For<C1, C2>(ComponentAction<C1, C2> action, params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull =>
        QueryEntities<C1, C2>(filters).Stream().For(action);

    public void For<C1, C2, C3>(ComponentAction<C1, C2, C3> action, params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull =>
        QueryEntities<C1, C2, C3>(filters).Stream().For(action);

    public void For<C1, C2, C3, C4>(ComponentAction<C1, C2, C3, C4> action, params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull =>
        QueryEntities<C1, C2, C3, C4>(filters).Stream().For(action);

    public void For<C1, C2, C3, C4, C5>(ComponentAction<C1, C2, C3, C4, C5> action, params IFilter[] filters)
        where C1 : notnull
        where C2 : notnull
        where C3 : notnull
        where C4 : notnull
        where C5 : notnull =>
        QueryEntities<C1, C2, C3, C4, C5>(filters).Stream().For(action);
}
