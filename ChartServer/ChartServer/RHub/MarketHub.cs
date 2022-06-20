using Microsoft.AspNetCore.SignalR;
using SharedModels;

namespace ChartServer.RHub
{
    public class MarketHub : Hub
    {
        public async Task AcceptData(List<Market> data) => await Clients.All.SendAsync("CommunicateMarketData", data);
        public async Task ReadCurrentLabelText(string text) => await Clients.All.SendAsync("CommunicateLabelText", text);
    }
}
