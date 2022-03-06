using System.Runtime.Serialization;

namespace SmartAdmin.Seed.Data.Repositories.Dtos
{
    [DataContract()]
    public class OpenWeatherDto
    {
        [DataMember(Name = "coord")]
        public Coord Coord { get;set; }
        [DataMember(Name = "weather")]
        public Weather[] Weather { get; set; }
        [DataMember(Name = "base")]
        public string BaseSourceOfData { get; set; }
        [DataMember(Name = "main")]
        public Main Main { get; set; }
        [DataMember(Name = "Visibility")]
        public int Visibility { get; set; }
        [DataMember(Name = "wind")]
        public Wind Wind{ get; set; }
        [DataMember(Name = "clouds")]
        public Clouds Clouds{ get; set; }
        [DataMember(Name = "dt")]
        public int Dt{ get; set; }
        [DataMember(Name = "sys")]
        public ForecastSystem Sys { get; set; }
        [DataMember(Name = "timezone")]
        public int Timezone{ get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string CityName { get; set; }
        [DataMember(Name = "cod")]
        public int Cod{ get; set; }
    }
    [DataContract()]
    public class Coord
    {
        [DataMember(Name = "lon")]
        public float Longitude { get; set; }
        [DataMember(Name = "lat")]
        public float Latitude { get; set; }
    }
    [DataContract()]
    public class Weather
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "main")]
        public string MainBody { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
    }
    [DataContract()]
    public class Main
    {
        [DataMember(Name = "temp")]
        public double Temprature { get; set; }
        [DataMember(Name = "feels_like")]
        public double Feels_like { get; set; }
        [DataMember(Name = "temp_min")]
        public double Temprature_min { get; set; }
        [DataMember(Name = "temp_max")]
        public double Temprature_max { get; set; }
        [DataMember(Name = "pressure")]
        public int Pressure { get; set; }
    }
    [DataContract()]
    public class Wind
    {
        [DataMember(Name = "speed")]
        public double Speed { get; set; }
        [DataMember(Name = "deg")]
        public int Degrees { get; set; }
    }
    [DataContract()]
    public class Clouds
    {
        [DataMember(Name = "all")]
        public int All { get; set; }
    }
    [DataContract()]
    public class ForecastSystem
    {
        [DataMember(Name = "type")]
        public int ForecastSystemType { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "sunrise")]
        public int Sunrise { get; set; }
        [DataMember(Name = "sunset")]
        public int Sunset { get; set; }
    }





}
