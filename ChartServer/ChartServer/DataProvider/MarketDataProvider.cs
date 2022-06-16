using SharedModels;

namespace ChartServer.DataProvider
{
    public static class MarketDataProvider
    {
        public static List<Market> GetMarketData()
        {
            var random = new Random();
            var marketData = new List<Market>()
            { 
                new () { CompanyName = "MS-IT Services", Volume = random.Next(1,900)},
                new () { CompanyName = "TS-IT Providers", Volume = random.Next(1,900)},
                new () { CompanyName = "LS-SL Sales", Volume = random.Next(1,900)},
                new () { CompanyName = "MS-Electronics", Volume = random.Next(1,900)},
                new () { CompanyName = "TS-Electrical", Volume = random.Next(1,900)},
                new () { CompanyName = "LS-Foods", Volume = random.Next(1,900)},
                new () { CompanyName = "MS-Healthcare", Volume = random.Next(1,900)},
                new () { CompanyName = "LS-Pharmas", Volume = random.Next(1,900)},
                new () { CompanyName = "TS-Healthcare", Volume = random.Next(1,900)}
            };
            return marketData;
        }
    }
}
