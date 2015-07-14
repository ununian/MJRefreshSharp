namespace MJRefresh
{
    public enum MJRefreshState : uint
    {
        Idle = 1,
        Pulling,
        Refreshing,
        WillRefresh,
        NoMoreData
    }
}
