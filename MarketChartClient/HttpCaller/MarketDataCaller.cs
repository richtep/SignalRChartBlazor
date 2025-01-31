﻿namespace MarketChartClient.HttpCaller;

    public class MarketDataCaller
    {
        private readonly HttpClient _httpClient;

        public MarketDataCaller(HttpClient http)
        {
            _httpClient = http;
        }

        public async Task GetMarketDataAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("marketdata");

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection make sure that the server is running.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task GetLabelTextAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("labelText");

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection make sure that the server is running.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    public async Task GetMarketEndpoint()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7193/api/Market");
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection so get call is not executing.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task GetLabelText()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7193/api/Text/StartText");
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection so get call is not executing.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

}

