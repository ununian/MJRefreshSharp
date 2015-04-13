namespace MJRefresh
{
    public enum MJRefreshHeaderState : uint
    {
        Idle = 1,
        Pulling,
        Refreshing,
        WillRefresh
    }

    public enum MJRefreshFooterState : uint
    {
        Idle = 1,
        Refreshing,
        NoMoreData
    }
}
