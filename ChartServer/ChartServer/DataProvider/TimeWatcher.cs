namespace ChartServer.DataProvider;

/// <summary>
/// This call will be used to send the data after each second to the client
/// </summary>
public class TimeWatcher
{
    private Action? _executor;
    private Timer? _timer;
    // we need to auto-reset the event before the execution
    private AutoResetEvent? _autoResetEvent;


    public DateTime WatcherStarted { get; set; }

    public bool IsWatcherStarted { get; set; }

    /// <summary>
    /// Method for the Timer Watcher
    /// This will be invoked when the Controller receives the request
    /// </summary>
    public void Watcher(Action execute)
    {
        const int callBackDelayBeforeInvokeCallback = 1000;
        const int timeIntervalBetweenInvokeCallback = 2000;
        _executor = execute;
        _autoResetEvent = new AutoResetEvent(false);
        _timer = new Timer(
            (object? obj) => 
        {
            _executor();
            if ((DateTime.Now - WatcherStarted).TotalSeconds <= 63) return;
            IsWatcherStarted = false;
            _timer?.Dispose();
        }, _autoResetEvent, callBackDelayBeforeInvokeCallback, timeIntervalBetweenInvokeCallback);

        WatcherStarted = DateTime.Now;
        IsWatcherStarted = true;
    }
}
