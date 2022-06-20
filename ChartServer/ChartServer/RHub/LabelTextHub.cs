using Microsoft.AspNetCore.SignalR;

namespace ChartServer.RHub
{
    public class LabelTextHub : Hub
    {
        public async Task ReadCurrentLabelText(string text) => await Clients.All.SendAsync("CommunicateLabelText", text);
    }
}
