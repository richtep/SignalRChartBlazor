using ChartServer.DataProvider;
using ChartServer.RHub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChartServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly IHubContext<MarketHub> _marketHub;
        private readonly TimeWatcher _watcher;

        public TextController(IHubContext<MarketHub> mktHub, TimeWatcher watch)
        {
            _marketHub = mktHub;
            _watcher = watch;
        }

        [HttpGet("{textValue}")]
        public ContentResult TextResult(string textValue)
        {
            _marketHub.Clients.All.SendAsync("SendLabelText", textValue);
            return Content(textValue);
        }
    }
}