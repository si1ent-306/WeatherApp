using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    //{
    //   "coord":{
    //      "lon":-104.6178,
    //      "lat":50.4501
    //   },
    //   "weather":[
    //      {
    //         "id":801,
    //         "main":"Clouds",
    //         "description":"few clouds",
    //         "icon":"02d"
    //      }
    //   ],
    //   "base":"stations",
    //   "main":{
    //    "temp":283.9,
    //      "feels_like":281.79,
    //      "temp_min":283.14,
    //      "temp_max":284.14,
    //      "pressure":1023,
    //      "humidity":29,
    //      "sea_level":1023,
    //      "grnd_level":954
    //   },
    //   "visibility":10000,
    //   "wind":{
    //    "speed":9.26,
    //      "deg":330,
    //      "gust":14.92
    //   },
    //   "clouds":{
    //    "all":20
    //   },
    //   "dt":1744662908,
    //   "sys":{
    //    "type":1,
    //      "id":903,
    //      "country":"CA",
    //      "sunrise":1744632351,
    //      "sunset":1744681861
    //   },
    //   "timezone":-21600,
    //   "id":6119109,
    //   "name":"Regina",
    //   "cod":200
    //}
    public class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Sea_Level { get; set; }
        public int Grnd_Level { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }

    public class WeatherData
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public long Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    } 
}
