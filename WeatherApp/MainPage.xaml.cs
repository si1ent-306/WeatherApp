using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private const string ApiKey = "f63648645d31e18e90750d381665a9a3";
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string city = SearchEntry.Text;

            if (!string.IsNullOrEmpty(city))
            {
                CityLabel.Text = city;
                string url = $"{BaseUrl}?q={city}&appid={ApiKey}&units=metric";

                try
                {
                    string json = await client.GetStringAsync(url);
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(json);

                    if (weatherResponse != null && weatherResponse.Main != null)
                    {
                        double temperature = weatherResponse.Main.Temp;
                        TemperatureLabel.Text = $"Temperature: {temperature}°C";
                        Console.WriteLine($"Temperature in {city}: {temperature}°C");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching weather data: {ex.Message}");
                }
            }
        }

        public class WeatherResponse
        {
            [JsonProperty("main")]
            public MainInfo Main { get; set; }
        }

        public class MainInfo
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }
        }
    }

    public class Weather
    { 
        public string name { get; set;  }
        public string temp { get; set; }
    }
}
