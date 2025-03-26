namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (CityLabel.Text != "")
            {
                CityLabel.Text = SearchEntry.Text;
            }
        }
    }

}
