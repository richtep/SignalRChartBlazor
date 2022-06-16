using ChartServer.DataProvider;
using ChartServer.RHub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChartServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly IHubContext<MarketHub> _marketHub;
        private readonly TimeWatcher _watcher;

        public MarketController(IHubContext<MarketHub> mktHub, TimeWatcher watch)
        {
            _marketHub = mktHub;
            _watcher = watch;
        }
        [HttpGet]
        public IActionResult Get()
        {
            if(!_watcher.IsWatcherStarted)
            {
                _watcher.Watcher(()=>_marketHub.Clients.All.SendAsync("SendMarketStatusData",MarketDataProvider.GetMarketData()));
            }
            return Ok(new {Message = "Request Completed"});
        }
        
    }
}
