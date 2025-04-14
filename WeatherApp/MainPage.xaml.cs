using System.Text.Json;
using System.Net.Http;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private const string ApiKey = "f63648645d31e18e90750d381665a9a3";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (SearchEntry.Text != null) 
            {
                CityLabel.Text = SearchEntry.Text;
            }
            
        }
    }
    
}
